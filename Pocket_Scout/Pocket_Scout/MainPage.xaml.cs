using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pocket_Scout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void NavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestPage());
        }
    }
}
