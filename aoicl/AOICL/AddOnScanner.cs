using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using AOICL.Functions.Left4Dead2;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class AddOnScanner
	{
		[DebuggerNonUserCode]
		public AddOnScanner()
		{
		}

		public static IEnumerable<AddOn> GetAddOnsFromAddOnFolder(string AddOnFolder)
		{
			return from o in Left4Dead2Functions.ScanForAddons(AddOnFolder)
				select AddOn.CreateAddOnFromAddOnInfo(o);
		}

		public static CAddOns GetAddOnsFromXMLFile(string XMLFilePath)
		{
			CAddOns addOns = new CAddOns();
			try
			{
				Stream stream = File.OpenRead(XMLFilePath);
				XmlSerializer xmlSerializer = new XmlSerializer(addOns.GetType());
				addOns = (CAddOns)xmlSerializer.Deserialize(stream);
				foreach (AddOn addOn in addOns.AddOns)
				{
					addOn.IsManaged = true;
				}
				stream.Close();
				return addOns;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return addOns;
			}
		}
	}
}
