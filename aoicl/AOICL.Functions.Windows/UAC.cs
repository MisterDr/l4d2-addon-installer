using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace AOICL.Functions.Windows
{
	public class UAC
	{
		[DebuggerNonUserCode]
		public UAC()
		{
		}

		public static bool IsUserAdmin()
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}

		public static void AddShieldToButton(ref Button B)
		{
			int num = 5632;
			checked
			{
				int num2 = num + 12;
				B.FlatStyle = FlatStyle.System;
				API.SendMessage(B.Handle, (uint)num2, (IntPtr)0, (IntPtr)(-1));
			}
		}
	}
}
