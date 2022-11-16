using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class DoActionCommand
	{
		private string _Command;

		private DoActionCommandType _CommandType;

		public DoActionCommandType CommandType => _CommandType;

		public string Command => _Command;

		public string[] Parts => Strings.Split(_Command, ":");

		public string Action => Parts[0];

		public object Argument(int index)
		{

			if (index > Parts.Count())
			{
				return null;
			}
			return Parts[checked(index + 1)];
		}

		public DoActionCommand(string CommandString)
		{
			_Command = null;
			_CommandType = DoActionCommandType.Unknown;
			_Command = CommandString;
			string left = Strings.LCase(Parts[0]);
			if (Operators.CompareString(left, "copy", TextCompare: false) == 0)
			{
				_CommandType = DoActionCommandType.Copy;
			}
			else
			{
				_CommandType = DoActionCommandType.Unknown;
			}
		}
	}
}
