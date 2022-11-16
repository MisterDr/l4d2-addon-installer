using System;
using System.Collections.Generic;

namespace AOICL
{
	[Serializable]
	public class AvailibleAddon
	{
		public string Title;

		public string Version;

		public string URL;

		public bool IsInstalled;

		public bool IsUpdated;

		public List<string> Downloads;

		public AvailibleAddon()
		{
			Downloads = new List<string>();
		}
	}
}
