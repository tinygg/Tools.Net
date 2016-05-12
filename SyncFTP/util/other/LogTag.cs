using System;
using System.Collections.Generic;

namespace EnterpriseDT.Util.Debug
{
	public class LogTag : ILogTag
	{
		private static object instanceCounterLock = new object();

		private static Dictionary<string, int> instanceCounters = new Dictionary<string, int>();

		private int instanceNumber;

		private string prefix;

		public int Id
		{
			get
			{
				return this.instanceNumber;
			}
		}

		public virtual string Name
		{
			get
			{
				return this.prefix + "." + this.instanceNumber;
			}
		}

		public LogTag(string prefix)
		{
			lock (LogTag.instanceCounterLock)
			{
				if (LogTag.instanceCounters.TryGetValue(prefix, out this.instanceNumber))
				{
					this.instanceNumber++;
				}
				else
				{
					this.instanceNumber = 1;
				}
				LogTag.instanceCounters[prefix] = this.instanceNumber;
			}
			this.prefix = prefix;
		}

		public string GetLogTag()
		{
			return this.Name;
		}
	}
}
