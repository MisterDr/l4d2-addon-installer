using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using AOICL.Downloads.Clients;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class InstallStep_Download : iInstallStep
	{
		[AccessedThroughProperty("FileDownloader")]
		private DownloadClient_SystemNewWebClient _FileDownloader;

		private bool abortwhatyouaredoing;

		public Uri j;

		private string AOIDownloadPath;

		private bool _f;

		private iInstallStep.StepCompleteEventHandler StepCompleteEvent;

		private iInstallStep.StepErrorEventHandler StepErrorEvent;

		private iInstallStep.StepMessageEventHandler StepMessageEvent;

		private iInstallStep.StepProgressEventHandler StepProgressEvent;

		private iInstallStep.StepStartedEventHandler StepStartedEvent;

		private bool _e;

		DownloadClient_SystemNewWebClient FileDownloader
		{
			[DebuggerNonUserCode]
			get
			{
				return _FileDownloader;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				DownloadClient_SystemNewWebClient.DownloadClientProgressEventHandler obj = FileDownloader_DownloadClientProgress;
				DownloadClient_SystemNewWebClient.DownloadClientMessageEventHandler obj2 = FileDownloader_DownloadClientMessage;
				DownloadClient_SystemNewWebClient.DownloadClientErrorEventHandler obj3 = FileDownloader_DownloadClientError;
				DownloadClient_SystemNewWebClient.DownloadClientCompleteEventHandler obj4 = FileDownloader_DownloadClientComplete;
				if (_FileDownloader != null)
				{
					_FileDownloader.DownloadClientProgress -= obj;
					_FileDownloader.DownloadClientMessage -= obj2;
					_FileDownloader.DownloadClientError -= obj3;
					_FileDownloader.DownloadClientComplete -= obj4;
				}
				_FileDownloader = value;
				if (_FileDownloader != null)
				{
					_FileDownloader.DownloadClientProgress += obj;
					_FileDownloader.DownloadClientMessage += obj2;
					_FileDownloader.DownloadClientError += obj3;
					_FileDownloader.DownloadClientComplete += obj4;
				}
			}
		}

		public bool HasError
		{
			get
			{
				if (_e)
				{
					return _e;
				}
				if (FileDownloader != null && (FileDownloader.HasError | FileDownloader.TimeOut | !FileDownloader.IsBusy))
				{
					return !FileDownloader.DownloadOK;
				}
				bool result = default(bool);
				return result;
			}
		}

		public bool IsComplete => !FileDownloader.IsBusy;

		public string StepName => "Add-On Downloader (Old Version)";

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

		public InstallStep_Download(Uri URL, string path)
		{
			abortwhatyouaredoing = false;
			_f = false;
			_e = false;
			j = URL;
			AOIDownloadPath = path;
		}

		public void Start()
		{
			try
			{
				StepStartedEvent?.Invoke();
				FileDownloader = new DownloadClient_SystemNewWebClient(j, Path.Combine(AOIDownloadPath, Strings.Split(j.AbsolutePath, "/").Last()));
				FileDownloader.BeginDownload();
				while (KeepLooping())
				{
					if (abortwhatyouaredoing)
					{
						FileDownloader.CancelDownload();
						_f = true;
						return;
					}
				}
				_f = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StepErrorEvent?.Invoke("Downloading Error");
				ProjectData.ClearProjectError();
			}
		}

		void iInstallStep.Start()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Start
			this.Start();
		}

		private bool KeepLooping()
		{
			if (FileDownloader == null)
			{
				return false;
			}
			if (FileDownloader.IsBusy)
			{
				return true;
			}
			return false;
		}

		public void Stop()
		{
			if (FileDownloader != null)
			{
				FileDownloader.CancelDownload();
			}
			_e = true;
			_f = true;
			StepErrorEvent?.Invoke("Download canceled by the user");
		}

		void iInstallStep.Stop()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Stop
			this.Stop();
		}

		private void FileDownloader_DownloadClientComplete()
		{
			_f = true;
			if (!FileDownloader.DownloadOK)
			{
				_e = true;
				StepErrorEvent?.Invoke("There was an error downloading the file, install cannot continue 333");
			}
			else
			{
				StepCompleteEvent?.Invoke();
			}
		}

		private void FileDownloader_DownloadClientError(string EM)
		{
			_e = true;
			_f = true;
			if ((FileDownloader.HasError | FileDownloader.WasCanceled | FileDownloader.TimeOut) & !FileDownloader.HadDownloadFinished)
			{
				_e = true;
				FileDownloader = null;
				StepErrorEvent?.Invoke(EM);
			}
		}

		private void FileDownloader_DownloadClientMessage(string m)
		{
			StepMessageEvent?.Invoke(m);
		}

		private void FileDownloader_DownloadClientProgress(long dl, long ts)
		{
			if (!abortwhatyouaredoing)
			{
				DownloadProgress downloadProgress = new DownloadProgress();
				downloadProgress.bi = dl;
				downloadProgress.tb = ts;
				downloadProgress.p = (double)dl / (double)ts * 100.0;
				StepProgressEvent?.Invoke(checked((int)Math.Round(downloadProgress.p)), downloadProgress);
			}
		}
	}
}
