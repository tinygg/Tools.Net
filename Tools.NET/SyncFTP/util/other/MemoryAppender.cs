using System;
using System.Collections;
using System.IO;

namespace EnterpriseDT.Util.Debug
{
	public class MemoryAppender : Appender
	{
		public const int DEFAULT_MAX_MESSAGES = 1000;

		private int maxMessages = 1000;

		private ArrayList messages = new ArrayList();

		public int MaxMessages
		{
			get
			{
				return this.maxMessages;
			}
			set
			{
				lock (this.messages.SyncRoot)
				{
					this.maxMessages = value;
				}
			}
		}

		public string[] Messages
		{
			get
			{
				return (string[])this.messages.ToArray(typeof(string));
			}
		}

		public MemoryAppender()
		{
		}

		public MemoryAppender(int maxMessages)
		{
			this.maxMessages = maxMessages;
		}

		public virtual void Log(string msg)
		{
			this.AddMessage(msg);
		}

		public virtual void Log(Exception t)
		{
			this.AddMessage(t.GetType().FullName + ": " + t.Message);
			this.AddMessage(t.StackTrace.ToString());
		}

		private void AddMessage(string msg)
		{
			lock (this.messages.SyncRoot)
			{
				if (this.messages.Count == this.maxMessages)
				{
					this.messages.RemoveAt(0);
				}
				this.messages.Add(msg);
			}
		}

		public virtual void Close()
		{
		}

		public void Write(string path)
		{
			using (StreamWriter streamWriter = File.CreateText(path))
			{
				this.Write(streamWriter);
			}
		}

		public void Write(StreamWriter stream)
		{
			string[] array = this.Messages;
			for (int i = 0; i < array.Length; i++)
			{
				string value = array[i];
				stream.WriteLine(value);
			}
		}
	}
}
