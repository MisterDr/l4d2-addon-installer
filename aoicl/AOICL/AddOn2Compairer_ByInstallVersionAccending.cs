using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AOICL
{
	public class AddOn2Compairer_ByInstallVersionAccending : Comparer<AddOn2>
	{
		[DebuggerNonUserCode]
		public AddOn2Compairer_ByInstallVersionAccending()
		{
		}

		public override int Compare(AddOn2 x, AddOn2 y)
		{
			int result = 0;
			Version latestInstalledVersion = x.LatestInstalledVersion;
			if (latestInstalledVersion > y.LatestInstalledVersion)
			{
				result = -1;
			}
			else if (latestInstalledVersion < y.LatestInstalledVersion)
			{
				result = 1;
			}
			else if (latestInstalledVersion == y.LatestInstalledVersion)
			{
				result = 0;
			}
			return result;
		}
	}
}
