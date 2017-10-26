using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pocket_Scout
{
    //private static Uri Base_URL = new Uri("localhost:3000/api/")

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void SignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
        
        async void LoginButtonClicked(object sender, EventArgs e)
        {
            String Username = usernameEntry.Text;
            String Password = passwordEntry.Text;

            if (IsValid(Username, Password))
            {
            //need to check if user exists and has correct pass

             await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Oh no!", "Enter valid username/password:", "OK");
            }
        }

        bool IsValid(String Username, String Password)
        {
            return (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password));
        }

        async void ForgotPasswordClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPassword());
        }
    }
}