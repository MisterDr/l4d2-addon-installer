using System;
using System.IO;
using System.Xml.Serialization;

namespace AOICL
{
	[Serializable]
	public class AddOnDownload
	{
		private string _URL;

		private string _MD5;

		private long _Size;

		public string URL
		{
			get
			{
				return _URL;
			}
			set
			{
				_URL = value;
			}
		}

		public string MD5
		{
			get
			{
				return _MD5;
			}
			set
			{
				_MD5 = value;
			}
		}

		public long Size
		{
			get
			{
				return _Size;
			}
			set
			{
				_Size = value;
			}
		}

		[XmlIgnore]
		public bool IsLocal
		{
			get
			{
				if (File.Exists(_URL) | Directory.Exists(_URL))
				{
					return true;
				}
				return false;
			}
		}

		[XmlIgnore]
		public bool IsFile
		{
			get
			{
				if (File.Exists(_URL))
				{
					return true;
				}
				return false;
			}
		}

		[XmlIgnore]
		public bool IsFolder
		{
			get
			{
				if (Directory.Exists(_URL))
				{
					return true;
				}
				return false;
			}
		}

		public AddOnDownload()
		{
			_URL = null;
			_MD5 = null;
			_Size = 0L;
		}

		public AddOnDownload(string URL)
		{
			_URL = null;
			_MD5 = null;
			_Size = 0L;
			_URL = URL;
		}

		public AddOnDownload(string URL, string MD5)
		{
			_URL = null;
			_MD5 = null;
			_Size = 0L;
			_URL = URL;
			_MD5 = MD5;
		}

		public AddOnDownload(string URL, string MD5, long DownloadSize)
		{
			_URL = null;
			_MD5 = null;
			_Size = 0L;
			_URL = URL;
			_MD5 = MD5;
			_Size = DownloadSize;
		}

		public Uri ToURI()
		{
			return new Uri(URL);
		}
	}
}
