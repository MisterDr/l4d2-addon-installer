using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using AOICL.Downloads;
using AOICL.Functions.GenericFunctions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL.Installer
{
	public class AddOnInstaller : IDisposable
	{
		public delegate void InstallerStartedEventHandler();

		public delegate void InstallerCompleteEventHandler();

		public delegate void InstallerProgressChangedEventHandler(int PercentageComplete);

		public delegate void TaskStartedEventHandler(string TaskName);

		public delegate void TaskCompleteEventHandler();

		public delegate void TaskProgressChangedEventHandler(int PercentageComplete);

		public delegate void InstallerTaskMessageEventHandler(string m);

		public delegate void LogMessageEventHandler(string m);

		public delegate void InstallerErrorEventHandler(string EM);

		[AccessedThroughProperty("CurrentStep")]
		private iInstallStep _CurrentStep;

		private int tcount;

		private int tcurrent;

		private InstallerStartedEventHandler InstallerStartedEvent;

		private InstallerCompleteEventHandler InstallerCompleteEvent;

		private InstallerProgressChangedEventHandler InstallerProgressChangedEvent;

		private TaskStartedEventHandler TaskStartedEvent;

		private TaskCompleteEventHandler TaskCompleteEvent;

		private TaskProgressChangedEventHandler TaskProgressChangedEvent;

		private InstallerTaskMessageEventHandler InstallerTaskMessageEvent;

		private LogMessageEventHandler LogMessageEvent;

		private InstallerErrorEventHandler InstallerErrorEvent;

		private string URIofFiletoInstall;

		private List<string> i;

		private string Left4DeadInstallPath;

		public string dlfile;

		private string AOIAppDataPath;

		private string AOITempPath;

		private string AOIDownloadPath;

		[AccessedThroughProperty("AOIInstallThread")]
		private Thread _AOIInstallThread;

		[AccessedThroughProperty("AOIStepThread")]
		private Thread _AOIStepThread;

		[AccessedThroughProperty("FileLogger")]
		private ErrorLogger _FileLogger;

		private bool ForceClose;

		private bool ArchiveExtractError;

		public bool abortwhatyouaredoing;

		private bool HasDownloadError;

		private bool HadDownloadFinished;

		private bool XMLMODe;

		private InstallFileGeneratorTasks it;

		private int ittIndex;

		private string xmlpath;

		private List<string> extractedfiles;

		private bool FileDownloaded;

		private AddOnDownload CurrentDownload;

		private bool IsFolder;

		private bool IsLocal;

		private bool IsFile;

		private string FileDownloadPath;

		private string DownloadURI;

		private Uri j;

		private InstallFileGeneratorTask currenttask;

		public bool Canceled;

		private bool _erroralreadythrown;

		private bool disposedValue;

		public virtual iInstallStep CurrentStep
		{
			[DebuggerNonUserCode]
			get
			{
				return _CurrentStep;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				iInstallStep.StepStartedEventHandler obj = CurrentStep_StepStarted;
				iInstallStep.StepProgressEventHandler obj2 = CurrentStep_StepProgress;
				iInstallStep.StepMessageEventHandler obj3 = CurrentStep_StepMessage;
				iInstallStep.StepErrorEventHandler obj4 = CurrentStep_StepError;
				iInstallStep.StepCompleteEventHandler obj5 = CurrentStep_StepComplete;
				if (_CurrentStep != null)
				{
					_CurrentStep.StepStarted -= obj;
					_CurrentStep.StepProgress -= obj2;
					_CurrentStep.StepMessage -= obj3;
					_CurrentStep.StepError -= obj4;
					_CurrentStep.StepComplete -= obj5;
				}
				_CurrentStep = value;
				if (_CurrentStep != null)
				{
					_CurrentStep.StepStarted += obj;
					_CurrentStep.StepProgress += obj2;
					_CurrentStep.StepMessage += obj3;
					_CurrentStep.StepError += obj4;
					_CurrentStep.StepComplete += obj5;
				}
			}
		}

		public virtual Thread AOIInstallThread
		{
			[DebuggerNonUserCode]
			get
			{
				return _AOIInstallThread;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_AOIInstallThread = value;
			}
		}

		public virtual Thread AOIStepThread
		{
			[DebuggerNonUserCode]
			get
			{
				return _AOIStepThread;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_AOIStepThread = value;
			}
		}

		public virtual ErrorLogger FileLogger
		{
			[DebuggerNonUserCode]
			get
			{
				return _FileLogger;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_FileLogger = value;
			}
		}

		public event InstallerStartedEventHandler InstallerStarted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				InstallerStartedEvent = (InstallerStartedEventHandler)Delegate.Combine(InstallerStartedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				InstallerStartedEvent = (InstallerStartedEventHandler)Delegate.Remove(InstallerStartedEvent, value);
			}
		}

		public event InstallerCompleteEventHandler InstallerComplete
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				InstallerCompleteEvent = (InstallerCompleteEventHandler)Delegate.Combine(InstallerCompleteEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				InstallerCompleteEvent = (InstallerCompleteEventHandler)Delegate.Remove(InstallerCompleteEvent, value);
			}
		}

		public event InstallerProgressChangedEventHandler InstallerProgressChanged
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				InstallerProgressChangedEvent = (InstallerProgressChangedEventHandler)Delegate.Combine(InstallerProgressChangedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				InstallerProgressChangedEvent = (InstallerProgressChangedEventHandler)Delegate.Remove(InstallerProgressChangedEvent, value);
			}
		}

		public event TaskStartedEventHandler TaskStarted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				TaskStartedEvent = (TaskStartedEventHandler)Delegate.Combine(TaskStartedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				TaskStartedEvent = (TaskStartedEventHandler)Delegate.Remove(TaskStartedEvent, value);
			}
		}

		public event TaskCompleteEventHandler TaskComplete
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				TaskCompleteEvent = (TaskCompleteEventHandler)Delegate.Combine(TaskCompleteEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				TaskCompleteEvent = (TaskCompleteEventHandler)Delegate.Remove(TaskCompleteEvent, value);
			}
		}

		public event TaskProgressChangedEventHandler TaskProgressChanged
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				TaskProgressChangedEvent = (TaskProgressChangedEventHandler)Delegate.Combine(TaskProgressChangedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				TaskProgressChangedEvent = (TaskProgressChangedEventHandler)Delegate.Remove(TaskProgressChangedEvent, value);
			}
		}

		public event InstallerTaskMessageEventHandler InstallerTaskMessage
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				InstallerTaskMessageEvent = (InstallerTaskMessageEventHandler)Delegate.Combine(InstallerTaskMessageEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				InstallerTaskMessageEvent = (InstallerTaskMessageEventHandler)Delegate.Remove(InstallerTaskMessageEvent, value);
			}
		}

		public event LogMessageEventHandler LogMessage
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				LogMessageEvent = (LogMessageEventHandler)Delegate.Combine(LogMessageEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				LogMessageEvent = (LogMessageEventHandler)Delegate.Remove(LogMessageEvent, value);
			}
		}

		public event InstallerErrorEventHandler InstallerError
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				InstallerErrorEvent = (InstallerErrorEventHandler)Delegate.Combine(InstallerErrorEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				InstallerErrorEvent = (InstallerErrorEventHandler)Delegate.Remove(InstallerErrorEvent, value);
			}
		}

		public AddOnInstaller(string filetoinstall, string l4dinstallpath)
		{
			InstallerError += AddOnInstaller_InstallerError;
			tcount = 0;
			tcurrent = 0;
			URIofFiletoInstall = null;
			dlfile = null;
			AOIAppDataPath = AOIPaths.AppDataPath();
			AOITempPath = AOIPaths.TempDataPath();
			AOIDownloadPath = AOIPaths.DownloadsPath();
			AOIInstallThread = null;
			AOIStepThread = null;
			FileLogger = new ErrorLogger();
			ForceClose = false;
			ArchiveExtractError = false;
			abortwhatyouaredoing = false;
			HasDownloadError = false;
			HadDownloadFinished = false;
			XMLMODe = false;
			it = new InstallFileGeneratorTasks();
			ittIndex = 0;
			extractedfiles = null;
			FileDownloaded = false;
			CurrentDownload = null;
			IsFolder = false;
			IsLocal = false;
			IsFile = false;
			FileDownloadPath = null;
			DownloadURI = null;
			j = null;
			currenttask = null;
			Canceled = false;
			_erroralreadythrown = false;
			disposedValue = false;
			string text = "Calling Assembly Name: " + Assembly.GetExecutingAssembly().GetName().FullName.ToString();
			text = text + "\r\nDate/Time: " + DateAndTime.Now.ToString();
			text = text + "\r\nTask XML: " + filetoinstall;
			text = text + "\r\nL4D2 Install Path: " + l4dinstallpath;
			FileLogger.WriteEntry("AOI Startup", text);
			xmlpath = filetoinstall;
			try
			{
				it = InstallFileGenerator.OpenJobFile(filetoinstall);
				XMLMODe = true;
				if (it.Tasks.Count == 0)
				{
					FileLogger.WriteEntry("Task XML", "There is nothing to install");
					Interaction.MsgBox("There is nothing to install" + filetoinstall);
				}
				else
				{
					URIofFiletoInstall = it.Tasks[0].AddOn.Downloads[0].URL;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				XMLMODe = false;
				URIofFiletoInstall = filetoinstall;
				ProjectData.ClearProjectError();
			}
			FileLogger.WriteEntry("Starting Install", DateAndTime.Now.ToString());
			Left4DeadInstallPath = l4dinstallpath;
		}

		public void DoInstall()
		{
			FileLogger.WriteEntry("Do Install", "do install creating thread");
			AOIInstallThread = new Thread(installaddon);
			AOIInstallThread.Start();
		}

		public void TryCreatePaths()
		{
			try
			{
				Directory.CreateDirectory(AOITempPath);
				LogMessageEvent?.Invoke("Temp Path: " + AOITempPath);
				Directory.CreateDirectory(AOIDownloadPath);
				LogMessageEvent?.Invoke("DL Path: " + AOIDownloadPath);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				LogMessageEvent?.Invoke("Error Creating Directories");
				ProjectData.ClearProjectError();
			}
		}

		private void Step_CreatePaths()
		{
			FileLogger.WriteEntry("Install addon", "creating paths");
			RunStep(new InstallStep_CreatePaths(), Threaded: false);
		}

		private void Step_ExtactArchive()
		{
			FileLogger.WriteEntry("installer task", "Starting archive extractions");
			TaskStartedEvent?.Invoke("Extracting");
			InstallerProgressChangedEvent?.Invoke(25);
			FileLogger.WriteEntry("Extract", "Started");
			RunStep(new InstallStep_Archive(IsFolder, AOITempPath, AOIDownloadPath, CurrentDownload.ToURI(), Left4DeadInstallPath, IsLocal, URIofFiletoInstall));
			if (IsFolder)
			{
				AOITempPath = CurrentDownload.URL;
			}
			if (CurrentStep.HasError)
			{
				Step_DeleteBadArchive();
			}
			InstallStep_Archive installStep_Archive = (InstallStep_Archive)CurrentStep;
			extractedfiles = installStep_Archive.fa;
			FileLogger.WriteEntry("Extract", "Finished");
		}

		private bool RunStep(iInstallStep s, bool Threaded = true, int ThreadSleep = 100)
		{
			try
			{
				CurrentStep = s;
				if (Threaded)
				{
					AOIStepThread = new Thread(CurrentStep.Start);
					AOIStepThread.Start();
				}
				else
				{
					s.Start();
				}
				while (!CurrentStep.IsComplete)
				{
					if (Threaded)
					{
						Thread.Sleep(ThreadSleep);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				AOIStepThread = null;
				bool result = true;
				ProjectData.ClearProjectError();
				return result;
			}
			AOIStepThread = null;
			return CurrentStep.HasError;
		}

		private void Step_DeleteBadArchive()
		{
			MsgBoxResult msgBoxResult = Interaction.MsgBox("There was a problem extracting the archive? This could indicate a download problem!\r\n\r\nDo you wish to delete the archive? (you will have to restart the install)", MsgBoxStyle.YesNo, "Download Archive");
			if (msgBoxResult == MsgBoxResult.Yes)
			{
				try
				{
					File.Delete(FileDownloadPath);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		private void Step_DownloadFile()
		{
			FileLogger.WriteEntry("installer task", "Download URI is Remote");
			TaskStartedEvent?.Invoke("Downloading");
			LogMessageEvent?.Invoke("Download file: " + DownloadURI);
			string fileName = Strings.Split(DownloadURI, "/").Last();
			if (!DownloadCache.IsDownloadCached(DownloadURI))
			{
				FileLogger.WriteEntry("Download", "Download started");
				if (RunStep(new ds2(j, FileDownloadPath), Threaded: true, 250))
				{
					FileLogger.WriteEntry("Download", "Download Error: ");
					LogMessageEvent?.Invoke("Error Downloading File, trying next URL");
					return;
				}
				LogMessageEvent?.Invoke("Download Complete");
				DownloadCache.AddToCache(j.AbsoluteUri, fileName);
				FileDownloaded = true;
				FileLogger.WriteEntry("Download", "Complete");
			}
			else
			{
				FileLogger.WriteEntry("Download", "File is in download cache");
				HadDownloadFinished = true;
				HasDownloadError = false;
				FileDownloaded = true;
				LogMessageEvent?.Invoke("File has allready been downloaded. Using file: " + FileDownloadPath);
			}
		}

		private void Step_Local()
		{
			FileLogger.WriteEntry("installer task", "Download URI is local");
			FileDownloaded = true;
			if (IsFolder)
			{
				TaskStartedEvent?.Invoke("Copying Folder");
				FileLogger.WriteEntry("installer task", "Download URI is folder");
			}
			else if (IsFile)
			{
				FileLogger.WriteEntry("installer task", "Download URI is file");
				TaskStartedEvent?.Invoke("Copying File");
				File.Copy(DownloadURI, AOIDownloadPath + "\\" + Strings.Split(DownloadURI, "\\").Last(), overwrite: true);
			}
			else
			{
				FileDownloaded = false;
				FileLogger.WriteEntry("installer task", "Download Is Local But Neither a File Nor Folder???");
			}
		}

		private void Step_Downloads()
		{
			foreach (AddOnDownload download in currenttask.AddOn.Downloads)
			{
				CurrentDownload = download;
				FileDownloadPath = Path.Combine(AOIPaths.DownloadsPath(), CurrentDownload.ToURI().AbsoluteUri.Split('/').Last());
				DownloadURI = CurrentDownload.URL;
				j = new Uri(DownloadURI);
				FileLogger.WriteEntry("installer task", "Download URI: " + DownloadURI);
				IsFolder = CurrentDownload.IsFolder;
				IsLocal = CurrentDownload.IsLocal;
				IsFile = CurrentDownload.IsFile;
				if (IsLocal)
				{
					Step_Local();
				}
				else
				{
					Step_DownloadFile();
				}
				if (FileDownloaded)
				{
					break;
				}
			}
			if (!FileDownloaded)
			{
				InstallerErrorEvent?.Invoke("Download Error: Non of the downloads compleded");
			}
		}

		private void DoTasks()
		{
			Step_CreatePaths();
			CurrentStep = CurrentStep;
			tcount = it.Tasks.Count;
			tcurrent = 0;
			FileLogger.WriteEntry("Install addon", "starting task installer");
			checked
			{
				foreach (InstallFileGeneratorTask task in it.Tasks)
				{
					currenttask = task;
					string format = "Task {0} or {1} : {2}";
					LogMessageEvent?.Invoke(string.Format(format, tcurrent + 1, tcount, "Started"));
					FileLogger.WriteEntry("installer task", string.Format(format, tcurrent + 1, tcount, "Started"));
					Step_Downloads();
					Step_ExtactArchive();
					Step_InstallGenerator();
					TaskStartedEvent?.Invoke("Finished");
					InstallerProgressChangedEvent?.Invoke(100);
					TaskProgressChangedEvent?.Invoke(100);
					FileLogger.WriteEntry("installer task", string.Format(format, tcurrent + 1, tcount, "Finished"));
					LogMessageEvent?.Invoke(string.Format(format, tcurrent + 1, tcount, "Finished"));
					it.Tasks[tcurrent].Status = InstallFileGeneratorTaskStatus.Complete;
					tcurrent++;
				}
			}
		}

		private void Step_InstallGenerator()
		{
			TaskStartedEvent?.Invoke("Gathering Update Instructions");
			InstallerProgressChangedEvent?.Invoke(50);
			FileLogger.WriteEntry("installer task", "generating installer script");
			FileLogger.WriteEntry("installer script", "Started");
			if (extractedfiles == null)
			{
				RunStep(new InstallStep_InstallGenerator(IsFolder, AOITempPath, AOIDownloadPath, CurrentDownload.ToURI(), Left4DeadInstallPath));
			}
			else
			{
				RunStep(new InstallStep_InstallGenerator(IsFolder, AOITempPath, AOIDownloadPath, CurrentDownload.ToURI(), Left4DeadInstallPath, extractedfiles));
			}
			if (CurrentStep.HasError)
			{
				InstallerErrorEvent?.Invoke("There is an error with the file try deleting the file from the download cache:\r\n(View > Application Folders > Download Folder)");
			}
			FileLogger.WriteEntry("installer script", "Finished");
		}

		public void installaddon()
		{
			FileLogger.WriteEntry("Install addon", "start");
			DoTasks();
			LogMessageEvent?.Invoke("Install Finished");
			InstallerCompleteEvent?.Invoke();
			FileLogger.WriteEntry("installer", "All tasks complete");
			CurrentStep = null;
		}

		public void CancelInstall()
		{
			try
			{
				if (CurrentStep != null)
				{
					CurrentStep.Stop();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			Canceled = true;
			try
			{
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			try
			{
				abortwhatyouaredoing = true;
				AOIInstallThread.Abort();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}

		~AddOnInstaller()
		{
			try
			{
				InstallFileGenerator.CreateJobFile(it, xmlpath);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			FileLogger.WriteEntry("Installer Closing", DateAndTime.Now.ToString());
			// base.Finalize();
		}

		private void CurrentStep_StepComplete()
		{
			FileLogger.WriteEntry(CurrentStep.StepName, "Complete");
			if (CurrentStep.GetType() == typeof(InstallStep_Download))
			{
				InstallStep_Download installStep_Download = (InstallStep_Download)CurrentStep;
				try
				{
					DownloadCache.AddToCache(installStep_Download.j.AbsoluteUri.ToString(), Strings.Split(installStep_Download.j.AbsoluteUri.ToString(), "/").Last());
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Interaction.MsgBox("Add to cache error");
					ProjectData.ClearProjectError();
				}
			}
			TaskProgressChangedEvent?.Invoke(100);
		}

		private void CurrentStep_StepError(string Message)
		{
			if (_erroralreadythrown)
			{
				FileLogger.WriteEntry(CurrentStep.StepName, "Error: " + Message);
				return;
			}
			_erroralreadythrown = true;
			if (CurrentStep.GetType() == typeof(InstallStep_Download))
			{
				LogMessageEvent?.Invoke(Message);
			}
			else
			{
				LogMessageEvent?.Invoke(Message);
			}
		}

		private void CurrentStep_StepMessage(string message)
		{
			LogMessageEvent?.Invoke(message);
			FileLogger.WriteEntry(CurrentStep.StepName, "Message: " + message);
		}

		private void CurrentStep_StepProgress(int Progress, object data)
		{
			TaskProgressChangedEvent?.Invoke(Progress);
			checked
			{
				if (CurrentStep.GetType() == typeof(ds2) && data.GetType() == typeof(DownloadProgress2))
				{
					DownloadProgress2 downloadProgress = (DownloadProgress2)data;
					string text = BytesToSI.BytesToSI2((long)Math.Round(downloadProgress.bi / DateAndTime.Now.Subtract(downloadProgress.DownloadStarted).TotalSeconds));
					InstallerTaskMessageEvent?.Invoke("Downloading : " + BytesToSI.BytesToSI2((long)Math.Round(downloadProgress.bi)) + " of " + BytesToSI.BytesToSI2((long)Math.Round(downloadProgress.tb)) + " (" + Conversions.ToString(Progress) + "%)  " + text + "/S");
				}
			}
		}

		private void CurrentStep_StepStarted()
		{
			TaskProgressChangedEvent?.Invoke(0);
			FileLogger.WriteEntry(CurrentStep.StepName, "Started");
		}

		private void AddOnInstaller_InstallerError(string EM)
		{
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
			}
			disposedValue = true;
		}

		public void Dispose()
		{
			CurrentStep.Stop();
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}
	}
}
