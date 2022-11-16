using System;
using System.Diagnostics;
using System.IO;

namespace AOICL
{
	public class AOIPaths
	{
		[DebuggerNonUserCode]
		public AOIPaths()
		{
		}

		public static string AppDataPath()
		{
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "L4D2AOI");
		}

		public static string TempDataPath()
		{
			return Path.Combine(AppDataPath(), "Temp");
		}

		public static string DownloadsPath()
		{
			return Path.Combine(AppDataPath(), "Downloads");
		}

		public static string FeedsPath()
		{
			return Path.Combine(AppDataPath(), "Feeds");
		}

		public static string LogPath()
		{
			return Path.Combine(AppDataPath(), "Logs");
		}

		public static string TasksPath()
		{
			return Path.Combine(AppDataPath(), "Tasks");
		}
	}
}
