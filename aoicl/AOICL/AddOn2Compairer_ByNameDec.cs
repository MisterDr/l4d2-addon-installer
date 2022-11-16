using System.Collections.Generic;
using System.Diagnostics;

namespace AOICL
{
	public class AddOn2Compairer_ByNameDec : Comparer<AddOn2>
	{
		[DebuggerNonUserCode]
		public AddOn2Compairer_ByNameDec()
		{
		}

		public override int Compare(AddOn2 x, AddOn2 y)
		{
			return string.Compare(y.Name, x.Name, ignoreCase: true);
		}
	}
}
