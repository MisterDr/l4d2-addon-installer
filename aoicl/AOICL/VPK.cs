using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Gibbed.Valve.FileFormats;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class VPK
	{
		private struct AddOnInfoKeyPair
		{
			public string Key;

			public string Value;
		}

		private string _vpkPath;

		private Stream _vpkStream;

		private PackageFile _vpkPackage;

		private PackageEntry _vpkEntry;

		private long _vpkPackageIndexSize;

		private Stream _EntryStream;

		private Regex WhiteSpaceRegEx;

		private Regex CommentsRegEx;

		public VPK(string VPKPath)
		{
			_vpkPath = null;
			_vpkStream = null;
			_vpkPackage = null;
			_vpkEntry = null;
			_vpkPackageIndexSize = 0L;
			_EntryStream = null;
			WhiteSpaceRegEx = new Regex("\\s+");
			CommentsRegEx = new Regex("\\s+\\/\\/+\\s?[^\\r\\n]*");
			_vpkPath = VPKPath;
		}

		private Stream EntryMemoryStream(PackageEntry Entry)
		{
			_EntryStream = new MemoryStream();
			long num = Entry.Size;
			byte[] buffer = new byte[4097];
			checked
			{
				_vpkStream.Seek(unchecked((long)Entry.Offset) + _vpkPackageIndexSize, SeekOrigin.Begin);
				while (num > 0)
				{
					int num2 = (int)Math.Min(num, 4096L);
					_vpkStream.Read(buffer, 0, num2);
					_EntryStream.Write(buffer, 0, num2);
					num -= num2;
				}
				_EntryStream.Seek(0L, SeekOrigin.Begin);
				return _EntryStream;
			}
		}

		public string GetAddonInfoRaw()
		{
			string result = null;
			try
			{
				_vpkPackage = new PackageFile();
				_vpkStream = File.OpenRead(_vpkPath);
				_vpkPackageIndexSize = _vpkPackage.Deserialize(_vpkStream);
				foreach (PackageEntry entry in _vpkPackage.Entries)
				{
					if (Operators.CompareString(Strings.UCase(entry.FileName), "ADDONINFO", TextCompare: false) == 0)
					{
						StreamReader streamReader = new StreamReader(EntryMemoryStream(entry));
						result = streamReader.ReadToEnd();
						streamReader.Close();
						_vpkStream.Close();
						return result;
					}
				}
				_vpkStream.Close();
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		private object RemoveWhiteSpace(string strText)
		{
			strText = WhiteSpaceRegEx.Replace(strText, " ");
			return Strings.Trim(strText);
		}

		private object StripComments(string strText)
		{
			strText = CommentsRegEx.Replace(strText, "");
			return strText;
		}

		private AddOnInfoKeyPair ExtractAddOnKeyPairWithRegEx(string Data)
		{
			AddOnInfoKeyPair result = default(AddOnInfoKeyPair);
			string text = Conversions.ToString(RemoveWhiteSpace(Conversions.ToString(StripComments(Data))));
			string[] array = Strings.Split(text);
			string text2 = null;
			string text3 = null;
			checked
			{
				if ((array.Length > 1) & !text.StartsWith("//"))
				{
					text2 = array.First();
					text3 = Strings.Right(text, text.Length - text2.Length - 1);
					if (Operators.CompareString(Conversions.ToString(text3.First()), "\"", TextCompare: false) == 0)
					{
						text3 = Strings.Right(text3, Strings.Len(text3) - 1);
					}
					if (Operators.CompareString(Conversions.ToString(text3.Last()), "\"", TextCompare: false) == 0)
					{
						text3 = Strings.Left(text3, Strings.Len(text3) - 1);
					}
					result.Key = text2;
					result.Value = text3;
				}
				return result;
			}
		}

		private static AddOnInfoKeyPair ExtractAddOnKeyPair(string Data)
		{
			string text = Strings.Trim(Data);
			text = text;
			AddOnInfoKeyPair result = default(AddOnInfoKeyPair);
			string text2 = Strings.Trim(text);
			checked
			{
				if (!((text2.Length == 0) | (Operators.CompareString(text2, "}", TextCompare: false) == 0) | (Operators.CompareString(text2, "{", TextCompare: false) == 0) | text2.StartsWith("//")))
				{
					text2 = Strings.LCase(text2);
					Regex regex = new Regex("\\s\\s*");
					text2 = regex.Replace(text2, " ");
					text2 = Strings.Trim(text2);
					try
					{
						if ((Strings.Split(text2).Length > 1) & !text2.StartsWith("//") & (text2.Length > 0))
						{
							if (Strings.InStr(text2, "//") != 0)
							{
								text2 = text2;
								int num = Strings.InStr(text2, "//");
								char c = text2[num - 2];
								char c2 = text2[num + 1];
								if ((Operators.CompareString(Conversions.ToString(c), " ", TextCompare: false) == 0) | (Operators.CompareString(Conversions.ToString(c2), " ", TextCompare: false) == 0))
								{
									text2 = Strings.Left(text2, num - 2);
									text2 = text2;
								}
								int num2 = Strings.InStr(text2, " //");
								if (num2 != 0)
								{
									text2 = Strings.Left(text2, num2 - 1);
									text2 = text2;
								}
							}
							string key = Strings.Split(text2)[0];
							int num3 = Strings.InStr(text2, " ");
							string text3 = null;
							if (num3 > 0)
							{
								text3 = Strings.Mid(text2, num3 + 1, text2.Length - num3 + 1);
							}
							if (text3 == null)
							{
								text3 = "";
							}
							try
							{
								if (Operators.CompareString(Conversions.ToString(text3[0]), "\"", TextCompare: false) == 0)
								{
									text3 = Strings.Right(text3, Strings.Len(text3) - 1);
									text3 = Strings.Left(text3, Strings.Len(text3) - 1);
								}
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								text3 = "0";
								ProjectData.ClearProjectError();
							}
							result.Key = key;
							result.Value = text3;
							return result;
						}
						return result;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						text2 = text2;
						Interaction.MsgBox(ex4.ToString());
						ProjectData.ClearProjectError();
						return result;
					}
				}
				return result;
			}
		}

		public AddOnInfo ExtractAddonInfo(string data)
		{
			List<string> list = new List<string>();
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			string[] array = Strings.Split(data, "\r\n");
			AddOnInfo addOnInfo = new AddOnInfo();
			string[] array2 = array;
			foreach (string data2 in array2)
			{
				AddOnInfoKeyPair addOnInfoKeyPair = ExtractAddOnKeyPairWithRegEx(data2);
				if (addOnInfoKeyPair.Key != null)
				{
					addOnInfoKeyPair = addOnInfoKeyPair;
					dictionary.Add(Strings.LCase(addOnInfoKeyPair.Key), addOnInfoKeyPair.Value);
				}
				addOnInfoKeyPair = addOnInfoKeyPair;
			}
			if (dictionary.ContainsKey("addontitle"))
			{
				addOnInfo.Title = dictionary["addontitle"];
			}
			if (dictionary.ContainsKey("addonversion"))
			{
				addOnInfo.Version = dictionary["addonversion"];
			}
			if (dictionary.ContainsKey("addonauthor"))
			{
				addOnInfo.Author = dictionary["addonauthor"];
			}
			addOnInfo.AddOnData = dictionary;
			return addOnInfo;
		}

		public AddOnInfo GetAddonInfo()
		{
			string addonInfoRaw = GetAddonInfoRaw();
			AddOnInfo addOnInfo = ExtractAddonInfo(addonInfoRaw);
			addOnInfo.VPKFilePath = _vpkPath;
			return addOnInfo;
		}

		~VPK()
		{
			_vpkPackage = null;
			if (_vpkStream != null)
			{
				try
				{
					_vpkStream.Dispose();
					_vpkStream.Close();
					_vpkStream = null;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			// base.Finalize();
		}
	}
}
