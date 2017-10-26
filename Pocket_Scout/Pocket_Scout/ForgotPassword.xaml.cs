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
	public partial class ForgotPassword : ContentPage
	{
		public ForgotPassword ()
		{
			InitializeComponent ();
		}
        async void ForgotButtonClicked(object sender, EventArgs e)
        {
            String Email = emailEntry.Text;
            if (IsValid(Email))
            {
                //need to check if user exists and send email

                await DisplayAlert("Success!", "Email sent!", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Whoa there!", "Enter valid email:", "OK");
            }
        }
        bool IsValid(String Email)
        {
            return (!string.IsNullOrWhiteSpace(Email) && Regex.Match(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success);
        }
    }
}