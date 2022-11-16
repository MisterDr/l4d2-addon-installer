using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class InstallStep_CreatePaths : iInstallStep
	{
		private bool _c;

		private bool _e;

		private iInstallStep.StepCompleteEventHandler StepCompleteEvent;

		private iInstallStep.StepErrorEventHandler StepErrorEvent;

		private iInstallStep.StepMessageEventHandler StepMessageEvent;

		private iInstallStep.StepProgressEventHandler StepProgressEvent;

		private iInstallStep.StepStartedEventHandler StepStartedEvent;

		public bool IsComplete => _c;

		public bool HasError => _e;

		public string StepName => "Create Temp and Download Directories";

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

		public InstallStep_CreatePaths()
		{
			_c = false;
			_e = false;
		}

		public void Start()
		{
			try
			{
				StepStartedEvent?.Invoke();
				Directory.CreateDirectory(AOIPaths.TempDataPath());
				StepMessageEvent?.Invoke("Temp Path: " + AOIPaths.TempDataPath());
				Directory.CreateDirectory(AOIPaths.DownloadsPath());
				StepMessageEvent?.Invoke("DL Path: " + AOIPaths.DownloadsPath());
				_c = true;
				StepCompleteEvent?.Invoke();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				_e = true;
				StepErrorEvent?.Invoke(ex2.ToString());
				ProjectData.ClearProjectError();
			}
		}

		void iInstallStep.Start()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Start
			this.Start();
		}

		public void Stop()
		{
		}

		void iInstallStep.Stop()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Stop
			this.Stop();
		}
	}
}
