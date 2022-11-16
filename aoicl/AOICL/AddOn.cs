using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using AOICL.Functions.GenericFunctions;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	[Serializable]
	public class AddOn : IComparable<AddOn>
	{
		[XmlIgnore]
		private string _Title;

		[XmlIgnore]
		private string _Version;

		[XmlIgnore]
		private string _DisplayName;

		public long Size;

		public string Homepage;

		public List<AddOnDownload> Downloads;

		[XmlIgnore]
		public bool Enabled;

		[XmlIgnore]
		public bool IsUpdate;

		[XmlIgnore]
		public bool IsManaged;

		[XmlIgnore]
		private AddOnInfo _AddOnInfo;

		[XmlIgnore]
		public List<AddOn> OtherVersion;

		[XmlIgnore]
		private bool _IsInstalled;

		[XmlIgnore]
		private string _VPKFilePath;

		[XmlIgnore]
		private Version _VersionV;

		[XmlIgnore]
		private string _vpkp;

		[XmlIgnore]
		public AddOnInfo AddOnInfo
		{
			get
			{
				return _AddOnInfo;
			}
			set
			{
				_AddOnInfo = value;
			}
		}

		[XmlIgnore]
		public bool IsInstalled
		{
			get
			{
				if (_VPKFilePath == null)
				{
					return false;
				}
				return true;
			}
			set
			{
				if (!value & (Operators.CompareString(_VPKFilePath, null, TextCompare: false) != 0))
				{
					value = value;
				}
				_IsInstalled = value;
			}
		}

		public string Title
		{
			get
			{
				return _Title;
			}
			set
			{
				_Title = value;
				if (_DisplayName == null)
				{
					_DisplayName = value;
				}
			}
		}

		public string Version
		{
			get
			{
				return _Version;
			}
			set
			{
				_Version = value;
			}
		}

		public string DisplayName
		{
			get
			{
				return _DisplayName;
			}
			set
			{
				_DisplayName = value;
			}
		}

		[XmlIgnore]
		public string VpkFilePath
		{
			get
			{
				if (_vpkp == null)
				{
					foreach (AddOn item in OtherVersion)
					{
						if (Operators.CompareString(item.VpkFilePath, null, TextCompare: false) != 0)
						{
							_vpkp = item.VpkFilePath;
							return item.VpkFilePath;
						}
					}
					_vpkp = _VPKFilePath;
					return _VPKFilePath;
				}
				return _vpkp;
			}
			set
			{
				_VPKFilePath = value;
			}
		}

		[XmlIgnore]
		public string SizeS => BytesToSI.BytesToSI2(Size);

		[XmlIgnore]
		public Version VersionV
		{
			get
			{
				if ((object)_VersionV == null)
				{
					try
					{
						_VersionV = new Version(Version);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_VersionV = new Version(0, 0, 0, 0);
						ProjectData.ClearProjectError();
					}
				}
				return _VersionV;
			}
		}

		[XmlIgnore]
		public Version OnlineVersion
		{
			get
			{
				Version versionV = VersionV;
				foreach (AddOn item in OtherVersion)
				{
					if (!item.IsInstalled && item.VersionV > versionV)
					{
						versionV = item.VersionV;
					}
				}
				return versionV;
			}
		}

		[XmlIgnore]
		public Version InstalledVersion
		{
			get
			{
				Version version;
				try
				{
					version = ((!IsInstalled) ? new Version(0, 0, 0, 0) : VersionV);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					version = new Version(0, 0, 0, 0);
					ProjectData.ClearProjectError();
				}
				foreach (AddOn item in OtherVersion)
				{
					if (item.IsInstalled && item.VersionV > version)
					{
						version = item.VersionV;
					}
				}
				return version;
			}
		}

		[XmlIgnore]
		public bool IsUpdateAvailible
		{
			get
			{
				if (OnlineVersion > InstalledVersion)
				{
					return true;
				}
				return false;
			}
		}

		[XmlIgnore]
		public string Name
		{
			get
			{
				if (Operators.CompareString(DisplayName, null, TextCompare: false) == 0)
				{
					return Title;
				}
				return DisplayName;
			}
		}

		public AddOn()
		{
			_Title = null;
			_Version = null;
			_DisplayName = null;
			Size = 0L;
			Homepage = null;
			Downloads = new List<AddOnDownload>();
			Enabled = true;
			IsUpdate = false;
			IsManaged = false;
			_AddOnInfo = null;
			OtherVersion = new List<AddOn>();
			_IsInstalled = false;
			_VPKFilePath = null;
			_VersionV = null;
			_vpkp = null;
		}

		public AddOn(string Title)
			: this(Title, new Version(), Title)
		{
		}

		public AddOn(string Title, string Version)
			: this(Title, Version, Title)
		{
		}

		public AddOn(string Title, Version Version)
			: this(Title, Version, Title)
		{
		}

		public AddOn(string Title, string Version, string DisplayName)
		{
			_Title = null;
			_Version = null;
			_DisplayName = null;
			Size = 0L;
			Homepage = null;
			Downloads = new List<AddOnDownload>();
			Enabled = true;
			IsUpdate = false;
			IsManaged = false;
			_AddOnInfo = null;
			OtherVersion = new List<AddOn>();
			_IsInstalled = false;
			_VPKFilePath = null;
			_VersionV = null;
			_vpkp = null;
			_Title = Title;
			this.Version = Version;
			this.DisplayName = DisplayName;
		}

		public AddOn(string Title, Version Version, string DisplayName)
		{
			_Title = null;
			_Version = null;
			_DisplayName = null;
			Size = 0L;
			Homepage = null;
			Downloads = new List<AddOnDownload>();
			Enabled = true;
			IsUpdate = false;
			IsManaged = false;
			_AddOnInfo = null;
			OtherVersion = new List<AddOn>();
			_IsInstalled = false;
			_VPKFilePath = null;
			_VersionV = null;
			_vpkp = null;
			_Title = Title;
			this.Version = Version.ToString();
			this.DisplayName = DisplayName;
		}

		public static AddOn CreateManagedAddon(string title, string version)
		{
			AddOn addOn = new AddOn(title, version);
			addOn.IsManaged = true;
			return addOn;
		}

		public static AddOn CreateInstalledAddon(string title, string version)
		{
			AddOn addOn = new AddOn(title, version);
			addOn.IsInstalled = true;
			return addOn;
		}

		public static AddOn CreateAddOnFromAddOnInfo(AddOnInfo ai)
		{
			AddOn addOn = new AddOn(ai.Title, ai.Version);
			addOn.AddOnInfo = ai;
			addOn.IsInstalled = true;
			addOn.IsManaged = false;
			addOn.VpkFilePath = ai.VPKFilePath;
			return addOn;
		}

		public int CompareTo(AddOn other)
		{
			int result = default(int);
			return result;
		}

		int IComparable<AddOn>.CompareTo(AddOn other)
		{
			//ILSpy generated this explicit interface implementation from .override directive in CompareTo
			return this.CompareTo(other);
		}
	}
}
