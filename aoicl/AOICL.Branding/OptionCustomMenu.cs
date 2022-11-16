using System.Collections.Generic;

namespace AOICL.Branding
{
	public class OptionCustomMenu
	{
		public bool Enabled;

		public string Title;

		public string ImageUrl;

		public List<OptionCustomMenuItem> Items;

		public OptionCustomMenu()
		{
			Items = new List<OptionCustomMenuItem>();
		}
	}
}
