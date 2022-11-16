using System.Collections.Generic;
using System.Diagnostics;

namespace AOICL
{
	public class AddOn2Compairer_ByNameAccending : Comparer<AddOn2>
	{
		[DebuggerNonUserCode]
		public AddOn2Compairer_ByNameAccending()
		{
		}

		public override int Compare(AddOn2 x, AddOn2 y)
		{
			return string.Compare(x.Name, y.Name, ignoreCase: true);
		}
	}
}
