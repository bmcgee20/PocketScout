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

        private void ButtonClicked(object sender, EventArgs e)
        {
            string text = MainEntry.Text;

            MainLabel.Text = "Hello " + text;
        }

        private async void NavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestPage());
        }

        private void GPSButtonClicked(object sender, EventArgs e)
        {
            /*
             * Gets current location using xams.plugin.geolocator
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;

                var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);

                LongitudeLabel.Text = position.Longitude.ToString();
                LatitudeLabel.Text = position.Latitude.ToString();

            */
        }
    }
}
