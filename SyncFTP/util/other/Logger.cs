using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Threading;

namespace EnterpriseDT.Util.Debug
{
	public class Logger
	{
		private static Level globalLevel;

		private static readonly string format;

		private static readonly string LEVEL_PARAM;

		private static Hashtable loggers;

		private static ArrayList appenders;

		private DateTime ts;

		private string clazz;

		private static bool showClassNames;

		private static bool showTimestamp;

		private static Dictionary<int, ILogTag> threadTags;

		private static FileAppender mainFileAppender;

		private static StandardOutputAppender mainConsoleAppender;

		private static TraceAppender mainTraceAppender;

		public static event LogMessageHandler LogMessageReceived;

		public static Level CurrentLevel
		{
			get
			{
				return Logger.globalLevel;
			}
			set
			{
				Logger.globalLevel = value;
			}
		}

		public static bool ShowClassNames
		{
			get
			{
				return Logger.showClassNames;
			}
			set
			{
				Logger.showClassNames = value;
			}
		}

		public static bool ShowTimestamp
		{
			get
			{
				return Logger.showTimestamp;
			}
			set
			{
				Logger.showTimestamp = value;
			}
		}

		public virtual bool ErrorEnabled
		{
			get
			{
				return this.IsEnabledFor(Level.ERROR);
			}
		}

		public virtual bool DebugEnabled
		{
			get
			{
				return this.IsEnabledFor(Level.DEBUG);
			}
		}

		public virtual bool InfoEnabled
		{
			get
			{
				return this.IsEnabledFor(Level.INFO);
			}
		}

		public static string PrimaryLogFile
		{
			get
			{
				if (Logger.mainFileAppender == null)
				{
					return null;
				}
				return Logger.mainFileAppender.FileName;
			}
			set
			{
				string a = (Logger.mainFileAppender != null) ? Logger.mainFileAppender.FileName : null;
				if (a != value)
				{
					if (Logger.mainFileAppender != null)
					{
						Logger.RemoveAppender(Logger.mainFileAppender);
					}
					if (value != null)
					{
						Logger.AddAppender(new FileAppender(value));
					}
				}
			}
		}

		public static bool LogToConsole
		{
			get
			{
				return Logger.mainConsoleAppender != null;
			}
			set
			{
				if (value)
				{
					if (Logger.mainConsoleAppender == null)
					{
						Logger.AddAppender(new StandardOutputAppender());
						return;
					}
				}
				else if (Logger.mainConsoleAppender != null)
				{
					Logger.RemoveAppender(Logger.mainConsoleAppender);
				}
			}
		}

		public static bool LogToTrace
		{
			get
			{
				return Logger.mainTraceAppender != null;
			}
			set
			{
				if (value)
				{
					if (Logger.mainTraceAppender == null)
					{
						Logger.AddAppender(new TraceAppender());
						return;
					}
				}
				else if (Logger.mainTraceAppender != null)
				{
					Logger.RemoveAppender(Logger.mainTraceAppender);
				}
			}
		}

		public static void SetTag(ILogTag tag)
		{
			if (tag == null)
			{
				return;
			}
			lock (Logger.threadTags)
			{
				Logger.threadTags[Thread.CurrentThread.ManagedThreadId] = tag;
			}
		}

		public static void ClearTag()
		{
		}

		private static string GetTag()
		{
			string result;
			lock (Logger.threadTags)
			{
				if (Logger.threadTags.ContainsKey(Thread.CurrentThread.ManagedThreadId))
				{
					result = Logger.threadTags[Thread.CurrentThread.ManagedThreadId].GetLogTag();
				}
				else
				{
					result = "";
				}
			}
			return result;
		}

		private Logger(string clazz)
		{
			this.clazz = clazz;
		}

		public static Logger GetLogger(Type clazz)
		{
			return Logger.GetLogger(clazz.FullName);
		}

		public static Logger GetLogger(string clazz)
		{
			Logger logger = (Logger)Logger.loggers[clazz];
			if (logger == null)
			{
				logger = new Logger(clazz);
				Logger.loggers[clazz] = logger;
			}
			return logger;
		}

		public static void AddAppender(Appender newAppender)
		{
			Logger.appenders.Add(newAppender);
			if (newAppender is FileAppender && Logger.mainFileAppender == null)
			{
				Logger.mainFileAppender = (FileAppender)newAppender;
			}
			if (newAppender is StandardOutputAppender && Logger.mainConsoleAppender == null)
			{
				Logger.mainConsoleAppender = (StandardOutputAppender)newAppender;
			}
			if (newAppender is TraceAppender && Logger.mainTraceAppender == null)
			{
				Logger.mainTraceAppender = (TraceAppender)newAppender;
			}
		}

		public static void RemoveAppender(Appender appender)
		{
			Logger.appenders.Remove(appender);
			if (appender == Logger.mainFileAppender)
			{
				Logger.mainFileAppender = null;
			}
			if (appender == Logger.mainConsoleAppender)
			{
				Logger.mainConsoleAppender = null;
			}
			if (appender == Logger.mainTraceAppender)
			{
				Logger.mainTraceAppender = null;
			}
		}

		public static void Shutdown()
		{
			Logger.ClearAppenders();
			Logger.loggers.Clear();
		}

		public static void ClearAppenders()
		{
			lock (Logger.appenders.SyncRoot)
			{
				for (int i = 0; i < Logger.appenders.Count; i++)
				{
					Appender appender = (Appender)Logger.appenders[i];
					try
					{
						appender.Close();
					}
					catch (Exception)
					{
					}
				}
			}
			Logger.appenders.Clear();
		}

		public virtual void Log(Level level, string message, params object[] args)
		{
			if (Logger.LogMessageReceived != null)
			{
				Logger.LogMessageReceived(this, new LogMessageEventArgs(this.clazz, level, message, args));
			}
			if (this.IsEnabledFor(level))
			{
				if (args != null && args.Length == 1 && args[0] is Exception)
				{
					this.OurLog(level, message, (Exception)args[0]);
					return;
				}
				if (args != null)
				{
					this.OurLog(level, string.Format(message, args), null);
					return;
				}
				this.OurLog(level, message, null);
			}
		}

		private void OurLog(Level level, string message, Exception t)
		{
			this.ts = DateTime.Now;
			string value = this.ts.ToString(Logger.format, CultureInfo.CurrentCulture.DateTimeFormat);
			StringBuilder stringBuilder = new StringBuilder(level.ToString());
			if (Logger.showClassNames)
			{
				stringBuilder.Append(" [");
				stringBuilder.Append(this.clazz);
				stringBuilder.Append("]");
			}
			if (Logger.showTimestamp)
			{
				stringBuilder.Append(" ");
				stringBuilder.Append(value);
			}
			stringBuilder.Append(" : ");
			stringBuilder.Append(Logger.GetTag());
			string text = stringBuilder.ToString();
			if (message != null)
			{
				stringBuilder.Append(message);
			}
			if (t != null)
			{
				stringBuilder.Append(" : ").Append(t.GetType().FullName).Append(": ").Append(t.Message);
			}
			if (Logger.appenders.Count == 0)
			{
				Console.Out.WriteLine(stringBuilder.ToString());
				if (t != null)
				{
					if (t.StackTrace != null)
					{
						string[] array = t.StackTrace.Replace("\r", "").Split(new char[]
						{
							'\n'
						});
						for (int i = 0; i < array.Length; i++)
						{
							string str = array[i];
							this.OurLog(level, text + str, null);
						}
					}
					if (t.InnerException != null)
					{
						Console.Out.WriteLine(string.Format("{0}CAUSED BY - {1}: {2}", text, t.InnerException.GetType().FullName, t.InnerException.Message));
						if (t.InnerException.StackTrace != null)
						{
							string[] array2 = t.InnerException.StackTrace.Replace("\r", "").Split(new char[]
							{
								'\n'
							});
							for (int j = 0; j < array2.Length; j++)
							{
								string str2 = array2[j];
								this.OurLog(level, text + str2, null);
							}
							return;
						}
					}
				}
			}
			else
			{
				bool flag = Logger.globalLevel.IsGreaterOrEqual(level);
				lock (Logger.appenders.SyncRoot)
				{
					for (int k = 0; k < Logger.appenders.Count; k++)
					{
						Appender appender = (Appender)Logger.appenders[k];
						bool flag3 = false;
						if (appender is CustomLogLevelAppender)
						{
							CustomLogLevelAppender customLogLevelAppender = (CustomLogLevelAppender)appender;
							flag3 = customLogLevelAppender.CurrentLevel.IsGreaterOrEqual(level);
						}
						if (flag || flag3)
						{
							if (message != null)
							{
								appender.Log(text + message);
							}
							if (t != null)
							{
								appender.Log(text + t.GetType().FullName + ": " + t.Message);
								if (t.StackTrace != null)
								{
									string[] array3 = t.StackTrace.Replace("\r", "").Split(new char[]
									{
										'\n'
									});
									for (int l = 0; l < array3.Length; l++)
									{
										string str3 = array3[l];
										appender.Log(text + str3);
									}
								}
								if (t.InnerException != null)
								{
									appender.Log(string.Concat(new string[]
									{
										text,
										"CAUSED BY - ",
										t.InnerException.GetType().FullName,
										": ",
										t.Message
									}));
									if (t.InnerException.StackTrace != null)
									{
										string[] array4 = t.InnerException.StackTrace.Replace("\r", "").Split(new char[]
										{
											'\n'
										});
										for (int m = 0; m < array4.Length; m++)
										{
											string str4 = array4[m];
											appender.Log(text + str4);
										}
									}
								}
							}
						}
					}
				}
			}
		}

		public virtual void Info(string message)
		{
			this.Log(Level.INFO, message, null);
		}

		public virtual void Info(string message, Exception t)
		{
			this.Log(Level.INFO, message, new object[]
			{
				t
			});
		}

		public virtual void Info(string message, params object[] args)
		{
			if (this.IsEnabledFor(Level.INFO))
			{
				this.Log(Level.INFO, string.Format(message, args), null);
			}
		}

		public virtual void Warn(string message)
		{
			this.Log(Level.WARN, message, null);
		}

		public virtual void Warn(string message, Exception t)
		{
			this.Log(Level.WARN, message, new object[]
			{
				t
			});
		}

		public virtual void Warn(string message, Exception t, params object[] args)
		{
			this.Log(Level.WARN, string.Format(message, args), new object[]
			{
				t
			});
		}

		public virtual void Error(string message)
		{
			this.Log(Level.ERROR, message, null);
		}

		public virtual void Error(string message, Exception t)
		{
			this.Log(Level.ERROR, message, new object[]
			{
				t
			});
		}

		public virtual void Error(string message, Exception t, params object[] args)
		{
			this.Log(Level.ERROR, string.Format(message, args), new object[]
			{
				t
			});
		}

		public virtual void Error(Exception t)
		{
			this.Log(Level.ERROR, null, new object[]
			{
				t
			});
		}

		public virtual void Fatal(string message)
		{
			this.Log(Level.FATAL, message, null);
		}

		public virtual void Fatal(string message, Exception t)
		{
			this.Log(Level.FATAL, message, new object[]
			{
				t
			});
		}

		public virtual void Debug(string message)
		{
			this.Log(Level.DEBUG, message, null);
		}

		public virtual void Debug(string message, params object[] args)
		{
			if (this.IsEnabledFor(Level.DEBUG))
			{
				this.Log(Level.DEBUG, string.Format(message, args), null);
			}
		}

		public virtual void Debug(string message, Exception t)
		{
			this.Log(Level.DEBUG, message, new object[]
			{
				t
			});
		}

		public virtual bool IsEnabledFor(Level level)
		{
			if (Logger.globalLevel.IsGreaterOrEqual(level))
			{
				return true;
			}
			lock (Logger.appenders.SyncRoot)
			{
				foreach (Appender appender in Logger.appenders)
				{
					if (appender is CustomLogLevelAppender)
					{
						CustomLogLevelAppender customLogLevelAppender = (CustomLogLevelAppender)appender;
						if (customLogLevelAppender.CurrentLevel.IsGreaterOrEqual(level))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		static Logger()
		{
			Logger.format = "d MMM yyyy HH:mm:ss.fff";
			Logger.LEVEL_PARAM = "edtftp.log.level";
			Logger.loggers = Hashtable.Synchronized(new Hashtable(10));
			Logger.appenders = ArrayList.Synchronized(new ArrayList(2));
			Logger.showClassNames = true;
			Logger.showTimestamp = true;
			Logger.threadTags = new Dictionary<int, ILogTag>();
			Logger.mainFileAppender = null;
			Logger.mainConsoleAppender = null;
			Logger.mainTraceAppender = null;
			Logger.globalLevel = null;
			string text = null;
			try
			{
				text = ConfigurationSettings.AppSettings[Logger.LEVEL_PARAM];
			}
			catch (Exception ex)
			{
				Console.WriteLine("WARN: Failure reading configuration file: " + ex.Message);
			}
			if (text != null)
			{
				Logger.globalLevel = Level.GetLevel(text);
				if (Logger.globalLevel == null)
				{
					try
					{
						LogLevel level = (LogLevel)Enum.Parse(typeof(LogLevel), text, true);
						Logger.globalLevel = Level.GetLevel(level);
					}
					catch (Exception)
					{
					}
				}
			}
			if (Logger.globalLevel == null)
			{
				Logger.globalLevel = Level.OFF;
				if (text != null)
				{
					Console.Out.WriteLine(string.Concat(new string[]
					{
						"WARN: '",
						Logger.LEVEL_PARAM,
						"' configuration property invalid. Unable to parse '",
						text,
						"' - logging switched off"
					}));
				}
			}
		}

		public void LogObject(Level level, string prefix, object obj)
		{
			if (this.IsEnabledFor(level))
			{
				if (obj == null)
				{
					this.Log(level, prefix + "(null)", null);
				}
				obj.GetType();
				bool flag = true;
				PropertyInfo[] properties = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				PropertyInfo[] array = properties;
				for (int i = 0; i < array.Length; i++)
				{
					PropertyInfo p = array[i];
					if (this.RequiresLongFormat(p, obj))
					{
						flag = false;
						break;
					}
				}
				StringBuilder stringBuilder = new StringBuilder();
				PropertyInfo[] array2 = properties;
				for (int j = 0; j < array2.Length; j++)
				{
					PropertyInfo propertyInfo = array2[j];
					object value = propertyInfo.GetValue(obj, null);
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(flag ? ", " : "\n  ");
					}
					stringBuilder.Append(propertyInfo.Name).Append("=");
					this.DumpValue(value, stringBuilder, "    ");
				}
				this.Log(level, prefix + stringBuilder, null);
			}
		}

		private ArrayList GetAllProperties(Type t)
		{
			ArrayList arrayList = new ArrayList();
			while (t != typeof(object))
			{
				arrayList.AddRange(t.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public));
				t = t.BaseType;
			}
			return arrayList;
		}

		private bool RequiresLongFormat(PropertyInfo p, object obj)
		{
			object value = p.GetValue(obj, null);
			if (value == null || value is string || value.GetType().IsPrimitive)
			{
				return false;
			}
			if (value.GetType().IsArray && value.GetType().GetElementType().IsPrimitive)
			{
				return ((Array)value).Length > 16;
			}
			if (value is StringDictionary)
			{
				return ((StringDictionary)value).Count > 1;
			}
			if (value is ICollection)
			{
				return ((ICollection)value).Count > 1;
			}
			return typeof(IEnumerable).IsAssignableFrom(p.PropertyType);
		}

		private void DumpValue(object value, StringBuilder valueStr, string indent)
		{
			if (value == null)
			{
				valueStr.Append("(null)");
				return;
			}
			if (value.GetType().IsArray && value.GetType().GetElementType().IsPrimitive)
			{
				int num = 0;
				Array array = (Array)value;
				if (array.Length > 16)
				{
					valueStr.Append("(").Append(array.Length).Append(" items)").Append("\n").Append(indent).Append("  ");
				}
				IEnumerator enumerator = array.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object current = enumerator.Current;
						if (current is byte)
						{
							valueStr.Append(((byte)current).ToString("X2"));
						}
						else
						{
							valueStr.Append(current);
						}
						num++;
						if (num % 16 != 0)
						{
							valueStr.Append(" ");
						}
						else
						{
							valueStr.Append("\n").Append(indent).Append("  ");
						}
					}
					return;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			if (value is IDictionary)
			{
				IDictionary dictionary = (IDictionary)value;
				bool flag = dictionary.Count > 1;
				if (flag)
				{
					valueStr.Append("(").Append(dictionary.Count).Append(" items)");
				}
				IEnumerator enumerator2 = dictionary.Keys.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object current2 = enumerator2.Current;
						if (flag)
						{
							valueStr.Append("\n").Append(indent);
						}
						valueStr.Append(current2).Append("=");
						this.DumpValue(dictionary[current2], valueStr, indent + "  ");
					}
					return;
				}
				finally
				{
					IDisposable disposable2 = enumerator2 as IDisposable;
					if (disposable2 != null)
					{
						disposable2.Dispose();
					}
				}
			}
			if (value is StringDictionary)
			{
				StringDictionary stringDictionary = (StringDictionary)value;
				bool flag2 = stringDictionary.Count > 1;
				if (flag2)
				{
					valueStr.Append("(").Append(stringDictionary.Count).Append(" items)");
				}
				IEnumerator enumerator3 = stringDictionary.Keys.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						string text = (string)enumerator3.Current;
						if (flag2)
						{
							valueStr.Append("\n").Append(indent);
						}
						valueStr.Append(text).Append("=");
						this.DumpValue(stringDictionary[text], valueStr, indent + "  ");
					}
					return;
				}
				finally
				{
					IDisposable disposable3 = enumerator3 as IDisposable;
					if (disposable3 != null)
					{
						disposable3.Dispose();
					}
				}
			}
			if (!(value is string) && value is IEnumerable)
			{
				bool flag3 = true;
				if (value is ICollection)
				{
					ICollection collection = (ICollection)value;
					flag3 = (collection.Count > 1);
					if (flag3)
					{
						valueStr.Append("(").Append(collection.Count).Append(" items)");
					}
				}
				IEnumerator enumerator4 = ((IEnumerable)value).GetEnumerator();
				try
				{
					while (enumerator4.MoveNext())
					{
						object current3 = enumerator4.Current;
						if (flag3)
						{
							valueStr.Append("\n").Append(indent);
						}
						this.DumpValue(current3, valueStr, indent + "  ");
					}
					return;
				}
				finally
				{
					IDisposable disposable4 = enumerator4 as IDisposable;
					if (disposable4 != null)
					{
						disposable4.Dispose();
					}
				}
			}
			valueStr.Append(value.ToString());
		}
	}
}
