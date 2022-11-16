using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL.Downloads
{
	public class DownloadCache
	{
		public static IEnumerable<DownloadCacheFile> Cache
		{
			get
			{
				List<DownloadCacheFile> list = new List<DownloadCacheFile>();
				try
				{
					StreamReader streamReader = new StreamReader(Path.Combine(AOIPaths.DownloadsPath(), "Cache.txt"));
					while (!streamReader.EndOfStream)
					{
						string text = streamReader.ReadLine();
						string text2 = Strings.Split(text).First();
						string fileName = Strings.Right(text, checked(text.Length - text2.Length - 1));
						list.Add(new DownloadCacheFile(text2, fileName));
					}
					streamReader.Close();
					return list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					return list;
				}
			}
		}

		[DebuggerNonUserCode]
		public DownloadCache()
		{
		}

		public static bool IsInCache(string URI)
		{
			bool result = false;
			try
			{
				StreamReader streamReader = new StreamReader(Path.Combine(AOIPaths.DownloadsPath(), "Cache.txt"));
				while (!streamReader.EndOfStream)
				{
					string expression = streamReader.ReadLine();
					if (Operators.CompareString(Strings.Split(expression).First(), URI, TextCompare: false) == 0)
					{
						result = true;
					}
				}
				streamReader.Close();
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static bool IsDownloadCached(string URI)
		{
			bool flag = false;
			flag = IsInCache(URI);
			try
			{
				return File.Exists(Path.Combine(AOIPaths.DownloadsPath(), Strings.Split(URI, "/").Last()));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				flag = false;
				ProjectData.ClearProjectError();
				return flag;
			}
		}

		public static void AddToCache(string URI, string FileName)
		{
			StreamWriter streamWriter = File.AppendText(Path.Combine(AOIPaths.DownloadsPath(), "Cache.txt"));
			streamWriter.WriteLine(URI + " " + FileName);
			streamWriter.Close();
		}
	}
}
