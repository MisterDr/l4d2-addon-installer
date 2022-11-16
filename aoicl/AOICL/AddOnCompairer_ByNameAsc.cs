using System.Collections.Generic;
using System.Diagnostics;

namespace AOICL
{
	public class AddOnCompairer_ByNameAsc : Comparer<AddOn>
	{
		[DebuggerNonUserCode]
		public AddOnCompairer_ByNameAsc()
		{
		}

		public override int Compare(AddOn x, AddOn y)
		{
			return string.Compare(x.DisplayName, y.DisplayName, ignoreCase: true);
		}
	}
}
