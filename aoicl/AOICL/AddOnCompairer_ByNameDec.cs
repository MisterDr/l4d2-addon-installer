using System.Collections.Generic;
using System.Diagnostics;

namespace AOICL
{
	public class AddOnCompairer_ByNameDec : Comparer<AddOn>
	{
		[DebuggerNonUserCode]
		public AddOnCompairer_ByNameDec()
		{
		}

		public override int Compare(AddOn x, AddOn y)
		{
			return string.Compare(y.DisplayName, x.DisplayName, ignoreCase: true);
		}
	}
}
