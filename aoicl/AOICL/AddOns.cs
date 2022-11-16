using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;
using AOICL.AdvancedAddons;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	[Serializable, XmlRoot("AddOns")]
	public class CAddOns
	{
		public delegate void ListChangingEventHandler();

		public delegate void ListChangedEventHandler();

		public List<AddOn> AddOns;

		[AccessedThroughProperty("AdvancedAddOns")]
		[XmlIgnore]
		private AddOns2 _AdvancedAddOns;

		[XmlIgnore]
		private IEnumerable<AddOn> _CacheGetInstalledAddOns;

		[XmlIgnore]
		private IEnumerable<AddOn> _CacheGetManagedAddOns;

		[XmlIgnore]
		private IEnumerable<AddOn> _CacheGetAvailibledAddOns;

		private ListChangingEventHandler ListChangingEvent;

		private ListChangedEventHandler ListChangedEvent;

		[SpecialName]
		private bool _0024STATIC_0024SorttAvailibledAddOns_00242001_0024SortAsc;

		[SpecialName]
		private StaticLocalInitFlag _0024STATIC_0024SorttAvailibledAddOns_00242001_0024SortAsc_0024Init;

		public virtual AddOns2 AdvancedAddOns
		{
			[DebuggerNonUserCode]
			get
			{
				return _AdvancedAddOns;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_AdvancedAddOns = value;
			}
		}

		[XmlIgnore]
		public IEnumerable<AddOn> GetInstalledAddOns => AdvancedAddOns.AddOnsInstalled;

		// [XmlIgnore]
		public string GetAddOnName(string title)
		{
			IEnumerable<AddOn> enumerable = from o in AdvancedAddOns.AddOnsAll
				where Operators.CompareString(Strings.LCase(title), Strings.LCase(o.Title), TextCompare: false) == 0
				select (o);
			if (enumerable.Count() < 2)
			{
				return title;
			}
			foreach (AddOn item in enumerable)
			{
				if (item.IsManaged)
				{
					return item.DisplayName;
				}
			}
			return title;
		}

		[XmlIgnore]
		public IEnumerable<AddOn> GetYourAddOns => from o in AdvancedAddOns.AddOnsAll
			where o.IsInstalled & IsManaged(o.Title)
			select (o);

		[XmlIgnore]
		public IEnumerable<AddOn> GetManagedAddOns
		{
			get
			{
				if (_CacheGetManagedAddOns == null)
				{
					_CacheGetManagedAddOns = (from o in AdvancedAddOns.AddOnsAll
						where o.IsManaged
						select (o)).ToList();
				}
				return _CacheGetManagedAddOns;
			}
		}

		[XmlIgnore]
		public IEnumerable<AddOn> GetAvailibleAddOns
		{
			get
			{
				if (_CacheGetAvailibledAddOns == null)
				{
					_CacheGetAvailibledAddOns = (from ola in GetManagedAddOns.OrderByDescending((AddOn a) => a.VersionV).GroupBy((AddOn a) => Strings.LCase(a.Name))
						select ola.First()).ToList();
				}
				return _CacheGetAvailibledAddOns;
			}
		}

		public event ListChangingEventHandler ListChanging
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				ListChangingEvent = (ListChangingEventHandler)Delegate.Combine(ListChangingEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				ListChangingEvent = (ListChangingEventHandler)Delegate.Remove(ListChangingEvent, value);
			}
		}

		public event ListChangedEventHandler ListChanged
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				ListChangedEvent = (ListChangedEventHandler)Delegate.Combine(ListChangedEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				ListChangedEvent = (ListChangedEventHandler)Delegate.Remove(ListChangedEvent, value);
			}
		}

		public CAddOns()
		{
			AddOns = new List<AddOn>();
			AdvancedAddOns = new AddOns2();
			_CacheGetAvailibledAddOns = null;
			_0024STATIC_0024SorttAvailibledAddOns_00242001_0024SortAsc_0024Init = new StaticLocalInitFlag();
		}

		public void InvalidDateLINQCache()
		{
			_CacheGetInstalledAddOns = null;
			_CacheGetManagedAddOns = null;
			_CacheGetAvailibledAddOns = null;
		}

		public void SorttAvailibledAddOns()
		{
			Monitor.Enter(_0024STATIC_0024SorttAvailibledAddOns_00242001_0024SortAsc_0024Init);
			try
			{
				if (_0024STATIC_0024SorttAvailibledAddOns_00242001_0024SortAsc_0024Init.State == 0)
				{
					_0024STATIC_0024SorttAvailibledAddOns_00242001_0024SortAsc_0024Init.State = 2;
					_0024STATIC_0024SorttAvailibledAddOns_00242001_0024SortAsc = true;
				}
				else if (_0024STATIC_0024SorttAvailibledAddOns_00242001_0024SortAsc_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				_0024STATIC_0024SorttAvailibledAddOns_00242001_0024SortAsc_0024Init.State = 1;
				Monitor.Exit(_0024STATIC_0024SorttAvailibledAddOns_00242001_0024SortAsc_0024Init);
			}
			if (_CacheGetAvailibledAddOns == null)
			{
				_CacheGetAvailibledAddOns = GetAvailibleAddOns;
			}
			if (_0024STATIC_0024SorttAvailibledAddOns_00242001_0024SortAsc)
			{
				_CacheGetAvailibledAddOns = _CacheGetAvailibledAddOns.OrderBy((AddOn m) => m, new AddOnCompairer_ByNameAsc());
			}
			else
			{
				_CacheGetAvailibledAddOns = _CacheGetAvailibledAddOns.OrderBy((AddOn m) => m, new AddOnCompairer_ByNameDec());
			}
			_0024STATIC_0024SorttAvailibledAddOns_00242001_0024SortAsc = !_0024STATIC_0024SorttAvailibledAddOns_00242001_0024SortAsc;
		}

		public bool IsInstalled(string addonTitle)
		{
			IEnumerable<AddOn> source = from o in GetInstalledAddOns
				where Operators.CompareString(Strings.LCase(o.Title), Strings.LCase(addonTitle), TextCompare: false) == 0
				select (o);
			if (source.Count() == 0)
			{
				return false;
			}
			return true;
		}

		public bool IsManaged(string addonTitle)
		{
			AddOn2 addOn = null;
			try
			{
				addOn = AdvancedAddOns.GetAddOnByTitle(addonTitle);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			return addOn.IsManaged;
		}

		public void AddAddon(AddOn x)
		{
			ListChangingEvent?.Invoke();
			InvalidDateLINQCache();
			AddOn addOn = x;
			AdvancedAddOns.Add(x);
			if (x.Title == null)
			{
				x.Title = "Unknown";
			}
			else if (Strings.Len(x.Title) == 0)
			{
				x = x;
			}
			bool flag = false;
			int num = 0;
			foreach (AddOn addOn2 in AddOns)
			{
				if (Operators.CompareString(Strings.LCase(addOn2.Title), Strings.LCase(x.Title), TextCompare: false) == 0)
				{
					addOn2.OtherVersion.Add(x);
					return;
				}
				num = checked(num + 1);
			}
			AddOns.Add(x);
			ListChangedEvent?.Invoke();
		}
	}
}
