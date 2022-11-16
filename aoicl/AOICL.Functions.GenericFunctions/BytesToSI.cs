using System;
using System.Diagnostics;

namespace AOICL.Functions.GenericFunctions
{
	public class BytesToSI
	{
		[DebuggerNonUserCode]
		public BytesToSI()
		{
		}

		public static string BytesToSI2(long size)
		{
			string text = "B";
			double num = size;
			if (num > 1024.0)
			{
				text = "KB";
				num = Math.Round(num / 1024.0, 2);
				if (num > 1024.0)
				{
					text = "MB";
					num = Math.Round(num / 1024.0, 2);
					if (num > 1024.0)
					{
						text = "GB";
						num = Math.Round(num / 1024.0, 2);
					}
				}
			}
			return num + text;
		}
	}
}
