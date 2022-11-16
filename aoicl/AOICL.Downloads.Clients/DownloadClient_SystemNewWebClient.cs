using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Timers;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL.Downloads.Clients
{
	public class DownloadClient_SystemNewWebClient
	{
		public delegate void DownloadClientStartedEventHandler();

		public delegate void DownloadClientCompleteEventHandler();

		public delegate void DownloadClientMessageEventHandler(string m);

		public delegate void DownloadClientProgressEventHandler(long dl, long ts);

		public delegate void DownloadClientErrorEventHandler(string EM);

		private DownloadClientStartedEventHandler DownloadClientStartedEvent;

		private DownloadClientCompleteEventHandler DownloadClientCompleteEvent;

		private DownloadClientMessageEventHandler DownloadClientMessageEvent;

		private DownloadClientProgressEventHandler DownloadClientProgressEvent;

		private DownloadClientErrorEventHandler DownloadClientErrorEvent;

		private WebClient wc;

		private bool abortwhatyouaredoing;

		public bool HasError;

		public bool WasCanceled;

		public bool HadDownloadFinished;

		private bool tmro;

		public Uri _source;

		public string _destination;

		[AccessedThroughProperty("T")]
		private Timer _T;

		private int noretrys;

		private int maxretry;

		private bool downloadbegan;

		private bool canceleventfired;

		private bool _DoNotFireEvents;

		public bool TimeOut => tmro;

		public bool IsBusy
		{
			get
			{
				if (HasError | WasCanceled)
				{
					if (wc == null)
					{
						return false;
					}
					return wc.IsBusy;
				}
				if (wc == null)
				{
					return false;
				}
				return HadDownloadFinished;
			}
		}

		public virtual Timer T
		{
			[DebuggerNonUserCode]
			get
			{
				return _T;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				ElapsedEventHandler value2 = T_Elapsed;
				if (_T != null)
				{
					_T.Elapsed -= value2;
				}
				_T = value;
				if (_T != null)
				{
					_T.Elapsed += value2;
				}
			}
		}

		public bool DownloadOK
		{
			get
			{
				bool flag = HasError | WasCanceled;
				bool flag2 = !HadDownloadFinished;
				if (HasError)
				{
					return false;
				}
				if (WasCanceled)
				{
					return false;
				}
				if (HadDownloadFinished)
				{
					return true;
				}
				bool result = default(bool);
				return result;
			}
		}

		public event DownloadClientStartedEventHandler DownloadClientStarted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DownloadClientStartedEvent = (DownloadClientStartedEventHandler)Delegate.Combine(DownloadClientStartedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DownloadClientStartedEvent = (DownloadClientStartedEventHandler)Delegate.Remove(DownloadClientStartedEvent, value);
			}
		}

		public event DownloadClientCompleteEventHandler DownloadClientComplete
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DownloadClientCompleteEvent = (DownloadClientCompleteEventHandler)Delegate.Combine(DownloadClientCompleteEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DownloadClientCompleteEvent = (DownloadClientCompleteEventHandler)Delegate.Remove(DownloadClientCompleteEvent, value);
			}
		}

		public event DownloadClientMessageEventHandler DownloadClientMessage
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DownloadClientMessageEvent = (DownloadClientMessageEventHandler)Delegate.Combine(DownloadClientMessageEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DownloadClientMessageEvent = (DownloadClientMessageEventHandler)Delegate.Remove(DownloadClientMessageEvent, value);
			}
		}

		public event DownloadClientProgressEventHandler DownloadClientProgress
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DownloadClientProgressEvent = (DownloadClientProgressEventHandler)Delegate.Combine(DownloadClientProgressEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DownloadClientProgressEvent = (DownloadClientProgressEventHandler)Delegate.Remove(DownloadClientProgressEvent, value);
			}
		}

		public event DownloadClientErrorEventHandler DownloadClientError
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DownloadClientErrorEvent = (DownloadClientErrorEventHandler)Delegate.Combine(DownloadClientErrorEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DownloadClientErrorEvent = (DownloadClientErrorEventHandler)Delegate.Remove(DownloadClientErrorEvent, value);
			}
		}

		public DownloadClient_SystemNewWebClient(Uri URL, string localfile)
		{
			wc = null;
			abortwhatyouaredoing = false;
			HasError = false;
			WasCanceled = false;
			HadDownloadFinished = false;
			tmro = false;
			T = new Timer();
			noretrys = 0;
			maxretry = 5;
			downloadbegan = false;
			canceleventfired = false;
			_DoNotFireEvents = false;
			_source = URL;
			_destination = localfile;
		}

		public void BeginDownload()
		{
			if (wc != null && IsBusy)
			{
				throw new Exception("WebClient is busy");
			}
			try
			{
				wc = new WebClient();
				wc.DownloadProgressChanged += client_ProgressChanged;
				wc.DownloadFileCompleted += client_DownloadFileCompleted;
				T.Enabled = true;
				T.Interval = 10000.0;
				DownloadClientMessageEvent?.Invoke("URL: " + _source.AbsoluteUri.ToString());
				wc.DownloadFileAsync(_source, _destination);
				while (dlloop())
				{
					if (abortwhatyouaredoing | HasError)
					{
						wc.CancelAsync();
						break;
					}
				}
				if (wc != null)
				{
					wc.Dispose();
				}
				wc = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (abortwhatyouaredoing)
				{
					ProjectData.ClearProjectError();
					return;
				}
				DownloadClientErrorEvent?.Invoke("DL ERROR:" + ex2.ToString());
				HasError = true;
				ProjectData.ClearProjectError();
			}
		}

		private bool dlloop()
		{
			if (wc.IsBusy | !downloadbegan)
			{
				if (TimeOut)
				{
					return false;
				}
				return true;
			}
			return false;
		}

		public void CancelDownload()
		{
			abortwhatyouaredoing = true;
			WasCanceled = true;
			noretrys = 0;
			T.Enabled = false;
			if (canceleventfired)
			{
				return;
			}
			if (!_DoNotFireEvents)
			{
				DownloadClientErrorEvent?.Invoke("Download Canceled");
			}
			canceleventfired = true;
			try
			{
				if (wc != null)
				{
					wc.CancelAsync();
					wc.DownloadFileCompleted -= client_DownloadFileCompleted;
					wc.DownloadProgressChanged -= client_ProgressChanged;
					wc.Dispose();
					wc = null;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		public void client_ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			downloadbegan = true;
			if (!abortwhatyouaredoing)
			{
				double num = double.Parse(e.BytesReceived.ToString());
				double num2 = double.Parse(e.TotalBytesToReceive.ToString());
				double d = num / num2 * 100.0;
				int num3 = int.Parse(Math.Truncate(d).ToString());
				//if (!_DoNotFireEvents)
				//{
				//	= checked(DownloadClientProgressEvent?.Invoke((long)Math.Round(num), (long)Math.Round(num2)));
				//}
				noretrys = 0;
				T.Enabled = false;
				T.Enabled = true;
			}
		}

		public void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			HadDownloadFinished = true;
			if (abortwhatyouaredoing)
			{
				return;
			}
			noretrys = 0;
			T.Enabled = false;
			if (!(e.Cancelled | (e.Error != null)))
			{
				if (!_DoNotFireEvents)
				{
					DownloadClientMessageEvent?.Invoke("Download Complete");
					DownloadClientCompleteEvent?.Invoke();
				}
				_DoNotFireEvents = true;
				_DoNotFireEvents = true;
				return;
			}
			HasError = true;
			if (e.Cancelled)
			{
				WasCanceled = true;
				if (!_DoNotFireEvents)
				{
					DownloadClientErrorEvent?.Invoke("Download Cancelled by user");
					return;
				}
			}
			else if (e.Error != null)
			{
				HasError = true;
				if (!_DoNotFireEvents)
				{
					DownloadClientErrorEvent?.Invoke(e.Error.ToString());
					return;
				}
			}
			else if (TimeOut)
			{
				DownloadClientErrorEvent?.Invoke("Time Out");
			}
			else
			{
				HasError = true;
				if (!_DoNotFireEvents)
				{
					DownloadClientErrorEvent?.Invoke("Unknown Download Error");
					return;
				}
			}
			try
			{
				File.Delete(_destination);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		~DownloadClient_SystemNewWebClient()
		{
			try
			{
				_DoNotFireEvents = true;
				if (wc != null)
				{
					wc.CancelAsync();
					wc.Dispose();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			// base.Finalize();
		}

		private void T_Elapsed(object sender, ElapsedEventArgs e)
		{
			checked
			{
				noretrys++;
				if (noretrys >= maxretry)
				{
					tmro = true;
					if (T != null)
					{
						T.Enabled = false;
						T = null;
					}
					DownloadClientErrorEvent?.Invoke("Max Download Retrys Hit! File cannot be downloaded");
				}
				else
				{
					DownloadClientMessageEvent?.Invoke("Dl site error. Retrying: " + Conversions.ToString(noretrys) + " of " + Conversions.ToString(maxretry));
				}
			}
		}
	}
}
