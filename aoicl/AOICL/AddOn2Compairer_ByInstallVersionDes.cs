using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AOICL
{
	public class AddOn2Compairer_ByInstallVersionDes : Comparer<AddOn2>
	{
		[DebuggerNonUserCode]
		public AddOn2Compairer_ByInstallVersionDes()
		{
		}

		public override int Compare(AddOn2 x, AddOn2 y)
		{
			int result = 0;
			Version latestInstalledVersion = y.LatestInstalledVersion;
			if (latestInstalledVersion > x.LatestInstalledVersion)
			{
				result = -1;
			}
			else if (latestInstalledVersion < x.LatestInstalledVersion)
			{
				result = 1;
			}
			else if (latestInstalledVersion == x.LatestInstalledVersion)
			{
				result = 0;
			}
			return result;
		}
	}
}
