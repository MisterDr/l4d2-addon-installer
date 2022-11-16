using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class AddOnInfo
	{
		public Dictionary<string, string> AddOnData;

		private string _Title;

		private string _Version;

		private string _Author;

		private string _VPKFilePath;

		public string Title
		{
			get
			{
				return _Title;
			}
			set
			{
				_Title = value;
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

		public string Author
		{
			get
			{
				return _Author;
			}
			set
			{
				_Author = value;
			}
		}

		public string VPKFilePath
		{
			get
			{
				return _VPKFilePath;
			}
			set
			{
				_VPKFilePath = value;
			}
		}

		public object Description => GetValue("addonddescription");

		//public object Description
		//{
		//	get
		//	{
		//		string key = Strings.LCase("addondescription_" + CC);
		//		if (AddOnData.ContainsKey(key))
		//		{
		//			return AddOnData[key];
		//		}
		//		return null;
		//	}
		//}

		public string URL => GetValue("addonurl0");

		public string Tags
		{
			get
			{
				string text = null;
				IEnumerable<string> source = from o in AddOnData
					where Strings.LCase(o.Key).StartsWith("addoncontent") & (Operators.CompareString(o.Value, "0", TextCompare: false) != 0)
					select Strings.Split(o.Key, "_").Last();
				return Strings.Join(source.ToArray(), ", ");
			}
		}

		public AddOnInfo()
		{
			AddOnData = new Dictionary<string, string>();
		}

		private string GetValue(string KeyName)
		{
			if (AddOnData.ContainsKey(KeyName))
			{
				return AddOnData[KeyName];
			}
			return null;
		}
	}
}
