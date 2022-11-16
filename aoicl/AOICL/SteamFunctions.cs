using System;
using System.Diagnostics;
using AOICL.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace AOICL
{
	public class SteamFunctions
	{
		[DebuggerNonUserCode]
		public SteamFunctions()
		{
		}

		public static string SteamPathFromRegistry()
		{
			string result = null;
			try
			{
				RegistryKey currentUser = MyProject.Computer.Registry.CurrentUser;
				RegistryKey registryKey = currentUser.OpenSubKey("Software");
				RegistryKey registryKey2 = registryKey.OpenSubKey("valve");
				RegistryKey registryKey3 = registryKey2.OpenSubKey("steam");
				string[] valueNames = registryKey3.GetValueNames();
				result = Conversions.ToString(registryKey3.GetValue("steampath"));
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
