using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Pocket_Scout
{
	public partial class App : Application
	{
        public static bool IsUserLoggedIn { get; set; }

<<<<<<< HEAD
        public App()
        {
            InitializeComponent();
            //if (!IsUserLoggedIn){
            MainPage = new NavigationPage(new Pocket_Scout.Login());
            /* }
           else
            {
                MainPage = new Pocket_Scout.MainPage();
            }*/
        }
=======
            MainPage = new NavigationPage(new Pocket_Scout.MainPage());
		}
>>>>>>> origin/geoBranch

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
