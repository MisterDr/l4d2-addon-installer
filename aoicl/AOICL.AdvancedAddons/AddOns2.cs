using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL.AdvancedAddons
{
	public class AddOns2 : List<AddOn2>
	{
		private IEnumerable<AddOn2> _InstalledAddOn2s;

		private IEnumerable<AddOn> _AvailibleAddOn2s;

		private IEnumerable<AddOn> _AddOnsAll;

		[SpecialName]
		private bool _0024STATIC_0024SortInstalledAddOnsByName_00242001_0024sorta;

		[SpecialName]
		private bool _0024STATIC_0024SortInstalledAddOnsByLatestInstalledVersion_00242001_0024sorta;

		[SpecialName]
		private bool _0024STATIC_0024SortInstalledAddOnsByLatestOnlineVersion_00242001_0024sorta;

		[SpecialName]
		private StaticLocalInitFlag _0024STATIC_0024SortInstalledAddOnsByName_00242001_0024sorta_0024Init;

		[SpecialName]
		private StaticLocalInitFlag _0024STATIC_0024SortInstalledAddOnsByLatestInstalledVersion_00242001_0024sorta_0024Init;

		[SpecialName]
		private StaticLocalInitFlag _0024STATIC_0024SortInstalledAddOnsByLatestOnlineVersion_00242001_0024sorta_0024Init;

		public IEnumerable<AddOn> AddOnsInstalled
		{
			get
			{
				List<AddOn> list = new List<AddOn>();
				if (_InstalledAddOn2s == null)
				{
					_InstalledAddOn2s = (from o in this
						where o.IsInstalled
						select (o)).ToList();
				}
				foreach (AddOn2 item in from o in _InstalledAddOn2s
					where o.IsInstalled
					select (o))
				{
					foreach (AddOn item2 in item.AddOnListInstalled.Select((AddOn o) => o))
					{
						list.Add(item2);
					}
				}
				return list;
			}
		}

		public IEnumerable<AddOn> AddOnsAvailible(bool OnlyReturnLatestVersion)
		{
			if (_AvailibleAddOn2s == null)
			{
				List<AddOn> list = new List<AddOn>();
				using (Enumerator enumerator = GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						AddOn2 current = enumerator.Current;
						if (!current.IsManaged)
						{
							continue;
						}
						if (OnlyReturnLatestVersion)
						{
							list.Add(current.GetLatestOnlineVersion);
							continue;
						}
						foreach (AddOn item in current.AddOnListAll)
						{
							if (item.IsManaged)
							{
								list.Add(item);
							}
						}
					}
				}
				_AvailibleAddOn2s = list.ToList();
			}
			return _AvailibleAddOn2s;
		}

		public IEnumerable<AddOn> AddOnsAll
		{
			get
			{
				if (_AddOnsAll == null)
				{
					List<AddOn> list = new List<AddOn>();
					using (Enumerator enumerator = GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							AddOn2 current = enumerator.Current;
							foreach (AddOn item in current.AddOnListAll)
							{
								list.Add(item);
							}
						}
					}
					_AddOnsAll = list.ToList();
				}
				return _AddOnsAll;
			}
		}

		// public AddOn2 GetAddOn2ByTitle => GetAddOnByTitle(d);

		public AddOns2()
		{
			_InstalledAddOn2s = null;
			_AvailibleAddOn2s = null;
			_AddOnsAll = null;
			_0024STATIC_0024SortInstalledAddOnsByName_00242001_0024sorta_0024Init = new StaticLocalInitFlag();
			_0024STATIC_0024SortInstalledAddOnsByLatestInstalledVersion_00242001_0024sorta_0024Init = new StaticLocalInitFlag();
			_0024STATIC_0024SortInstalledAddOnsByLatestOnlineVersion_00242001_0024sorta_0024Init = new StaticLocalInitFlag();
		}

		private bool HasEntryByVPKPath(string p)
		{
			using (Enumerator enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					AddOn2 current = enumerator.Current;
					foreach (AddOn item in current.AddOnListInstalled)
					{
						if ((Operators.CompareString(Strings.LCase(item.VpkFilePath), Strings.LCase(p), TextCompare: false) == 0) & item.IsInstalled)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		public new void Add(AddOn2 x)
		{
			base.Add(x);
		}

		public void Add(AddOn x)
		{
			lock (this)
			{
				InvalidateCache();
				using (Enumerator enumerator = GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						AddOn2 current = enumerator.Current;
						if ((Operators.CompareString(Strings.LCase(current.Name), Strings.LCase(x.Title), TextCompare: false) == 0) | (Operators.CompareString(Strings.LCase(current.Name), Strings.LCase(x.DisplayName), TextCompare: false) == 0))
						{
							current.Add(x);
							return;
						}
						if (HasEntryByVPKPath(x.VpkFilePath))
						{
							return;
						}
						string[] titles = current.Titles;
						foreach (string value in titles)
						{
							if (Operators.CompareString(Strings.LCase(value), Strings.LCase(x.Title), TextCompare: false) == 0)
							{
								current.Add(x);
								return;
							}
						}
					}
				}
				AddOn2 addOn = new AddOn2();
				addOn.Name = x.Name;
				addOn.Add(x);
				Add(addOn);
			}
		}

		private void InvalidateCache()
		{
			_InstalledAddOn2s = null;
			_AvailibleAddOn2s = null;
			_AddOnsAll = null;
			GC.Collect();
		}

		public void SortInstalledAddOns(AddOn2SortOrder SortOrder)
		{
			switch (SortOrder)
			{
			case AddOn2SortOrder.Name_ASC:
				Sort(new AddOn2Compairer_ByNameAccending());
				InvalidateCache();
				break;
			case AddOn2SortOrder.Name_DEC:
				Sort(new AddOn2Compairer_ByNameDec());
				InvalidateCache();
				break;
			case AddOn2SortOrder.VersionInstalled_ASC:
				_InstalledAddOn2s = _InstalledAddOn2s.OrderBy((AddOn2 m) => m, new AddOn2Compairer_ByInstallVersionAccending());
				break;
			case AddOn2SortOrder.VersionInstalled_DEC:
				_InstalledAddOn2s = _InstalledAddOn2s.OrderBy((AddOn2 m) => m, new AddOn2Compairer_ByInstallVersionDes());
				break;
			case AddOn2SortOrder.VersionOnline_ASC:
				_InstalledAddOn2s = _InstalledAddOn2s.OrderBy((AddOn2 m) => m, new AddOn2Compairer_ByOnlineVersionAccending());
				break;
			case AddOn2SortOrder.VersionOnline_DEC:
				_InstalledAddOn2s = _InstalledAddOn2s.OrderBy((AddOn2 m) => m, new AddOn2Compairer_ByOnlineVersionDes());
				break;
			}
		}

		public void SortInstalledAddOnsByName()
		{
			Monitor.Enter(_0024STATIC_0024SortInstalledAddOnsByName_00242001_0024sorta_0024Init);
			try
			{
				if (_0024STATIC_0024SortInstalledAddOnsByName_00242001_0024sorta_0024Init.State == 0)
				{
					_0024STATIC_0024SortInstalledAddOnsByName_00242001_0024sorta_0024Init.State = 2;
					_0024STATIC_0024SortInstalledAddOnsByName_00242001_0024sorta = true;
				}
				else if (_0024STATIC_0024SortInstalledAddOnsByName_00242001_0024sorta_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				_0024STATIC_0024SortInstalledAddOnsByName_00242001_0024sorta_0024Init.State = 1;
				Monitor.Exit(_0024STATIC_0024SortInstalledAddOnsByName_00242001_0024sorta_0024Init);
			}
			if (_0024STATIC_0024SortInstalledAddOnsByName_00242001_0024sorta)
			{
				Sort(new AddOn2Compairer_ByNameAccending());
			}
			else
			{
				Sort(new AddOn2Compairer_ByNameDec());
			}
			InvalidateCache();
			_0024STATIC_0024SortInstalledAddOnsByName_00242001_0024sorta = !_0024STATIC_0024SortInstalledAddOnsByName_00242001_0024sorta;
		}

		public void SortInstalledAddOnsByLatestInstalledVersion()
		{
			Monitor.Enter(_0024STATIC_0024SortInstalledAddOnsByLatestInstalledVersion_00242001_0024sorta_0024Init);
			try
			{
				if (_0024STATIC_0024SortInstalledAddOnsByLatestInstalledVersion_00242001_0024sorta_0024Init.State == 0)
				{
					_0024STATIC_0024SortInstalledAddOnsByLatestInstalledVersion_00242001_0024sorta_0024Init.State = 2;
					_0024STATIC_0024SortInstalledAddOnsByLatestInstalledVersion_00242001_0024sorta = true;
				}
				else if (_0024STATIC_0024SortInstalledAddOnsByLatestInstalledVersion_00242001_0024sorta_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				_0024STATIC_0024SortInstalledAddOnsByLatestInstalledVersion_00242001_0024sorta_0024Init.State = 1;
				Monitor.Exit(_0024STATIC_0024SortInstalledAddOnsByLatestInstalledVersion_00242001_0024sorta_0024Init);
			}
			if (_0024STATIC_0024SortInstalledAddOnsByLatestInstalledVersion_00242001_0024sorta)
			{
				_InstalledAddOn2s = _InstalledAddOn2s.OrderBy((AddOn2 m) => m, new AddOn2Compairer_ByInstallVersionAccending());
			}
			else
			{
				_InstalledAddOn2s = _InstalledAddOn2s.OrderBy((AddOn2 m) => m, new AddOn2Compairer_ByInstallVersionDes());
			}
			_0024STATIC_0024SortInstalledAddOnsByLatestInstalledVersion_00242001_0024sorta = !_0024STATIC_0024SortInstalledAddOnsByLatestInstalledVersion_00242001_0024sorta;
		}

		public void SortInstalledAddOnsByLatestOnlineVersion()
		{
			Monitor.Enter(_0024STATIC_0024SortInstalledAddOnsByLatestOnlineVersion_00242001_0024sorta_0024Init);
			try
			{
				if (_0024STATIC_0024SortInstalledAddOnsByLatestOnlineVersion_00242001_0024sorta_0024Init.State == 0)
				{
					_0024STATIC_0024SortInstalledAddOnsByLatestOnlineVersion_00242001_0024sorta_0024Init.State = 2;
					_0024STATIC_0024SortInstalledAddOnsByLatestOnlineVersion_00242001_0024sorta = true;
				}
				else if (_0024STATIC_0024SortInstalledAddOnsByLatestOnlineVersion_00242001_0024sorta_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				_0024STATIC_0024SortInstalledAddOnsByLatestOnlineVersion_00242001_0024sorta_0024Init.State = 1;
				Monitor.Exit(_0024STATIC_0024SortInstalledAddOnsByLatestOnlineVersion_00242001_0024sorta_0024Init);
			}
			if (_0024STATIC_0024SortInstalledAddOnsByLatestOnlineVersion_00242001_0024sorta)
			{
				_InstalledAddOn2s = _InstalledAddOn2s.OrderBy((AddOn2 m) => m, new AddOn2Compairer_ByOnlineVersionAccending());
			}
			else
			{
				_InstalledAddOn2s = _InstalledAddOn2s.OrderBy((AddOn2 m) => m, new AddOn2Compairer_ByOnlineVersionDes());
			}
			_0024STATIC_0024SortInstalledAddOnsByLatestOnlineVersion_00242001_0024sorta = !_0024STATIC_0024SortInstalledAddOnsByLatestOnlineVersion_00242001_0024sorta;
		}

		public AddOn2 GetAddOnByTitle(string d)
		{
			try
			{
				AddOn2 addOn = (from o in this
					where o.ContainsName(d)
					select (o)).First();
				if (addOn == null)
				{
					return null;
				}
				return addOn;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				AddOn2 result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public object GetAddOn2ByName(string n)
		{
			using (Enumerator enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					AddOn2 current = enumerator.Current;
					foreach (AddOn item in current.AddOnListAll)
					{
						if (Operators.CompareString(Strings.LCase(item.Title), Strings.LCase(n), TextCompare: false) == 0)
						{
							return current;
						}
					}
				}
			}
			return null;
		}
	}
}
