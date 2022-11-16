using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AOICL
{
	public class AddOn2Compairer_ByOnlineVersionDes : Comparer<AddOn2>
	{
		[DebuggerNonUserCode]
		public AddOn2Compairer_ByOnlineVersionDes()
		{
		}

		public override int Compare(AddOn2 x, AddOn2 y)
		{
			int result = 0;
			Version latestOnlineVersion = y.LatestOnlineVersion;
			if (latestOnlineVersion > x.LatestOnlineVersion)
			{
				result = -1;
			}
			else if (latestOnlineVersion < x.LatestOnlineVersion)
			{
				result = 1;
			}
			else if (latestOnlineVersion == x.LatestOnlineVersion)
			{
				result = 0;
			}
			return result;
		}
	}
}
