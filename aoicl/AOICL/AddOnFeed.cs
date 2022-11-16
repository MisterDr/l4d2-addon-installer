using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	[Serializable]
	public class AddOnFeed
	{
		public string URL;

		public bool Cached;

		public DateTime LastCache;

		public bool Enabled;

		public string FeedID;

		public IEnumerable<AddOn> GetAddOns
		{
			get
			{
				CAddOns addOns = new CAddOns();
				try
				{
					CAddOns addOns2 = new CAddOns();
					if (!File.Exists(Path.Combine(AOIPaths.FeedsPath(), FeedID + ".xml")))
					{
						return addOns.AddOns.ToList();
					}
					XmlTextReader xmlTextReader = new XmlTextReader(Path.Combine(AOIPaths.FeedsPath(), FeedID + ".xml"));
					XmlSerializer xmlSerializer = new XmlSerializer(addOns2.GetType());
					addOns2 = (CAddOns)xmlSerializer.Deserialize(xmlTextReader);
					foreach (AddOn addOn in addOns2.AddOns)
					{
						addOn.IsManaged = true;
						addOn.IsInstalled = false;
						addOns.AddAddon(addOn);
					}
					xmlTextReader.Close();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				return addOns.AddOns.ToList();
			}
		}

		public AddOnFeed()
		{
			Cached = true;
			LastCache = DateAndTime.Now;
			Enabled = true;
			FeedID = Guid.NewGuid().ToString();
		}

		public void Cache()
		{
			CAddOns addOns = new CAddOns();
			try
			{
				CAddOns addOns2 = new CAddOns();
				XmlTextReader xmlTextReader = new XmlTextReader(URL);
				XmlSerializer xmlSerializer = new XmlSerializer(addOns2.GetType());
				addOns2 = (CAddOns)xmlSerializer.Deserialize(xmlTextReader);
				foreach (AddOn addOn in addOns2.AddOns)
				{
					addOn.IsManaged = true;
					addOn.IsInstalled = false;
					addOns.AddAddon(addOn);
				}
				xmlTextReader.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				StreamWriter streamWriter = new StreamWriter(Path.Combine(AOIPaths.FeedsPath(), FeedID + ".xml"));
				XmlSerializer xmlSerializer2 = new XmlSerializer(addOns.GetType());
				xmlSerializer2.Serialize(streamWriter, addOns);
				streamWriter.Close();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
	}
}
