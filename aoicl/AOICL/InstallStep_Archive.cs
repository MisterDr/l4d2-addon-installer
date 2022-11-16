using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using AOICL.Functions.Generic;
using Microsoft.VisualBasic;

namespace AOICL
{
	public class InstallStep_Archive : iInstallStep
	{
		[AccessedThroughProperty("Archive")]
		private Archive _Archive;

		public List<string> fa;

		private bool isf;

		private string tp;

		private string dp;

		private Uri u;

		private string ip;

		private bool il;

		private string fx;

		private bool _c;

		private iInstallStep.StepCompleteEventHandler StepCompleteEvent;

		private iInstallStep.StepErrorEventHandler StepErrorEvent;

		private iInstallStep.StepMessageEventHandler StepMessageEvent;

		private iInstallStep.StepProgressEventHandler StepProgressEvent;

		private iInstallStep.StepStartedEventHandler StepStartedEvent;

		private bool ArchiveExtractError;

		Archive Archive
		{
			[DebuggerNonUserCode]
			get
			{
				return _Archive;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				Archive.ExtractErrorEventHandler obj = Archive_ExtractError;
				Archive.ExtractProgressEventHandler obj2 = Archive_ExtractProgress;
				if (_Archive != null)
				{
					_Archive.ExtractError -= obj;
					_Archive.ExtractProgress -= obj2;
				}
				_Archive = value;
				if (_Archive != null)
				{
					_Archive.ExtractError += obj;
					_Archive.ExtractProgress += obj2;
				}
			}
		}

		public bool HasError => ArchiveExtractError;

		public bool IsComplete => _c;

		public string StepName => "Archive Entrys/Extractor";

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

		public InstallStep_Archive(bool isfolder, string temppath, string downloadpath, Uri j, string installpath, bool ilx, string fxx)
		{
			Archive = null;
			fa = new List<string>();
			isf = false;
			_c = false;
			ArchiveExtractError = false;
			isf = isfolder;
			tp = temppath;
			dp = downloadpath;
			u = j;
			ip = installpath;
			il = ilx;
			fx = fxx;
		}

		public void Start()
		{
			StepStartedEvent?.Invoke();
			FileInfo fileInfo = new FileInfo(Path.Combine(dp, Strings.Split(u.AbsolutePath, "/").Last()));
			if (!isf)
			{
				string text = simplemd5.MD5CalcFile(fileInfo.FullName);
				StepMessageEvent?.Invoke("MD5: " + text);
				if (il)
				{
					Archive = new Archive(fx);
				}
				else
				{
					Archive = new Archive(fileInfo.FullName);
				}
				Archive.Extract(tp);
				fa = Archive.ExtractedFiles;
				Archive = null;
			}
			_c = true;
			StepCompleteEvent?.Invoke();
			if (ArchiveExtractError)
			{
				StepErrorEvent?.Invoke("There was an error extracting the archive, please look at the log");
			}
		}

		void iInstallStep.Start()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Start
			this.Start();
		}

		public void Stop()
		{
			Archive.Cancel();
		}

		void iInstallStep.Stop()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Stop
			this.Stop();
		}

		private void Archive_ExtractError(string Message)
		{
			ArchiveExtractError = true;
			StepErrorEvent?.Invoke(Message);
		}

		private void Archive_ExtractProgress(int i)
		{
			StepProgressEvent?.Invoke(i, null);
		}
	}
}
