using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class InstallFileGenerator
	{
		[DebuggerNonUserCode]
		public InstallFileGenerator()
		{
		}

		public static string CreateJobFile(InstallFileGeneratorTasks Tasks, string path)
		{
			try
			{
				StreamWriter streamWriter = new StreamWriter(path);
				XmlSerializer xmlSerializer = new XmlSerializer(Tasks.GetType());
				xmlSerializer.Serialize(streamWriter, Tasks);
				streamWriter.Close();
				return path;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static InstallFileGeneratorTasks OpenJobFile(string path)
		{
			InstallFileGeneratorTasks installFileGeneratorTasks = new InstallFileGeneratorTasks();
			try
			{
				XmlTextReader xmlTextReader = new XmlTextReader(path);
				XmlSerializer xmlSerializer = new XmlSerializer(installFileGeneratorTasks.GetType());
				installFileGeneratorTasks = (InstallFileGeneratorTasks)xmlSerializer.Deserialize(xmlTextReader);
				xmlTextReader.Close();
				return installFileGeneratorTasks;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return installFileGeneratorTasks;
			}
		}
	}
}
