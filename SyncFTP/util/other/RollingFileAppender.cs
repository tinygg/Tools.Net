using System;
using System.IO;
using System.Text;

namespace EnterpriseDT.Util.Debug
{
	public class RollingFileAppender : FileAppender
	{
		private const long DEFAULT_MAXSIZE = 10485760L;

		private const int CHECK_THRESHOLD_BYTES = 5120;

		private long maxFileSize = 10485760L;

		private int thresholdBytesWritten;

		private int maxSizeRollBackups = 1;

		public int MaxSizeRollBackups
		{
			get
			{
				return this.maxSizeRollBackups;
			}
			set
			{
				this.maxSizeRollBackups = ((value >= 0) ? value : 0);
			}
		}

		public long MaxFileSize
		{
			get
			{
				return this.maxFileSize;
			}
			set
			{
				this.maxFileSize = value;
			}
		}

		public RollingFileAppender(string fileName, long maxFileSize) : base(fileName)
		{
			this.maxFileSize = maxFileSize;
			this.CheckSizeForRollover();
		}

		public RollingFileAppender(string fileName) : base(fileName)
		{
			this.CheckSizeForRollover();
		}

		private void CheckForRollover()
		{
			if (this.thresholdBytesWritten < 5120)
			{
				return;
			}
			this.thresholdBytesWritten = 0;
			this.CheckSizeForRollover();
		}

		private void CheckSizeForRollover()
		{
			try
			{
				if (this.fileStream.Length > this.maxFileSize)
				{
					this.Rollover();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Failed to rollover log files (" + ex.Message + ")");
			}
		}

		private void Rollover()
		{
			this.Close();
			FileInfo fileInfo = new FileInfo(base.FileName);
			if (this.maxSizeRollBackups == 0)
			{
				fileInfo.Delete();
			}
			else
			{
				FileInfo fileInfo2 = new FileInfo(base.FileName + "." + this.maxSizeRollBackups);
				if (fileInfo2.Exists)
				{
					fileInfo2.Delete();
				}
				for (int i = this.maxSizeRollBackups - 1; i > 0; i--)
				{
					fileInfo2 = new FileInfo(base.FileName + "." + i);
					if (fileInfo2.Exists)
					{
						fileInfo2.MoveTo(base.FileName + "." + (i + 1));
					}
				}
				fileInfo.MoveTo(base.FileName + ".1");
			}
			base.Open();
		}

		public override void Log(string msg)
		{
			lock (this)
			{
				if (!this.closed)
				{
					this.CheckForRollover();
					this.logger.WriteLine(msg);
					this.thresholdBytesWritten += msg.Length;
					this.logger.Flush();
				}
				else
				{
					Console.WriteLine(msg);
				}
			}
		}

		public override void Log(Exception t)
		{
			StringBuilder stringBuilder = new StringBuilder(t.GetType().FullName);
			stringBuilder.Append(": ").Append(t.Message);
			lock (this)
			{
				if (!this.closed)
				{
					this.CheckForRollover();
					string text = stringBuilder.ToString();
					this.logger.WriteLine(text);
					this.thresholdBytesWritten += text.Length;
					text = t.StackTrace.ToString();
					this.logger.WriteLine(text);
					this.thresholdBytesWritten += text.Length;
					this.logger.Flush();
				}
				else
				{
					Console.WriteLine(stringBuilder.ToString());
				}
			}
		}
	}
}
