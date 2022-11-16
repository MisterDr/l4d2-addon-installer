namespace AOICL
{
	public class AddOnBaseInfo
	{
		private string _Title;

		private string _Version;

		private string _DisplatName;

		public string Title => _Title;

		public string Version => _Version;

		public string DisplayName => _DisplatName;

		public AddOnBaseInfo(string Title, string Version)
			: this(Title, Version, Title)
		{
		}

		public AddOnBaseInfo(string Title, string Version, string DisplayName)
		{
			_Title = null;
			_Version = null;
			_DisplatName = null;
			_Title = Title;
			_Version = Version;
			_DisplatName = DisplayName;
		}
	}
}
