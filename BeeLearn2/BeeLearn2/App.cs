using Xamarin.Forms;

namespace BeeLearn2
{
	public class App : Application
	{
		public static bool IsUserLoggedIn { get; set; }

		public App ()
		{
			if (!IsUserLoggedIn) {
				MainPage = new NavigationPage (new Pages.LoginPage ());
			} else {
				MainPage = new NavigationPage (new Pages.MainPage ());
			}
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

