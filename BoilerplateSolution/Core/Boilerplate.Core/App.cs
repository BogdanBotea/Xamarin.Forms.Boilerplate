using Xamarin.Forms;

namespace Boilerplate.Core
{
	public class AppOptions
	{
	}

	public class App : Application
	{
		#region [ Singleton ]

		private static readonly App _instance = new App();

		static App() { }

		private App() { }

		public static App Instance
		{
			get { return _instance; }
		}

		#endregion

		#region [ Fields ]

		private AppOptions _options;

		#endregion

		#region [ Properties ]

		public AppOptions Options
		{
			get { return _options; }
			set { _options = value; }
		}

		#endregion

		#region [ Methods ]

		public void InitializeUI()
		{
			MainPage = new MainPage();
		}

		#endregion

		#region [ Overrides ]

		protected override void OnStart()
		{
		}

		protected override void OnSleep ()
		{
		}

		protected override void OnResume ()
		{
		}

		#endregion
	}
}

