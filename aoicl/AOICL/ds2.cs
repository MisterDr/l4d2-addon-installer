using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Timers;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class ds2 : iInstallStep
	{
		private WebClient wc;

		public Uri j;

		private string AOIDownloadPath;

		private bool _HasError;

		private bool _IsComplete;

		[AccessedThroughProperty("RetryTimer")]
		private Timer _RetryTimer;

		private DateTime TimeStarted;

		private int RetryInterval;

		private int RetryMax;

		private int RetryCount;

		private iInstallStep.StepCompleteEventHandler StepCompleteEvent;

		private iInstallStep.StepErrorEventHandler StepErrorEvent;

		private iInstallStep.StepMessageEventHandler StepMessageEvent;

		private iInstallStep.StepProgressEventHandler StepProgressEvent;

		private iInstallStep.StepStartedEventHandler StepStartedEvent;

		private bool _wasc;

		Timer RetryTimer
		{
			[DebuggerNonUserCode]
			get
			{
				return _RetryTimer;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				ElapsedEventHandler value2 = RetryTimer_Elapsed;
				if (_RetryTimer != null)
				{
					_RetryTimer.Elapsed -= value2;
				}
				_RetryTimer = value;
				if (_RetryTimer != null)
				{
					_RetryTimer.Elapsed += value2;
				}
			}
		}

		public bool HasError => _HasError;

		public bool IsComplete
		{
			get
			{
				if (_HasError)
				{
					return true;
				}
				return _IsComplete;
			}
		}

		public string StepName => "Add-On Downloader (New Version ds2)";

		public event iInstallStep.StepCompleteEventHandler StepComplete
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				StepCompleteEvent = (iInstallStep.StepCompleteEventHandler)Delegate.Combine(StepCompleteEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				StepCompleteEvent = (iInstallStep.StepCompleteEventHandler)Delegate.Remove(StepCompleteEvent, value);
			}
		}

		public event iInstallStep.StepErrorEventHandler StepError
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				StepErrorEvent = (iInstallStep.StepErrorEventHandler)Delegate.Combine(StepErrorEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				StepErrorEvent = (iInstallStep.StepErrorEventHandler)Delegate.Remove(StepErrorEvent, value);
			}
		}

		public event iInstallStep.StepMessageEventHandler StepMessage
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				StepMessageEvent = (iInstallStep.StepMessageEventHandler)Delegate.Combine(StepMessageEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				StepMessageEvent = (iInstallStep.StepMessageEventHandler)Delegate.Remove(StepMessageEvent, value);
			}
		}

		public event iInstallStep.StepProgressEventHandler StepProgress
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				StepProgressEvent = (iInstallStep.StepProgressEventHandler)Delegate.Combine(StepProgressEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				StepProgressEvent = (iInstallStep.StepProgressEventHandler)Delegate.Remove(StepProgressEvent, value);
			}
		}

		public event iInstallStep.StepStartedEventHandler StepStarted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				StepStartedEvent = (iInstallStep.StepStartedEventHandler)Delegate.Combine(StepStartedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				StepStartedEvent = (iInstallStep.StepStartedEventHandler)Delegate.Remove(StepStartedEvent, value);
			}
		}

		public ds2(Uri URL, string path)
		{
			wc = null;
			_HasError = false;
			_IsComplete = false;
			RetryTimer = null;
			TimeStarted = default(DateTime);
			RetryInterval = 5000;
			RetryMax = 6;
			RetryCount = 0;
			_wasc = false;
			j = URL;
			AOIDownloadPath = path;
		}

		public void client_ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			RetryTimer.Enabled = false;
			RetryTimer.Enabled = true;
			RetryCount = 0;
			DownloadProgress2 downloadProgress = new DownloadProgress2();
			downloadProgress.bi = e.BytesReceived;
			downloadProgress.tb = e.TotalBytesToReceive;
			downloadProgress.p = downloadProgress.bi / downloadProgress.tb * 100.0;
			downloadProgress.DownloadStarted = TimeStarted;
			StepProgressEvent?.Invoke(checked((int)Math.Round(downloadProgress.p)), downloadProgress);
			StepProgressEvent?.Invoke(e.ProgressPercentage, downloadProgress);
		}

		public void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			if (e.Cancelled | (e.Error != null))
			{
				StepErrorEvent?.Invoke("There was an error downloading the file, install cannot continue: " + e.Error.ToString());
				_HasError = true;
			}
			CloseHandles();
			_IsComplete = true;
			StepCompleteEvent?.Invoke();
		}

		public void Start()
		{
			StepStartedEvent?.Invoke();
			wc = new WebClient();
			ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
			ServicePointManager.DefaultConnectionLimit = 9999;
			ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
			wc.DownloadFileCompleted += client_DownloadFileCompleted;
			wc.DownloadProgressChanged += client_ProgressChanged;
			TimeStarted = DateAndTime.Now;
			wc.DownloadFileAsync(j, AOIDownloadPath);
			RetryTimer = new Timer();
			RetryTimer.Interval = RetryInterval;
			RetryTimer.Enabled = true;
		}

        void iInstallStep.Start()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Start
			this.Start();
		}

		public void Stop()
		{
			StepErrorEvent?.Invoke("Download canceled by the user");
			_wasc = true;
			CloseHandles();
		}

		void iInstallStep.Stop()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Stop
			this.Stop();
		}

		private void CloseHandles()
		{
			if (RetryTimer != null)
			{
				RetryTimer.Enabled = false;
				RetryTimer = null;
			}
			if (wc != null)
			{
				wc.DownloadFileCompleted -= client_DownloadFileCompleted;
				wc.DownloadProgressChanged -= client_ProgressChanged;
				wc.CancelAsync();
				while (wc.IsBusy)
				{
				}
			}
			try
			{
				if ((_HasError | _wasc) && File.Exists(AOIDownloadPath))
				{
					File.Delete(AOIDownloadPath);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			if (wc != null)
			{
				wc = null;
			}
		}

		private void RetryTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			checked
			{
				RetryCount++;
				if (RetryCount > RetryMax)
				{
					StepErrorEvent?.Invoke("Downloading Timeout Error");
					CloseHandles();
				}
				else
				{
					StepMessageEvent?.Invoke("Timeout! Retry " + Conversions.ToString(RetryCount) + " of " + Conversions.ToString(RetryMax));
				}
			}
		}
	}
}
