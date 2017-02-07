using System;

namespace EnterpriseDT.Util.Debug
{
	public class LogMessageEventArgs : EventArgs
	{
		private string loggerName;

		private Level level;

		private string text;

		private Exception e;

		private object[] args;

		public Level LogLevel
		{
			get
			{
				return this.level;
			}
		}

		public string LoggerName
		{
			get
			{
				return this.loggerName;
			}
		}

		public string Text
		{
			get
			{
				return this.text;
			}
		}

		public string FormattedText
		{
			get
			{
				if (this.text != null && this.args != null)
				{
					return string.Format(this.text, this.args);
				}
				return this.text;
			}
		}

		public Exception Exception
		{
			get
			{
				return this.e;
			}
		}

		public object[] Arguments
		{
			get
			{
				return this.args;
			}
		}

		internal LogMessageEventArgs(string loggerName, Level level, string text, params object[] args)
		{
			this.loggerName = loggerName;
			this.level = level;
			this.text = text;
			this.args = args;
			if (args != null && args.Length == 1 && args[0] is Exception)
			{
				this.e = (Exception)args[0];
			}
		}
	}
}
