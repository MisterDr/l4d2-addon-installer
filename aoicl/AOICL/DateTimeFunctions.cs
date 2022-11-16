using System;
using System.Diagnostics;

namespace AOICL
{
	public class DateTimeFunctions
	{
		[DebuggerNonUserCode]
		public DateTimeFunctions()
		{
		}

		public static DateTime ConvertTimestamp(double timestamp)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0);
			DateTime dateTime2 = dateTime;
			return dateTime2.AddSeconds(timestamp);
		}

		public static double tstounix(DateTime value)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
			DateTime dateTime2 = dateTime;
			return (value - dateTime2.ToLocalTime()).TotalSeconds;
		}
	}
}
