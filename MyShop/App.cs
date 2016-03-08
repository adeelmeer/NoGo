using System;

using Xamarin.Forms;

namespace MyShop
{
	public class App : Application
	{
        public static bool IsUserLoggedIn { get; set; }

        //public static double ScreenHeight;
        //public static double ScreenWidth;

        public App ()
		{
            MainPage = new NavigationPage(new LoginPage());

            //if (!IsUserLoggedIn)
            //{
            //    MainPage = new NavigationPage(new LoginPage());
            //}
            //else {
            //    // The root page of your application
            //    MainPage = new NavigationPage(new HomePage())
            //    {
            //        BarTextColor = Color.White
            //    };
            //}
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

