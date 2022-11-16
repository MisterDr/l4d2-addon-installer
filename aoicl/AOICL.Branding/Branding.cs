namespace AOICL.Branding
{
	public class Branding
	{
		public OptionSpashScreen SplashScreen;

		public OptionBanner Banner;

		public OptionCustomMenu Menu;

		public Branding()
		{
			SplashScreen = new OptionSpashScreen();
			Banner = new OptionBanner();
			Menu = new OptionCustomMenu();
		}
	}
}
