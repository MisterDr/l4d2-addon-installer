using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL.Functions.Left4Dead2
{
	public class Left4Dead2Functions
	{
		[DebuggerNonUserCode]
		public Left4Dead2Functions()
		{
		}

		public static List<AddOnInfo> ScanForAddons(string path)
		{
			List<AddOnInfo> list = new List<AddOnInfo>();
			if (Directory.Exists(path))
			{
				string[] files = Directory.GetFiles(path, "*.vpk");
				string[] array = files;
				foreach (string vpkpath in array)
				{
					try
					{
						list.Add((AddOnInfo)AddOnInfoFromVPK(vpkpath));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Interaction.MsgBox(ex2.ToString());
						ProjectData.ClearProjectError();
					}
				}
			}
			else
			{
				Interaction.MsgBox("Cannot find addons directory! Please check your Left 4 Dead 2 install path is set correctly (Tools > Options).", MsgBoxStyle.Critical, "Cannot find add-ons directory");
			}
			return list;
		}

		public static object AddOnInfoFromVPK(string vpkpath)
		{
			try
			{
				string text = null;
				VPK vPK = new VPK(vpkpath);
				AddOnInfo addonInfo = vPK.GetAddonInfo();
				vPK = null;
				string tags = addonInfo.Tags;
				return addonInfo;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				object result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
