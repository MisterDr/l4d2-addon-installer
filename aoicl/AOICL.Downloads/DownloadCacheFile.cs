using System.IO;
using AOICL.Functions.Generic;

namespace AOICL.Downloads
{
	public class DownloadCacheFile
	{
		private string _Url;

		private string _FileName;

		public string URL => _Url;

		public string FileName => _FileName;

		public bool Exists
		{
			get
			{
				string path = Path.Combine(AOIPaths.DownloadsPath(), FileName);
				return File.Exists(path);
			}
		}

		public long Size
		{
			get
			{
				if (Exists)
				{
					FileInfo fileInfo = new FileInfo(Path.Combine(AOIPaths.DownloadsPath(), FileName));
					long length = fileInfo.Length;
					fileInfo = null;
					return length;
				}
				return 0L;
			}
		}

		public string MD5
		{
			get
			{
				if (Exists)
				{
					return simplemd5.MD5CalcFile(Path.Combine(AOIPaths.DownloadsPath(), FileName));
				}
				return null;
			}
		}

		public DownloadCacheFile(string URL, string FileName)
		{
			_Url = URL;
			_FileName = FileName;
		}
	}
}
