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
	public partial class Knots : ContentPage
	{
        private StackLayout InsideGeneralTipsLayout, InsideKnotTipsLayout;
        private StackLayout beginingLayout;
        private Button btnShowHide1, btnShowHide2;
        private const string ARROW_DOWN = "\u25Bc";//"\u2B07";
        private const string ARROW_UP = "\u25B2";//"\u2B06";

        public Knots()
        {
            InitializeComponent();


            //items
            var image = new Image
            {
                Source = "knot.png",
                WidthRequest = 190,
                HeightRequest = 190,
                MinimumHeightRequest = 190,
                MinimumWidthRequest = 190,
                HorizontalOptions = LayoutOptions.Center
            };

            var title = new Label { Text = "Knots", FontSize = 45 };

            var intro = new Label
            {
                Text = "  Knowing how to tie knots is a valuable skill in wilderness survival. " +
                "Below is a list of common knots that may be useful to your camping trip. "
                ,
                FontSize = 18
            };

            intro.Margin = 10;
            title.HorizontalOptions = LayoutOptions.Center; intro.BackgroundColor = Color.LightGray;


            var lblBase = new Label
            {
                Text = "General Tips",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center

            }; lblBase.FontSize = 20;

            var lblBase2 = new Label
            {
                Text = "Common Knots",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            }; lblBase2.FontSize = 20;

            btnShowHide1 = new Button
            {
                Text = ARROW_DOWN,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            btnShowHide2 = new Button
            {
                Text = ARROW_DOWN,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            btnShowHide1.Clicked += (sender, e) =>
            {
                if (btnShowHide1.Text.Equals(ARROW_DOWN))
                {
                    btnShowHide1.Text = ARROW_UP;
                    InsideGeneralTipsLayout.IsVisible = true;
                }
                else
                {
                    btnShowHide1.Text = ARROW_DOWN;
                    InsideGeneralTipsLayout.IsVisible = false;
                }
            };

            btnShowHide2.Clicked += (sender, e) =>//CHANGES NEEDED
            {
                if (btnShowHide2.Text.Equals(ARROW_DOWN))
                {
                    btnShowHide2.Text = ARROW_UP;
                    InsideKnotTipsLayout.IsVisible = true;
                }
                else
                {
                    btnShowHide2.Text = ARROW_DOWN;
                    InsideKnotTipsLayout.IsVisible = false;
                }
            };

            //layouts
            var GeneralTipsLayout = new StackLayout
            {
                Children = { btnShowHide1, lblBase },
                BackgroundColor = Color.Gray,
                Orientation = StackOrientation.Horizontal
            };

            var KnotTipsLayout = new StackLayout
            {
                Children = { btnShowHide2, lblBase2 },
                BackgroundColor = Color.Gray,
                Orientation = StackOrientation.Horizontal
            };

            var GeneralTipsPanel = new Label//inside panel
            {
                Text = "To be added...",
                //TextColor = Color.DarkGray,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            var KnotTipsPanel = new Label//inside panel
            {
                Text = "To be added...",
                //TextColor = Color.DarkGray,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            InsideGeneralTipsLayout = new StackLayout
            {
                Children = { GeneralTipsPanel },
                BackgroundColor = Color.LightGray,
                IsVisible = false
            };

            InsideKnotTipsLayout = new StackLayout
            {
                Children = { KnotTipsPanel },
                BackgroundColor = Color.LightGray,
                IsVisible = false
            };

            beginingLayout = new StackLayout
            {
                Children = { image, title, intro },

            };

            var pgrBase = new PanGestureRecognizer();
            pgrBase.PanUpdated += OnPanUpdated;
            pgrBase.PanUpdated += OnPanUpdated2;//???????????

            var pgrDetails = new PanGestureRecognizer();
            pgrDetails.PanUpdated += OnPanUpdated;
            pgrDetails.PanUpdated += OnPanUpdated2;//?????????????????

            GeneralTipsLayout.GestureRecognizers.Add(pgrBase);
            InsideGeneralTipsLayout.GestureRecognizers.Add(pgrDetails);

            KnotTipsLayout.GestureRecognizers.Add(pgrBase);//????????????
            InsideKnotTipsLayout.GestureRecognizers.Add(pgrDetails);

            var layoutAll = new StackLayout
            {
                Children = { beginingLayout, GeneralTipsLayout, InsideGeneralTipsLayout, KnotTipsLayout, InsideKnotTipsLayout },
                Spacing = 0,
                Padding = new Thickness(10, 10, 10, 10),
                Orientation = StackOrientation.Vertical
            };

            Content = layoutAll;
            this.Content = new ScrollView { Content = layoutAll };
        }
        private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    if (e.TotalY > 20)
                    {
                        InsideGeneralTipsLayout.IsVisible = true;
                        btnShowHide1.Text = ARROW_UP;
                    }

                    if (e.TotalY < -20)
                    {
                        InsideGeneralTipsLayout.IsVisible = false;
                        btnShowHide1.Text = ARROW_DOWN;
                    }
                    break;
            }


        }
        private void OnPanUpdated2(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    if (e.TotalY > 20)
                    {
                        InsideKnotTipsLayout.IsVisible = true;
                        btnShowHide2.Text = ARROW_UP;
                    }

                    if (e.TotalY < -20)
                    {
                        InsideKnotTipsLayout.IsVisible = false;
                        btnShowHide2.Text = ARROW_DOWN;
                    }
                    break;
            }
        }
    }
}