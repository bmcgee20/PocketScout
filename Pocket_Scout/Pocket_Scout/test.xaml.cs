using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pocket_Scout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class test : ContentPage
    {
        private StackLayout detailsLayout;
        private Button btnShowHide;
        private const string ARROW_DOWN = "\u25Bc";//"\u2B07";
        private const string ARROW_UP = "\u25B2";//"\u2B06";

        public test()
        {
            
            var lblBase = new Label
            {
                Text = "Lorem ipsum",
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            btnShowHide = new Button
            {
                Text = ARROW_DOWN,
                HorizontalOptions = LayoutOptions.Center,//LayoutOptions.StartAndExpand,//LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center//LayoutOptions.Center
            };
            btnShowHide.Clicked += (sender, e) =>
            {
                if (btnShowHide.Text.Equals(ARROW_DOWN))
                {
                    btnShowHide.Text = ARROW_UP;
                    detailsLayout.IsVisible = true;
                }
                else
                {
                    btnShowHide.Text = ARROW_DOWN;
                    detailsLayout.IsVisible = false;
                }
            };

            var baseLayout = new StackLayout
            {
                Children = {  btnShowHide,lblBase },
                BackgroundColor = Color.Gray,
                Orientation = StackOrientation.Horizontal
            };

            var lblDetails = new Label
            {
                Text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum.",
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            detailsLayout = new StackLayout
            {
                Children = { lblDetails },
                BackgroundColor = Color.LightGray,
                IsVisible = false
            };

            var pgrBase = new PanGestureRecognizer();
            pgrBase.PanUpdated += OnPanUpdated;

            var pgrDetails = new PanGestureRecognizer();
            pgrDetails.PanUpdated += OnPanUpdated;

            baseLayout.GestureRecognizers.Add(pgrBase);
            detailsLayout.GestureRecognizers.Add(pgrDetails);

            var layoutAll = new StackLayout
            {
                Children = { baseLayout, detailsLayout },
                Spacing = 0,
                Padding = new Thickness(10, 10, 10, 10),
                Orientation = StackOrientation.Vertical
            };

            Content = layoutAll;
        }
        private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    if (e.TotalY > 20)
                    {
                        detailsLayout.IsVisible = true;
                        btnShowHide.Text = ARROW_UP;
                    }

                    if (e.TotalY < -20)
                    {
                        detailsLayout.IsVisible = false;
                        btnShowHide.Text = ARROW_DOWN;
                    }
                    break;
            }


        }
    }
}