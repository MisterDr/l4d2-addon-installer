using System;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL.Branding
{
	[Serializable]
	public class Banner
	{
		[XmlAttribute("img")]
		public string _ImageURL;

		[XmlAttribute("href")]
		public string _LinkURL;

		[XmlAttribute("timeout")]
		public int _TimeOut;

		[XmlAttribute("validuntil")]
		public long _ValidUntil;

		[XmlIgnore]
		private MemoryStream objImage;

		[XmlIgnore]
		public MemoryStream ImageStream
		{
			get
			{
				if (objImage == null)
				{
					string text = Strings.Trim(_ImageURL);
					try
					{
						if (!text.ToLower().StartsWith("http://"))
						{
							text = "http://" + text;
						}
						WebClient webClient = new WebClient();
						objImage = new MemoryStream(webClient.DownloadData(text));
						webClient.Dispose();
						GC.Collect();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				return objImage;
			}
		}

		public Banner()
		{
			_ImageURL = "";
			_LinkURL = "";
			_TimeOut = 30;
			_ValidUntil = -1L;
			objImage = null;
			objImage = null;
		}

		public Banner(string ImageURL, string LinkURL)
		{
			_ImageURL = "";
			_LinkURL = "";
			_TimeOut = 30;
			_ValidUntil = -1L;
			objImage = null;
			_ImageURL = ImageURL;
			_LinkURL = LinkURL;
			objImage = null;
		}

		public Banner(string ImageURL, string LinkURL, int TimeOut)
		{
			_ImageURL = "";
			_LinkURL = "";
			_TimeOut = 30;
			_ValidUntil = -1L;
			objImage = null;
			_ImageURL = ImageURL;
			_LinkURL = LinkURL;
			_TimeOut = TimeOut;
			objImage = null;
		}

		public Banner(string ImageURL, string LinkURL, int TimeOut, long ValidUntil)
		{
			_ImageURL = "";
			_LinkURL = "";
			_TimeOut = 30;
			_ValidUntil = -1L;
			objImage = null;
			_ImageURL = ImageURL;
			_LinkURL = LinkURL;
			_TimeOut = TimeOut;
			_ValidUntil = ValidUntil;
			objImage = null;
		}
	}
}
