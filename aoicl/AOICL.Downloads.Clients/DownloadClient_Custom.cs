using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL.Downloads.Clients
{
	public class DownloadClient_Custom
	{
		private delegate void UpdateProgressCallback(long BytesRead, long TotalBytes);

		public delegate void DownloadProgressChangedEventHandler(long BytesRead, long TotalBytes);

		public delegate void DownloadStartedEventHandler();

		public delegate void DownloadCompleteEventHandler();

		public delegate void DownloadPausedEventHandler();

		public delegate void DownloadResumedEventHandler();

		public delegate void DownloadErrorEventHandler();

		private Thread thrDownload;

		private Stream strResponse;

		private Stream strLocal;

		private HttpWebRequest webRequest;

		private HttpWebResponse webResponse;

		private int PercentProgress;

		private DownloadProgressChangedEventHandler DownloadProgressChangedEvent;

		private DownloadStartedEventHandler DownloadStartedEvent;

		private DownloadCompleteEventHandler DownloadCompleteEvent;

		private DownloadPausedEventHandler DownloadPausedEvent;

		private DownloadResumedEventHandler DownloadResumedEvent;

		private DownloadErrorEventHandler DownloadErrorEvent;

		private bool goPause;

		private AOIDownloadStatus dls;

		private string _url;

		private string _local;

		public bool _haserror;

		public Exception _lasterror;

		public object IsBusy
		{
			get
			{
				if (thrDownload == null)
				{
					return false;
				}
				if (thrDownload.ThreadState == System.Threading.ThreadState.Running)
				{
					return true;
				}
				return false;
			}
		}

		public event DownloadProgressChangedEventHandler DownloadProgressChanged
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DownloadProgressChangedEvent = (DownloadProgressChangedEventHandler)Delegate.Combine(DownloadProgressChangedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DownloadProgressChangedEvent = (DownloadProgressChangedEventHandler)Delegate.Remove(DownloadProgressChangedEvent, value);
			}
		}

		public event DownloadStartedEventHandler DownloadStarted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DownloadStartedEvent = (DownloadStartedEventHandler)Delegate.Combine(DownloadStartedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DownloadStartedEvent = (DownloadStartedEventHandler)Delegate.Remove(DownloadStartedEvent, value);
			}
		}

		public event DownloadCompleteEventHandler DownloadComplete
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DownloadCompleteEvent = (DownloadCompleteEventHandler)Delegate.Combine(DownloadCompleteEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DownloadCompleteEvent = (DownloadCompleteEventHandler)Delegate.Remove(DownloadCompleteEvent, value);
			}
		}

		public event DownloadPausedEventHandler DownloadPaused
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DownloadPausedEvent = (DownloadPausedEventHandler)Delegate.Combine(DownloadPausedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DownloadPausedEvent = (DownloadPausedEventHandler)Delegate.Remove(DownloadPausedEvent, value);
			}
		}

		public event DownloadResumedEventHandler DownloadResumed
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DownloadResumedEvent = (DownloadResumedEventHandler)Delegate.Combine(DownloadResumedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DownloadResumedEvent = (DownloadResumedEventHandler)Delegate.Remove(DownloadResumedEvent, value);
			}
		}

		public event DownloadErrorEventHandler DownloadError
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DownloadErrorEvent = (DownloadErrorEventHandler)Delegate.Combine(DownloadErrorEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DownloadErrorEvent = (DownloadErrorEventHandler)Delegate.Remove(DownloadErrorEvent, value);
			}
		}

		public DownloadClient_Custom(string URL, string savepath)
		{
			goPause = false;
			dls = AOIDownloadStatus.Ready;
			_haserror = false;
			_lasterror = null;
			_url = URL;
			_local = savepath;
		}

		public void Start()
		{
			if (thrDownload == null)
			{
				thrDownload = new Thread(Download);
				thrDownload.Start(0);
				dls = AOIDownloadStatus.Downloading;
			}
			else if (thrDownload.ThreadState == System.Threading.ThreadState.Running)
			{
				Interaction.MsgBox("Download already running");
			}
			else
			{
				thrDownload = new Thread(Download);
				thrDownload.Start(0);
				dls = AOIDownloadStatus.Downloading;
			}
		}

		private void Download(object startPoint)
		{
			DownloadStartedEvent?.Invoke();
			_haserror = false;
			_lasterror = null;
			try
			{
				int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(startPoint));
				webRequest = (HttpWebRequest)WebRequest.Create(_url);
				webRequest.AddRange(num);
				webRequest.Credentials = CredentialCache.DefaultCredentials;
				webResponse = (HttpWebResponse)webRequest.GetResponse();
				long contentLength = webResponse.ContentLength;
				if (Operators.ConditionalCompareObjectEqual(startPoint, 0, TextCompare: false))
				{
					strLocal = new FileStream(_local, FileMode.Create, FileAccess.Write, FileShare.None);
				}
				else
				{
					strLocal = new FileStream(_local, FileMode.Append, FileAccess.Write, FileShare.None);
				}
				strResponse = webResponse.GetResponseStream();
				int num2 = 0;
				byte[] array = new byte[4097];
				for (num2 = strResponse.Read(array, 0, array.Length); num2 > 0; num2 = strResponse.Read(array, 0, array.Length))
				{
					strLocal.Write(array, 0, num2);
					DownloadProgressChangedEvent?.Invoke(strLocal.Length, checked(contentLength + num));
					if (goPause)
					{
						dls = AOIDownloadStatus.Paused;
						break;
					}
				}
				_ = goPause;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception lasterror = ex;
				dls = AOIDownloadStatus.Error;
				_haserror = true;
				_lasterror = lasterror;
				ProjectData.ClearProjectError();
			}
			finally
			{
				strResponse.Close();
				strLocal.Close();
				DownloadCompleteEvent?.Invoke();
			}
		}

		public void Stop()
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}
	}
}
