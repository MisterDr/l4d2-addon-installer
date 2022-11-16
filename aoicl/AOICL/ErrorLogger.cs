using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	[CLSCompliant(true)]
	public class ErrorLogger
	{
		private string _LogPath;

		private string AOIAppDataPath;

		private string AOILogPath;

		private string AOILogFile;

		public ErrorLogger()
		{
			_LogPath = null;
			AOIAppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "L4D2AOI");
			AOILogPath = Path.Combine(AOIAppDataPath, "Logs");
			AOILogFile = Path.Combine(AOILogPath, DateAndTime.Now.ToString() + ".log");
			string expression = DateAndTime.Now.ToString();
			expression = Strings.Replace(expression, ":", "-");
			expression = Strings.Replace(expression, "/", "-");
			expression = Strings.Replace(expression, "\\", "-");
			expression = expression + " " + DateAndTime.Now.Ticks;
			AOILogFile = Path.Combine(AOILogPath, expression + ".log");
		}

		public void WriteToErrorLogw(string msg, string stkTrace, string title)
		{
			string text = null;
			text = text + "Title: " + title + "\r\n";
			text = text + "Message: " + msg + "\r\n";
			text = text + "StackTrace: " + stkTrace + "\r\n";
			text = text + "Date/Time : " + DateTime.Now.ToString() + "\r\n";
			text += "===========================================================================================\r\n\r\n\r\n";
			WriteTextToErrorLog(text);
		}

		public void WriteEntry(string Title, string entry)
		{
			string text = null;
			text = text + "Title: " + Title + "\r\n";
			text = text + "Date/Time: " + DateTime.Now.ToString() + "\r\n";
			text += "===========================================================================================\r\n";
			text = text + entry + "\r\n";
			text += "\r\n\r\n";
			WriteTextToErrorLog(text);
		}

		private void WriteTextToErrorLog(string text)
		{
			try
			{
				if (!Directory.Exists(AOILogPath))
				{
					Directory.CreateDirectory(AOILogPath);
				}
				FileStream fileStream = new FileStream(AOILogFile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
				StreamWriter streamWriter = new StreamWriter(fileStream);
				streamWriter.Close();
				fileStream.Close();
				FileStream fileStream2 = new FileStream(AOILogFile, FileMode.Append, FileAccess.Write);
				StreamWriter streamWriter2 = new StreamWriter(fileStream2);
				streamWriter2.Write(text);
				streamWriter2.Close();
				fileStream2.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}
}
