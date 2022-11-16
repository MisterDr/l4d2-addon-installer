using Microsoft.VisualBasic.CompilerServices;

namespace AOICL
{
	public class DoActionCommandCopy
	{
		private string _Source;

		private string _Destination;

		public string Source => _Source;

		public string Destination => _Destination;

		public DoActionCommandCopy(DoActionCommand basecmd)
		{
			_Source = null;
			_Destination = null;
			_Source = Conversions.ToString(basecmd.Argument(0));
			_Destination = Conversions.ToString(basecmd.Argument(1));
			_Source = _Source.Replace("/", "\\");
			_Source = _Source.Replace("\\\\", "\\");
			_Destination = _Destination.Replace("/", "\\");
			_Destination = _Destination.Replace("\\\\", "\\");
		}
	}
}
