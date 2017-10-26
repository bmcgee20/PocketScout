using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pocket_Scout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			InitializeComponent ();
		}

        async void RegisterClicked(object sender, EventArgs e)
        {
            String Username = usernameEntry.Text;
			String Password = passwordEntry.Text;
            String Email = emailEntry.Text;

            if (IsValid(Username, Password, Email))
            {
                //need to check if user already exists with email

                await DisplayAlert("Success!", "Your account has been created.", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Oh no!", "Enter valid username/password:", "OK");
            }
            
        }


        bool IsValid(String Username, String Password, String Email)
        {
            return (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password) && !string.IsNullOrWhiteSpace(Email) 
            && Regex.Match(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success);
            }

    }
}