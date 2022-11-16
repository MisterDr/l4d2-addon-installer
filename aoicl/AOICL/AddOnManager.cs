using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using AOICL.Functions.Left4Dead2;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class AddOnManager
	{
		public delegate void AddOnListChangedEventHandler();

		public delegate void NewAddOnDetectedEventHandler(string name);

		public delegate void FeedCacheStartedEventHandler();

		public delegate void FeedCacheCompleteEventHandler();

		[AccessedThroughProperty("AddOnList")]
		private CAddOns _AddOnList;

		[AccessedThroughProperty("AddonFolderScanner")]
		private FileSystemWatcher _AddonFolderScanner;

		[AccessedThroughProperty("AddOnFeedManager")]
		private AddOnFeedManager _AddOnFeedManager;

		private int AddOnFeedScanInterval;

		[AccessedThroughProperty("feedTimer")]
		private System.Timers.Timer _feedTimer;

		private AddOnListChangedEventHandler AddOnListChangedEvent;

		private NewAddOnDetectedEventHandler NewAddOnDetectedEvent;

		private string s;

		[AccessedThroughProperty("t")]
		private System.Timers.Timer _t;

		private bool h;

		private FeedCacheStartedEventHandler FeedCacheStartedEvent;

		private FeedCacheCompleteEventHandler FeedCacheCompleteEvent;

		public virtual CAddOns AddOnList
		{
			[DebuggerNonUserCode]
			get
			{
				return _AddOnList;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				CAddOns.ListChangedEventHandler obj = AddOnList_ListChanged;
				if (_AddOnList != null)
				{
					_AddOnList.ListChanged -= obj;
				}
				_AddOnList = value;
				if (_AddOnList != null)
				{
					_AddOnList.ListChanged += obj;
				}
			}
		}

		FileSystemWatcher AddonFolderScanner
		{
			[DebuggerNonUserCode]
			get
			{
				return _AddonFolderScanner;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				FileSystemEventHandler value2 = AddonFolderScanner_Created;
				if (_AddonFolderScanner != null)
				{
					_AddonFolderScanner.Created -= value2;
				}
				_AddonFolderScanner = value;
				if (_AddonFolderScanner != null)
				{
					_AddonFolderScanner.Created += value2;
				}
			}
		}

		public virtual AddOnFeedManager AddOnFeedManager
		{
			[DebuggerNonUserCode]
			get
			{
				return _AddOnFeedManager;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_AddOnFeedManager = value;
			}
		}

		System.Timers.Timer feedTimer
		{
			[DebuggerNonUserCode]
			get
			{
				return _feedTimer;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				ElapsedEventHandler value2 = feedTimer_Elapsed;
				if (_feedTimer != null)
				{
					_feedTimer.Elapsed -= value2;
				}
				_feedTimer = value;
				if (_feedTimer != null)
				{
					_feedTimer.Elapsed += value2;
				}
			}
		}

		System.Timers.Timer t
		{
			[DebuggerNonUserCode]
			get
			{
				return _t;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				ElapsedEventHandler value2 = t_Elapsed;
				if (_t != null)
				{
					_t.Elapsed -= value2;
				}
				_t = value;
				if (_t != null)
				{
					_t.Elapsed += value2;
				}
			}
		}

		public event AddOnListChangedEventHandler AddOnListChanged
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				AddOnListChangedEvent = (AddOnListChangedEventHandler)Delegate.Combine(AddOnListChangedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				AddOnListChangedEvent = (AddOnListChangedEventHandler)Delegate.Remove(AddOnListChangedEvent, value);
			}
		}

		public event NewAddOnDetectedEventHandler NewAddOnDetected
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				NewAddOnDetectedEvent = (NewAddOnDetectedEventHandler)Delegate.Combine(NewAddOnDetectedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				NewAddOnDetectedEvent = (NewAddOnDetectedEventHandler)Delegate.Remove(NewAddOnDetectedEvent, value);
			}
		}

		public event FeedCacheStartedEventHandler FeedCacheStarted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				FeedCacheStartedEvent = (FeedCacheStartedEventHandler)Delegate.Combine(FeedCacheStartedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				FeedCacheStartedEvent = (FeedCacheStartedEventHandler)Delegate.Remove(FeedCacheStartedEvent, value);
			}
		}

		public event FeedCacheCompleteEventHandler FeedCacheComplete
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				FeedCacheCompleteEvent = (FeedCacheCompleteEventHandler)Delegate.Combine(FeedCacheCompleteEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				FeedCacheCompleteEvent = (FeedCacheCompleteEventHandler)Delegate.Remove(FeedCacheCompleteEvent, value);
			}
		}

		public AddOnManager()
		{
			AddOnList = new CAddOns();
			AddOnFeedManager = new AddOnFeedManager();
			AddOnFeedScanInterval = 1800000;
			feedTimer = new System.Timers.Timer();
			h = false;
			feedTimer.Interval = 1800000.0;
			feedTimer.Enabled = true;
		}

		private void AddOnList_ListChanged()
		{
			AddOnListChangedEvent?.Invoke();
		}

		public void StartWatchingAddOnFolder(string path)
		{
			try
			{
				AddonFolderScanner = new FileSystemWatcher(path, "*.vpk");
				AddonFolderScanner.EnableRaisingEvents = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void AddonFolderScanner_Created(object sender, FileSystemEventArgs e)
		{
			if (!h)
			{
				s = e.FullPath;
				t = new System.Timers.Timer();
				t.Interval = 1000.0;
				t.Enabled = true;
				h = true;
			}
		}

		private void t_Elapsed(object sender, ElapsedEventArgs e)
		{
			bool flag = false;
			try
			{
				Stream stream = File.OpenRead(s);
				stream.Close();
				flag = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				flag = false;
				ProjectData.ClearProjectError();
			}
			if (h && flag)
			{
				t.Enabled = false;
				h = false;
				AddOnInfo addOnInfo = (AddOnInfo)Left4Dead2Functions.AddOnInfoFromVPK(s);
				AddOnList.AddAddon(AddOn.CreateAddOnFromAddOnInfo(addOnInfo));
				NewAddOnDetectedEvent?.Invoke(addOnInfo.Title);
				AddOnListChangedEvent?.Invoke();
			}
		}

		public void FTCT()
		{
			Thread thread = new Thread(FTC);
			thread.Start();
			while (thread.IsAlive)
			{
				Thread.Sleep(100);
			}
			thread = null;
		}

		private void feedTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			FTC();
		}

		public void FTC()
		{
			//Discarded unreachable code: IL_007d
			FeedCacheStartedEvent?.Invoke();
			try
			{
				AddOnFeedManager.Load(Path.Combine(AOIPaths.FeedsPath(), "Feeds.xml"));
				AddOnFeedManager.Cache();
				List<AddOn> list = (List<AddOn>)AddOnFeedManager.GetAddOns;
				foreach (AddOn item in list)
				{
					AddOnList.AddAddon(item);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			FeedCacheCompleteEvent?.Invoke();
		}

		~AddOnManager()
		{
			feedTimer.Enabled = false;
			feedTimer = null;
			// base.Finalize();
		}
	}
}
