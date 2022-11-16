using System.Diagnostics;
using System.Windows.Forms;

namespace AOICL
{
	public class ControlDelegates
	{
		public delegate void RefreshListViewDelegate(ref ListView lv);

		[DebuggerNonUserCode]
		public ControlDelegates()
		{
		}

		public static void RefreshListView(ref ListView lv)
		{
			if (lv.InvokeRequired)
			{
				lv.Invoke(new RefreshListViewDelegate(RefreshListView), lv);
			}
			else
			{
				lv.Refresh();
			}
		}
	}
}
