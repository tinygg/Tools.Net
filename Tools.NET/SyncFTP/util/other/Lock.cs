using System;
using System.Threading;

namespace EnterpriseDT.Util.Debug
{
	public class Lock : IDisposable
	{
		private object syncObject;

		public Lock(object syncObject)
		{
			this.syncObject = syncObject;
			Monitor.Enter(syncObject);
		}

		public void Dispose()
		{
			Monitor.Exit(this.syncObject);
		}
	}
}
