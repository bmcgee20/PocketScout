using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace Pocket_Scout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootPageDetail : ContentPage
    {
        Map map;
        public RootPageDetail()
        {
            InitializeComponent();

            // map interface
            map = new Map(MapSpan.FromCenterAndRadius(new Position(33.584262, -101.878388), Distance.FromMiles(10)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand,
                MapType = MapType.Satellite
            };

            // map style buttons
            var street = new Button { Text = "Street" };
            var hybrid = new Button { Text = "Hybrid" };
            var satellite = new Button { Text = "Satellite" };
            street.Clicked += ChangeMapStyle;
            hybrid.Clicked += ChangeMapStyle;
            satellite.Clicked += ChangeMapStyle;

            // segment
            var segments = new StackLayout
            {
                Spacing = 30,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Orientation = StackOrientation.Horizontal,
                Children = { street, hybrid, satellite }
            };

            // putting everything together
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            stack.Children.Add(segments);
            Content = stack;

            // pin
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(33.584262, -101.878388),
                Label = "Texas Tech University",
                Address = "2500 Broadway, Lubbock, TX 79409"
            };
            map.Pins.Add(pin);

        }

        void ChangeMapStyle(object sender, EventArgs e)
        {
            var b = sender as Button;
            switch (b.Text)
            {
                case "Street":
                    map.MapType = MapType.Street;
                    break;
                case "Hybrid":
                    map.MapType = MapType.Hybrid;
                    break;
                case "Satellite":
                    map.MapType = MapType.Satellite;
                    break;
            }
        }
    }
}