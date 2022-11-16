using System;

namespace AOICL
{
	public interface iDownloadClient
	{
		public delegate void DownloadStartedEventHandler();

		public delegate void DownloadCompleteEventHandler();

		public delegate void DownloadErrorEventHandler();

		public delegate void DownloadProgressEventHandler(long BytesDownloaded, long DownloadSize);

		Uri Source { get; set; }

		string Destination { get; set; }

		event DownloadStartedEventHandler DownloadStarted;

		event DownloadCompleteEventHandler DownloadComplete;

		event DownloadErrorEventHandler DownloadError;

		event DownloadProgressEventHandler DownloadProgress;

		void Start();

		void Stop();
	}
}
