using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AOICL
{
	public class AddOn2Compairer_ByOnlineVersionAccending : Comparer<AddOn2>
	{
		[DebuggerNonUserCode]
		public AddOn2Compairer_ByOnlineVersionAccending()
		{
		}

		public override int Compare(AddOn2 x, AddOn2 y)
		{
			int result = 0;
			Version latestOnlineVersion = x.LatestOnlineVersion;
			if (latestOnlineVersion > y.LatestOnlineVersion)
			{
				result = -1;
			}
			else if (latestOnlineVersion < y.LatestOnlineVersion)
			{
				result = 1;
			}
			else if (latestOnlineVersion == y.LatestOnlineVersion)
			{
				result = 0;
			}
			return result;
		}
	}
}
