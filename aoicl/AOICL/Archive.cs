using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Chilkat;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class Archive
	{
		public delegate void ExtractStartedEventHandler();

		public delegate void ExtractCompleteEventHandler();

		public delegate void ExtractProgressEventHandler(int i);

		public delegate void ExtractErrorEventHandler(string Message);

		private string _path;

		private FileInfo FileInfo;

		private Rar ArchiveRAR;

		private ZipFile ArchiveZIP;

		private FastZip ArchiveFastZIP;

		public List<string> ExtractedFiles;

		private bool stopex;

		private ExtractStartedEventHandler ExtractStartedEvent;

		private ExtractCompleteEventHandler ExtractCompleteEvent;

		private ExtractProgressEventHandler ExtractProgressEvent;

		private ExtractErrorEventHandler ExtractErrorEvent;

		public event ExtractStartedEventHandler ExtractStarted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				ExtractStartedEvent = (ExtractStartedEventHandler)Delegate.Combine(ExtractStartedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				ExtractStartedEvent = (ExtractStartedEventHandler)Delegate.Remove(ExtractStartedEvent, value);
			}
		}

		public event ExtractCompleteEventHandler ExtractComplete
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				ExtractCompleteEvent = (ExtractCompleteEventHandler)Delegate.Combine(ExtractCompleteEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				ExtractCompleteEvent = (ExtractCompleteEventHandler)Delegate.Remove(ExtractCompleteEvent, value);
			}
		}

		public event ExtractProgressEventHandler ExtractProgress
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				ExtractProgressEvent = (ExtractProgressEventHandler)Delegate.Combine(ExtractProgressEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				ExtractProgressEvent = (ExtractProgressEventHandler)Delegate.Remove(ExtractProgressEvent, value);
			}
		}

		public event ExtractErrorEventHandler ExtractError
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				ExtractErrorEvent = (ExtractErrorEventHandler)Delegate.Combine(ExtractErrorEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				ExtractErrorEvent = (ExtractErrorEventHandler)Delegate.Remove(ExtractErrorEvent, value);
			}
		}

		public Archive(string path)
		{
			_path = null;
			FileInfo = null;
			ArchiveRAR = null;
			ArchiveZIP = null;
			ArchiveFastZIP = null;
			ExtractedFiles = new List<string>();
			stopex = false;
			_path = path;
			FileInfo = new FileInfo(path);
		}

		~Archive()
		{
			if (FileInfo != null)
			{
				FileInfo = null;
			}
			if (ArchiveRAR != null)
			{
				ArchiveRAR = null;
			}
			// base.Finalize();
		}

		public List<string> Entries()
		{
			List<string> list = new List<string>();
			checked
			{
				if (Strings.LCase(_path).EndsWith("rar"))
				{
					ArchiveRAR = new Rar();
					ArchiveRAR.Open(_path);
					int num = ArchiveRAR.NumEntries - 1;
					for (int i = 0; i <= num; i++)
					{
						if (!ArchiveRAR.GetEntryByIndex(i).IsDirectory)
						{
							list.Add(ArchiveRAR.GetEntryByIndex(i).Filename);
						}
					}
					ArchiveRAR.Close();
					return list;
				}
				try
				{
					ArchiveZIP = new ZipFile(_path);
					int num2 = (int)(ArchiveZIP.Count - 1);
					for (int j = 0; j <= num2; j++)
					{
						if (!ArchiveZIP[j].IsDirectory)
						{
							list.Add(ArchiveZIP[j].Name);
						}
					}
					ArchiveZIP.Close();
					return list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ExtractErrorEvent?.Invoke("Generate Entry list zip error\r\n" + ex2.ToString());
					List<string> result = null;
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}

		public void Extract(string Folder)
		{
			ExtractStartedEvent?.Invoke();
			FileInfo fileInfo = new FileInfo(_path);
			checked
			{
				if (Operators.CompareString(Strings.LCase(fileInfo.Extension), ".rar", TextCompare: false) == 0)
				{
					try
					{
						ArchiveRAR = new Rar();
						ArchiveRAR.Open(_path);
						RarEntry rarEntry = null;
						try
						{
							int numEntries = ArchiveRAR.NumEntries;
							int num = 0;
							int num2 = numEntries - 1;
							for (int i = 0; i <= num2; i++)
							{
								rarEntry = ArchiveRAR.GetEntryByIndex(i);
								rarEntry.Unrar(Folder);
								ExtractedFiles.Add(rarEntry.Filename);
								if (stopex)
								{
									ExtractErrorEvent?.Invoke("Extract canceled by the user!");
									break;
								}
								num++;
								ExtractProgressEvent?.Invoke((int)Math.Round(Math.Floor((double)num / (double)numEntries * 100.0)));
							}
							rarEntry = null;
							ArchiveRAR = null;
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ExtractErrorEvent?.Invoke("Extract Error\r\n" + ex2.ToString() + ArchiveRAR.LastErrorText);
							ProjectData.ClearProjectError();
							return;
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ExtractErrorEvent?.Invoke("Extract Error\r\n" + ex4.ToString());
						ProjectData.ClearProjectError();
						return;
					}
				}
				else
				{
					if (Operators.CompareString(Strings.LCase(fileInfo.Extension), ".zip", TextCompare: false) != 0)
					{
						ExtractErrorEvent?.Invoke("Extract Error\r\nThis is an unsuppored file extension: " + _path);
						return;
					}
					try
					{
						FastZipEvents fastZipEvents = new FastZipEvents();
						fastZipEvents.Progress = pro;
						fastZipEvents.ProgressInterval = TimeSpan.FromMilliseconds(100.0);
						ArchiveFastZIP = new FastZip(fastZipEvents);
						ArchiveFastZIP.ExtractZip(_path, Folder, "");
						ArchiveFastZIP = null;
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						ExtractErrorEvent?.Invoke("Extract Error\r\n" + ex6.ToString());
						ProjectData.ClearProjectError();
						return;
					}
				}
				ExtractCompleteEvent?.Invoke();
			}
		}

		private void pro(object sender, ProgressEventArgs e)
		{
			ExtractProgressEvent?.Invoke(checked((int)Math.Round(e.PercentComplete)));
			if (!ExtractedFiles.Contains(e.Name))
			{
				ExtractedFiles.Add(e.Name);
			}
			if (stopex)
			{
				e.ContinueRunning = false;
				ExtractErrorEvent?.Invoke("Extraction canceled by user!");
			}
		}

		public void Cancel()
		{
			stopex = true;
		}
	}
}
