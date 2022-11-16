using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class InstallStep_InstallGenerator : iInstallStep
	{
		[AccessedThroughProperty("AOIInstallGenerator")]
		private InstallGenerator2 _AOIInstallGenerator;

		private List<string> i;

		private bool _c;

		private bool isf;

		private string tp;

		private string dp;

		private Uri u;

		private string ip;

		private bool raw;

		private iInstallStep.StepCompleteEventHandler StepCompleteEvent;

		private iInstallStep.StepErrorEventHandler StepErrorEvent;

		private iInstallStep.StepMessageEventHandler StepMessageEvent;

		private iInstallStep.StepProgressEventHandler StepProgressEvent;

		private iInstallStep.StepStartedEventHandler StepStartedEvent;

		private bool _e;

		private bool throwex;

		InstallGenerator2 AOIInstallGenerator
		{
			[DebuggerNonUserCode]
			get
			{
				return _AOIInstallGenerator;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				InstallGenerator2.GenerateActionListStartEventHandler obj = AOIInstallGenerator_GenerateActionListStart;
				InstallGenerator2.GenerateActionListErrorEventHandler obj2 = AOIInstallGenerator_GenerateActionListError;
				InstallGenerator2.GenerateActionListEndEventHandler obj3 = AOIInstallGenerator_GenerateActionListEnd;
				InstallGenerator2.DoEventStartEventHandler obj4 = AOIInstallGenerator_DoEventStart;
				InstallGenerator2.DoEventErrorEventHandler obj5 = AOIInstallGenerator_DoEventError;
				if (_AOIInstallGenerator != null)
				{
					_AOIInstallGenerator.GenerateActionListStart -= obj;
					_AOIInstallGenerator.GenerateActionListError -= obj2;
					_AOIInstallGenerator.GenerateActionListEnd -= obj3;
					_AOIInstallGenerator.DoEventStart -= obj4;
					_AOIInstallGenerator.DoEventError -= obj5;
				}
				_AOIInstallGenerator = value;
				if (_AOIInstallGenerator != null)
				{
					_AOIInstallGenerator.GenerateActionListStart += obj;
					_AOIInstallGenerator.GenerateActionListError += obj2;
					_AOIInstallGenerator.GenerateActionListEnd += obj3;
					_AOIInstallGenerator.DoEventStart += obj4;
					_AOIInstallGenerator.DoEventError += obj5;
				}
			}
		}

		public bool HasError => _e;

		public bool IsComplete => _c;

		public string StepName => "Install Script Generator";

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

		public InstallStep_InstallGenerator(bool isfolder, string temppath, string downloadpath, Uri j, string installpath)
		{
			StepError += InstallStep_InstallGenerator_StepError;
			_c = false;
			isf = false;
			raw = false;
			_e = false;
			throwex = true;
			isf = isfolder;
			tp = temppath;
			dp = downloadpath;
			u = j;
			ip = installpath;
		}

		public InstallStep_InstallGenerator(bool isfolder, string temppath, string downloadpath, Uri j, string installpath, List<string> ba)
		{
			StepError += InstallStep_InstallGenerator_StepError;
			_c = false;
			isf = false;
			raw = false;
			_e = false;
			throwex = true;
			isf = isfolder;
			tp = temppath;
			dp = downloadpath;
			u = j;
			ip = installpath;
			i = ba;
			raw = true;
		}

		public void Start()
		{
			StepStartedEvent?.Invoke();
			AOIInstallGenerator = new InstallGenerator2();
			if (i == null)
			{
				i = new List<string>();
				if (isf)
				{
					i = AOIInstallGenerator.GenerateActionListForFolder(tp);
				}
				else
				{
					i = AOIInstallGenerator.GenerateActionListForArchive(Path.Combine(dp, Strings.Split(u.AbsolutePath, "/").Last()));
				}
			}
			else if (raw)
			{
				List<string> list = new List<string>();
				foreach (string item in i)
				{
					list.Add(AOIInstallGenerator.GetActionForFile(item));
				}
				i = list;
			}
			if (i == null)
			{
				_c = true;
				_e = true;
				StepErrorEvent?.Invoke("Error in install generator");
				return;
			}
			foreach (string item2 in i)
			{
				int num = 0;
				try
				{
					AOIInstallGenerator.DoAction(item2, tp, ip);
					num = checked(num + 1);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StepMessageEvent?.Invoke("BAD INSTRUCTION: " + item2);
					ProjectData.ClearProjectError();
				}
			}
			_c = true;
			StepCompleteEvent?.Invoke();
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

		private void AOIInstallGenerator_DoEventError(string Message)
		{
			_e = true;
			StepErrorEvent?.Invoke("AOI Message " + Message);
		}

		private void AOIInstallGenerator_DoEventStart(string i)
		{
			StepMessageEvent?.Invoke("Running Install Action: " + i);
		}

		private void AOIInstallGenerator_GenerateActionListEnd()
		{
			StepMessageEvent?.Invoke("Generate Action List Complete");
		}

		private void AOIInstallGenerator_GenerateActionListError(string Message)
		{
			if (throwex)
			{
				StepErrorEvent?.Invoke(Message);
				_e = true;
			}
		}

		private void AOIInstallGenerator_GenerateActionListStart()
		{
			StepMessageEvent?.Invoke("Generating Action List");
		}

		private void InstallStep_InstallGenerator_StepError(string Message)
		{
			if (throwex)
			{
				throwex = false;
				_e = true;
				StepErrorEvent?.Invoke(Message);
			}
		}
	}
}
