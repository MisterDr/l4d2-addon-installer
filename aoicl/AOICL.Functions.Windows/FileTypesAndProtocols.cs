using System.Diagnostics;
using Microsoft.Win32;

namespace AOICL.Functions.Windows
{
	public class FileTypesAndProtocols
	{
		[DebuggerNonUserCode]
		public FileTypesAndProtocols()
		{
		}

		public static void RegisterURLProtocol(string pn, string exepath, bool force = true)
		{
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(pn, writable: true);
			if (force || registryKey == null)
			{
				registryKey = Registry.ClassesRoot.CreateSubKey(pn);
				registryKey.SetValue("", "URL:" + pn + " Protocol");
				registryKey.SetValue("URL Protocol", "");
				registryKey = registryKey.CreateSubKey("shell\\open\\command");
				registryKey.SetValue("", "\"" + exepath + "\" -protocol=%1");
			}
			registryKey?.Close();
		}
	}
}
