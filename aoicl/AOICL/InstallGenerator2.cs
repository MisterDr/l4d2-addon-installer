using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using AOICL.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class InstallGenerator2
	{
		public delegate void DoEventStartEventHandler(string i);

		public delegate void DoEventEndEventHandler();

		public delegate void DoEventErrorEventHandler(string Message);

		public delegate void GenerateActionListStartEventHandler();

		public delegate void GenerateActionListEndEventHandler();

		public delegate void GenerateActionListErrorEventHandler(string Message);

		private bool throwex;

		private DoEventStartEventHandler DoEventStartEvent;

		private DoEventEndEventHandler DoEventEndEvent;

		private DoEventErrorEventHandler DoEventErrorEvent;

		private GenerateActionListStartEventHandler GenerateActionListStartEvent;

		private GenerateActionListEndEventHandler GenerateActionListEndEvent;

		private GenerateActionListErrorEventHandler GenerateActionListErrorEvent;

		public event DoEventStartEventHandler DoEventStart
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DoEventStartEvent = (DoEventStartEventHandler)Delegate.Combine(DoEventStartEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DoEventStartEvent = (DoEventStartEventHandler)Delegate.Remove(DoEventStartEvent, value);
			}
		}

		public event DoEventEndEventHandler DoEventEnd
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DoEventEndEvent = (DoEventEndEventHandler)Delegate.Combine(DoEventEndEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DoEventEndEvent = (DoEventEndEventHandler)Delegate.Remove(DoEventEndEvent, value);
			}
		}

		public event DoEventErrorEventHandler DoEventError
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				DoEventErrorEvent = (DoEventErrorEventHandler)Delegate.Combine(DoEventErrorEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				DoEventErrorEvent = (DoEventErrorEventHandler)Delegate.Remove(DoEventErrorEvent, value);
			}
		}

		public event GenerateActionListStartEventHandler GenerateActionListStart
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				GenerateActionListStartEvent = (GenerateActionListStartEventHandler)Delegate.Combine(GenerateActionListStartEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				GenerateActionListStartEvent = (GenerateActionListStartEventHandler)Delegate.Remove(GenerateActionListStartEvent, value);
			}
		}

		public event GenerateActionListEndEventHandler GenerateActionListEnd
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				GenerateActionListEndEvent = (GenerateActionListEndEventHandler)Delegate.Combine(GenerateActionListEndEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				GenerateActionListEndEvent = (GenerateActionListEndEventHandler)Delegate.Remove(GenerateActionListEndEvent, value);
			}
		}

		public event GenerateActionListErrorEventHandler GenerateActionListError
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				GenerateActionListErrorEvent = (GenerateActionListErrorEventHandler)Delegate.Combine(GenerateActionListErrorEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				GenerateActionListErrorEvent = (GenerateActionListErrorEventHandler)Delegate.Remove(GenerateActionListErrorEvent, value);
			}
		}

		public InstallGenerator2()
		{
			throwex = true;
		}

		public string GetActionForFile(string fname)
		{
			checked
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fname);
					if (Operators.CompareString(fileInfo.Extension, "", TextCompare: false) == 0)
					{
						return null;
					}
					string text = null;
					string directoryPath = MyProject.Application.Info.DirectoryPath;
					string text2 = fname.Replace(directoryPath, "");
					string format = "COPY:{0}:{1}";
					if (Operators.CompareString(Strings.LCase(fileInfo.Extension), ".vpk", TextCompare: false) == 0)
					{
						return string.Format(format, "%EXTRACTDIR%\\" + text2, "%L4D2%\\left4dead2\\addons\\" + fileInfo.Name);
					}
					fileInfo = fileInfo;
					string[] array = Strings.Split(fileInfo.DirectoryName.Replace(directoryPath, ""), "\\");
					string text3 = null;
					int num = -1;
					string text4 = null;
					int num2 = array.Length - 1;
					for (int i = 0; i <= num2; i++)
					{
						string value = array[i];
						if (Operators.CompareString(Strings.LCase(value), "maps", TextCompare: false) == 0)
						{
							num = i;
							text4 = "%L4D2%\\left4dead2\\maps\\";
							break;
						}
						if (Operators.CompareString(Strings.LCase(value), "missions", TextCompare: false) == 0)
						{
							num = i;
							text4 = "%L4D2%\\left4dead2\\missions\\";
							break;
						}
						if (Operators.CompareString(Strings.LCase(value), "sound", TextCompare: false) == 0)
						{
							num = i;
							text4 = "%L4D2%\\left4dead2\\sounds\\";
							break;
						}
						if (Operators.CompareString(Strings.LCase(value), "scripts", TextCompare: false) == 0)
						{
							num = i;
							text4 = "%L4D2%\\left4dead2\\scripts\\";
							break;
						}
						if (Operators.CompareString(Strings.LCase(value), "materials", TextCompare: false) == 0)
						{
							num = i;
							text4 = "%L4D2%\\left4dead2\\materials\\";
							break;
						}
					}
					int num3 = num + 1;
					int num4 = array.Length - 1;
					for (int j = num3; j <= num4; j++)
					{
						text3 = text3 + array[j] + "\\";
					}
					return string.Format(format, "%EXTRACTDIR%\\" + text2, text4 + text3 + fileInfo.Name);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					GenerateActionListErrorEvent?.Invoke("Generate Action List Generic Error");
					string result = null;
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}

		public void DoAction(string InstallAction, string SourceLocation, string DestinationLocation)
		{
			DoEventStartEvent?.Invoke(InstallAction);
			try
			{
				DoActionCommand doActionCommand = new DoActionCommand(InstallAction);
				string[] array = Strings.Split(InstallAction, ":");
				string text = Strings.Split(InstallAction, ":").First();
				string text2 = null;
				string text3 = null;
				DoActionCommandType commandType = doActionCommand.CommandType;
				if (commandType == DoActionCommandType.Copy)
				{
					DoActionCommandCopy doActionCommandCopy = new DoActionCommandCopy(doActionCommand);
					string source = doActionCommandCopy.Source;
					source = source.Replace("%EXTRACTDIR%", SourceLocation);
					string destination = doActionCommandCopy.Destination;
					destination = destination.Replace("%L4D2%", DestinationLocation);
					FileInfo fileInfo = new FileInfo(source);
					if (fileInfo.Exists)
					{
						try
						{
							FileInfo fileInfo2 = new FileInfo(destination);
							if (!fileInfo2.Directory.Exists)
							{
								fileInfo2.Directory.Create();
							}
							DirectoryInfo directoryInfo = new DirectoryInfo(DestinationLocation);
							if (fileInfo2.FullName.StartsWith(directoryInfo.FullName))
							{
								fileInfo2 = fileInfo.CopyTo(destination, overwrite: true);
								if (!fileInfo2.Exists)
								{
									DoEventErrorEvent?.Invoke("Do Action Error Copying File: " + fileInfo.FullName + " To " + destination);
								}
							}
							fileInfo2 = null;
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							DoEventErrorEvent?.Invoke("Do Action Error Copying File: " + ex2.ToString());
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						DoEventErrorEvent?.Invoke("Do Action Error: Cannot Find file - " + fileInfo.FullName);
					}
					fileInfo = null;
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				DoEventErrorEvent?.Invoke("Do Event Generic Error: " + ex4.ToString());
				ProjectData.ClearProjectError();
			}
			DoEventEndEvent?.Invoke();
		}

		public List<string> GenerateActionListForArchive(string FileName)
		{
			//Discarded unreachable code: IL_00b2
			GenerateActionListStartEvent?.Invoke();
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			Archive archive = new Archive(FileName);
			list = archive.Entries();
			if (list == null)
			{
				return null;
			}
			try
			{
				if (list == null)
				{
					if (throwex)
					{
						GenerateActionListErrorEvent?.Invoke("E");
						throwex = false;
					}
					return null;
				}
				int count = list.Count;
				int num = 0;
				foreach (string item in list)
				{
					string actionForFile = GetActionForFile(item);
					list2.Add(actionForFile);
					num = checked(num + 1);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (throwex)
				{
					GenerateActionListErrorEvent?.Invoke(ex2.ToString());
					throwex = false;
					List<string> result = null;
					ProjectData.ClearProjectError();
					return result;
				}
				ProjectData.ClearProjectError();
			}
			GenerateActionListEndEvent?.Invoke();
			return list2;
		}

		public List<string> GenerateActionListForFolder(string folderpath)
		{
			GenerateActionListStartEvent?.Invoke();
			string[] files = Directory.GetFiles(folderpath, "*.*", SearchOption.AllDirectories);
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			string[] array = files;
			foreach (string expression in array)
			{
				list.Add(Strings.Replace(expression, folderpath + "\\", ""));
			}
			foreach (string item in list)
			{
				string actionForFile = GetActionForFile(item);
				list2.Add(actionForFile);
			}
			GenerateActionListEndEvent?.Invoke();
			return list2;
		}
	}
}
