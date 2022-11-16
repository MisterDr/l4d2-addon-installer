using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	[Serializable]
	public class AddOnFeedManager
	{
		public delegate void CacheErrorEventHandler(Exception e);

		public delegate void CacheStartedEventHandler();

		public delegate void CacheCompleteEventHandler();

		public List<AddOnFeed> Feeds;

		private CacheErrorEventHandler CacheErrorEvent;

		private CacheStartedEventHandler CacheStartedEvent;

		private CacheCompleteEventHandler CacheCompleteEvent;

		public IEnumerable<AddOn> GetAddOns
		{
			get
			{
				lock (this)
				{
					CAddOns addOns = new CAddOns();
					foreach (AddOnFeed feed in Feeds)
					{
						foreach (AddOn getAddOn in feed.GetAddOns)
						{
							addOns.AddAddon(getAddOn);
						}
					}
					return addOns.AddOns.ToList();
				}
			}
		}

		public event CacheErrorEventHandler CacheError
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				CacheErrorEvent = (CacheErrorEventHandler)Delegate.Combine(CacheErrorEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				CacheErrorEvent = (CacheErrorEventHandler)Delegate.Remove(CacheErrorEvent, value);
			}
		}

		public event CacheStartedEventHandler CacheStarted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				CacheStartedEvent = (CacheStartedEventHandler)Delegate.Combine(CacheStartedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				CacheStartedEvent = (CacheStartedEventHandler)Delegate.Remove(CacheStartedEvent, value);
			}
		}

		public event CacheCompleteEventHandler CacheComplete
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				CacheCompleteEvent = (CacheCompleteEventHandler)Delegate.Combine(CacheCompleteEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				CacheCompleteEvent = (CacheCompleteEventHandler)Delegate.Remove(CacheCompleteEvent, value);
			}
		}

		public AddOnFeedManager()
		{
			Feeds = new List<AddOnFeed>();
		}

		public void Load(string Path)
		{
			lock (this)
			{
				try
				{
					Feeds.Clear();
					List<AddOnFeed> list = new List<AddOnFeed>();
					Stream stream = File.OpenRead(Path);
					XmlSerializer xmlSerializer = new XmlSerializer(list.GetType());
					list = (List<AddOnFeed>)xmlSerializer.Deserialize(stream);
					foreach (AddOnFeed item in list)
					{
						Feeds.Add(item);
					}
					stream.Close();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		public void Save(string Path)
		{
			try
			{
				StreamWriter streamWriter = new StreamWriter(Path);
				XmlSerializer xmlSerializer = new XmlSerializer(Feeds.GetType());
				xmlSerializer.Serialize(streamWriter, Feeds);
				streamWriter.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		public void Cache()
		{
			lock (this)
			{
				CacheStartedEvent?.Invoke();
				CAddOns addOns = new CAddOns();
				foreach (AddOnFeed feed in Feeds)
				{
					feed.Cache();
				}
				CacheCompleteEvent?.Invoke();
			}
		}
	}
}
