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

        public App()
        {
            InitializeComponent();
            //if (!IsUserLoggedIn){
            MainPage = new NavigationPage(new Pocket_Scout.Survival_Guide());//(new Pocket_Scout.Login());
            /* }
           else
            {
                MainPage = new Pocket_Scout.MainPage();
            }*/
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
