using System;
using System.Collections.Generic;

namespace AOICL
{
	[Serializable]
	public class InstallFileGeneratorTasks
	{
		public List<InstallFileGeneratorTask> Tasks;

		public string TempPath;

		public string DownloadPath;

		public bool KeepDownloadAfterInstall;

		public bool KeepTempFilesAfterInstall;

		public InstallFileGeneratorTasks()
		{
			Tasks = new List<InstallFileGeneratorTask>();
			TempPath = AOIPaths.TempDataPath();
			DownloadPath = AOIPaths.DownloadsPath();
			KeepDownloadAfterInstall = true;
			KeepTempFilesAfterInstall = true;
		}

		public static InstallFileGeneratorTasks CreateFromAddOnList(IEnumerable<AddOn> a)
		{
			InstallFileGeneratorTasks installFileGeneratorTasks = new InstallFileGeneratorTasks();
			string text = "Install the following Add-Ons:\r\n\r\n";
			foreach (AddOn item in a)
			{
				InstallFileGeneratorTask installFileGeneratorTask = new InstallFileGeneratorTask();
				installFileGeneratorTask.TaskType = InstallFileGeneratorTaskType.Install;
				installFileGeneratorTask.AddOn = item;
				installFileGeneratorTasks.Tasks.Add(installFileGeneratorTask);
			}
			return installFileGeneratorTasks;
		}
	}
}
