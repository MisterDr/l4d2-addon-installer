using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class L4DAddOnList
	{
		private string _filename;

		private Dictionary<string, bool> _entries;

		public L4DAddOnList(string filename)
		{
			_entries = new Dictionary<string, bool>();
			_filename = filename;
			Reload();
		}

		public void Save()
		{
		}

		public void Reload()
		{
			try
			{
				_entries = new Dictionary<string, bool>();
				StreamReader streamReader = new StreamReader(_filename);
				while (!streamReader.EndOfStream)
				{
					string text = streamReader.ReadLine();
					text = text;
					text = Strings.Replace(text, "\t\t", " ");
					text = Strings.Replace(text, "\t", " ");
					text = Strings.LCase(Strings.Trim(text));
					text = Strings.Replace(text, "\"", "");
					text = text;
					if (!(text.StartsWith("addonlist") | text.StartsWith("{") | text.StartsWith("}")))
					{
						text = text;
						string key = Strings.Split(text).First();
						string value = Strings.Split(text).Last();
						if (!_entries.ContainsKey(key))
						{
							_entries.Add(key, Conversions.ToBoolean(value));
						}
						text = text;
					}
				}
				streamReader.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		public bool IsEnabled(string vpkname)
		{
			if (_entries.ContainsKey(Strings.LCase(vpkname)))
			{
				return _entries[Strings.LCase(vpkname)];
			}
			return false;
		}
	}
}
