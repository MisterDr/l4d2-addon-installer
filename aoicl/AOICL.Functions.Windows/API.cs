using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AOICL.Functions.Windows
{
	public class API
	{
		[DebuggerNonUserCode]
		public API()
		{
		}

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern long SetForegroundWindow(long hWnd);
	}
}
