using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class AddOn2
	{
		public string _Name;

		private List<AddOn> _AddOnList;

		private bool _IsManaged;

		private bool _IsInstalled;

		private Version _AddOnVersionLatestOnline;

		private Version _AddOnVersionLatestInstalled;

		private AddOn _AddOnLatestOnline;

		public IEnumerable<AddOn> AddOnListAll => _AddOnList;

		public IEnumerable<AddOn> AddOnListInstalled => _AddOnList.Where((AddOn o) => o.IsInstalled);

		public IEnumerable<AddOn> AddOnListManaged => _AddOnList.Where((AddOn o) => o.IsManaged);

		public string[] Titles => AddOnListAll.Select((AddOn o) => o.Title).ToArray();

		public string Name
		{
			get
			{
				return _Name;
			}
			set
			{
				_Name = value;
			}
		}

		public bool IsInstalled => _IsInstalled;

		public bool IsManaged => _IsManaged;

		public AddOn GetLatestOnlineVersion
		{
			get
			{
				if (_AddOnLatestOnline == null)
				{
					SetLatestOnlineVersion();
				}
				return _AddOnLatestOnline;
			}
		}

		public Version LatestOnlineVersion
		{
			get
			{
				if ((object)_AddOnVersionLatestOnline == null)
				{
					SetLatestOnlineVersion();
				}
				return _AddOnVersionLatestOnline;
			}
		}

		public Version LatestInstalledVersion
		{
			get
			{
				if ((object)_AddOnVersionLatestInstalled == null)
				{
					Version version = new Version(0, 0, 0, 0);
					foreach (Version item in AddOnListInstalled.Select((AddOn o) => o.VersionV))
					{
						if (item > version)
						{
							version = item;
						}
					}
					_AddOnVersionLatestInstalled = version;
				}
				return _AddOnVersionLatestInstalled;
			}
		}

		public AddOn2()
		{
			_AddOnList = new List<AddOn>();
			_IsManaged = false;
			_IsInstalled = false;
			_AddOnVersionLatestOnline = null;
			_AddOnVersionLatestInstalled = null;
			_AddOnLatestOnline = null;
		}

		public void Add(AddOn a)
		{
			_AddOnList.Add(a);
			_AddOnVersionLatestOnline = null;
			_AddOnVersionLatestInstalled = null;
			_AddOnLatestOnline = null;
			SetLatestOnlineVersion();
			if (a.IsManaged)
			{
				_IsManaged = true;
			}
			if (a.IsInstalled)
			{
				_IsInstalled = true;
			}
		}

		private void SetLatestOnlineVersion()
		{
			Version version = new Version(0, 0, 0, 0);
			foreach (AddOn item in AddOnListManaged.Select((AddOn o) => o))
			{
				if (item.VersionV > version)
				{
					_AddOnLatestOnline = item;
					_AddOnVersionLatestOnline = item.VersionV;
					version = item.VersionV;
				}
			}
		}

		public bool ContainsName(string d)
		{
			IEnumerable<AddOn> source = AddOnListAll.Where((AddOn o) => Operators.CompareString(o.Name, d, TextCompare: false) == 0);
			if (source.Count() > 0)
			{
				return true;
			}
			return false;
		}
	}
}
