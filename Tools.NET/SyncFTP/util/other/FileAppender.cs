using System;
using System.IO;

namespace EnterpriseDT.Util.Debug
{
	public class FileAppender : Appender
	{
		protected TextWriter logger;

		protected FileStream fileStream;

		private string fileName;

		protected bool closed;

		public string FileName
		{
			get
			{
				return this.fileName;
			}
		}

		public FileAppender(string fileName)
		{
			this.fileName = new FileInfo(fileName).FullName;
			this.Open();
		}

		protected void Open()
		{
			this.fileStream = new FileStream(this.fileName, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			this.logger = TextWriter.Synchronized(new StreamWriter(this.fileStream));
			this.closed = false;
		}

		public virtual void Log(string msg)
		{
			if (!this.closed)
			{
				this.logger.WriteLine(msg);
				this.logger.Flush();
				return;
			}
			Console.WriteLine(msg);
		}

		public virtual void Log(Exception t)
		{
			if (!this.closed)
			{
				this.logger.WriteLine(t.GetType().FullName + ": " + t.Message);
				this.logger.WriteLine(t.StackTrace.ToString());
				this.logger.Flush();
				return;
			}
			Console.WriteLine(t.GetType().FullName + ": " + t.Message);
		}

		public virtual void Close()
		{
			this.closed = true;
			this.logger.Flush();
			this.logger.Close();
			this.logger = null;
			this.fileStream = null;
		}
	}
}
