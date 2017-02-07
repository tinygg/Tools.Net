using System;

namespace EnterpriseDT.Util.Debug
{
	public class Level
	{
		private const string OFF_STR = "OFF";

		private const string FATAL_STR = "FATAL";

		private const string ERROR_STR = "ERROR";

		private const string WARN_STR = "WARN";

		private const string INFO_STR = "INFO";

		private const string DEBUG_STR = "DEBUG";

		private const string ALL_STR = "ALL";

		public static Level OFF = new Level(LogLevel.Off, "OFF");

		public static Level FATAL = new Level(LogLevel.Fatal, "FATAL");

		public static Level ERROR = new Level(LogLevel.Error, "ERROR");

		public static Level WARN = new Level(LogLevel.Warning, "WARN");

		public static Level INFO = new Level(LogLevel.Information, "INFO");

		public static Level DEBUG = new Level(LogLevel.Debug, "DEBUG");

		public static Level ALL = new Level(LogLevel.All, "ALL");

		private LogLevel level = LogLevel.Off;

		private string levelStr;

		private Level(LogLevel level, string levelStr)
		{
			this.level = level;
			this.levelStr = levelStr;
		}

		public LogLevel GetLevel()
		{
			return this.level;
		}

		public bool IsGreaterOrEqual(Level l)
		{
			return this.level >= l.level;
		}

		public static Level GetLevel(string level)
		{
			string key;
			switch (key = level.ToUpper())
			{
			case "OFF":
				return Level.OFF;
			case "FATAL":
				return Level.FATAL;
			case "ERROR":
				return Level.ERROR;
			case "WARN":
				return Level.WARN;
			case "INFO":
				return Level.INFO;
			case "DEBUG":
				return Level.DEBUG;
			case "ALL":
				return Level.ALL;
			}
			return null;
		}

		public static Level GetLevel(LogLevel level)
		{
			switch (level)
			{
			case LogLevel.Off:
				return Level.OFF;
			case LogLevel.Fatal:
				return Level.FATAL;
			case LogLevel.Error:
				return Level.ERROR;
			case LogLevel.Warning:
				return Level.WARN;
			case LogLevel.Information:
				return Level.INFO;
			case LogLevel.Debug:
				return Level.DEBUG;
			case LogLevel.All:
				return Level.ALL;
			}
			return Level.OFF;
		}

		public override string ToString()
		{
			return this.levelStr;
		}
	}
}
