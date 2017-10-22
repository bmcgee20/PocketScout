using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Pocket_Scout
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new Pocket_Scout.Login();//Pocket_Scout.MainPage();
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
