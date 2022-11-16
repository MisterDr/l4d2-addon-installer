namespace AOICL.Branding
{
	public class OptionBanner
	{
		public bool Enabled;

		private string _BannerURL;

		public string BannerURL
		{
			get
			{
				return _BannerURL;
			}
			set
			{
				_BannerURL = value;
			}
		}
	}
}
