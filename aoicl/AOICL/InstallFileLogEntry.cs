using System;
using System.Diagnostics;

namespace AOICL
{
	[Serializable]
	public class InstallFileLogEntry
	{
		public DateTime EntryDateTime;

		public string EntryTitle;

		public string Entry;

		[DebuggerNonUserCode]
		public InstallFileLogEntry()
		{
		}
	}
}
