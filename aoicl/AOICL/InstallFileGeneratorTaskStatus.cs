using System;

namespace AOICL
{
	[Serializable]
	public enum InstallFileGeneratorTaskStatus
	{
		Ready,
		Running,
		Complete,
		Error,
		Unknown
	}
}
