using System;

namespace AOICL
{
	[Serializable]
	public class InstallFileGeneratorTask
	{
		public InstallFileGeneratorTaskType TaskType;

		public AddOn AddOn;

		public InstallFileGeneratorTaskStatus Status;

		public InstallFileGeneratorTask()
		{
			TaskType = InstallFileGeneratorTaskType.Install;
			Status = InstallFileGeneratorTaskStatus.Ready;
		}
	}
}
