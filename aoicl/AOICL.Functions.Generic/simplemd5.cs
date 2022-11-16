using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AOICL.Functions.Generic
{
	public class simplemd5
	{
		[DebuggerNonUserCode]
		public simplemd5()
		{
		}

		public static string MD5CalcFile(string filepath)
		{
			//Discarded unreachable code: IL_002a
			using FileStream inputStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
			using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] arrInput = mD5CryptoServiceProvider.ComputeHash(inputStream);
			return ByteArrayToString(arrInput);
		}

		private static string ByteArrayToString(byte[] arrInput)
		{
			checked
			{
				StringBuilder stringBuilder = new StringBuilder(arrInput.Length * 2);
				int num = arrInput.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					stringBuilder.Append(arrInput[i].ToString("X2"));
				}
				return stringBuilder.ToString().ToLower();
			}
		}
	}
}
