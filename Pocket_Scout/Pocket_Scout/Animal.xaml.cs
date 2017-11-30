﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pocket_Scout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Animal : ContentPage
    {
        private StackLayout beginingLayout, InsideGeneralTipsLayout, InsideHikingTipsLayout, InsideTracksLayout;
        private Button btnShowHide1, btnShowHide2, btnShowHide3;
        private const string ARROW_DOWN = "\u25Bc";//"\u2B07";
        private const string ARROW_UP = "\u25B2";//"\u2B06";

        public Animal()
        {
            InitializeComponent();


            //items
            var image = new Image
            {
                Source = "Black_bear_BW.png",
                WidthRequest = 150,
                HeightRequest = 150,
                MinimumHeightRequest = 150,
                MinimumWidthRequest = 150,
                HorizontalOptions = LayoutOptions.Center
            };
            var beaver = new Image
            {
                Source = "beaver_track.png",
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center
            };
            var beaverl = new Label{
                Text = "Beaver ",
                FontSize = 30,
                Margin = 10,
                HorizontalOptions = LayoutOptions.Center
            };
            var bbear = new Image
            {
                Source = "black_bear_track.png",
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center
            };
            var bbearl = new Label
            {
                Text = "Black Bear ",
                FontSize = 30,
                Margin = 10,
                HorizontalOptions = LayoutOptions.Center
            };

            var bobcat = new Image
            {
                Source = "bobcat.png",
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center
            };
            var bobcatl = new Label
            {
                Text = "Bobcat ",
                FontSize = 30,
                Margin = 10,
                HorizontalOptions = LayoutOptions.Center
            };
            var coyote = new Image
            {
                Source = "coyote.png",
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center
            };
            var coyotel = new Label
            {
                Text = "Coyote ",
                FontSize = 30,
                Margin = 10,
                HorizontalOptions = LayoutOptions.Center
            };
            var deer = new Image
            {
                Source = "deer.png",
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center
            };
            var deerl = new Label
            {
                Text = "Whitetail Deer ",
                FontSize = 30,
                Margin = 10,
                HorizontalOptions = LayoutOptions.Center
            };

            var op = new Image
            {
                Source = "op.png",
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center
            };
            var opl = new Label
            {
                Text = "Opossum ",
                FontSize = 30,
                Margin = 10,
                HorizontalOptions = LayoutOptions.Center
            };
            var rabbit = new Image
            {
                Source = "rabbit.png",
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center
            };
            var rabbitl = new Label
            {
                Text = "Cottontail Rabbit",
                FontSize = 30,
                Margin = 10,
                HorizontalOptions = LayoutOptions.Center
            };


            var racoon = new Image
            {
                Source = "racoon.png",
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center
            };

            var racl = new Label
            {
                Text = "Raccoon ",
                FontSize = 30,
                Margin = 10,
                HorizontalOptions = LayoutOptions.Center
            };
            var skunk = new Image
            {
                Source = "skunk.png",
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center
            };

            var skunkl = new Label
            {
                Text = "Skunk ",
                FontSize = 30,
                Margin = 10,
                HorizontalOptions = LayoutOptions.Center
            };
            var sq = new Image
            {
                Source = "sq.png",
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center
            };
            var sql = new Label
            {
                Text = "Gray Squirrel ",
                FontSize = 30,
                Margin = 10,
                HorizontalOptions = LayoutOptions.Center
            };
            var wolf = new Image
            {
                Source = "wolf.png",
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center
            };
            var wolfl = new Label
            {
                Text = "Wolf ",
                FontSize = 30,
                Margin = 10,
                HorizontalOptions = LayoutOptions.Center
            };

            var title = new Label { Text = "Animal Guide", FontSize = 45 };

            var intro = new Label
            {
                Text = "  You will encounter various wildlife throughout your camping endeavors.  " +
                "To help you stay safe, check out the below tips on how to avoid/interact with wildlife. "
                ,
                FontSize = 18
            };
            intro.Margin = 10; title.HorizontalOptions = LayoutOptions.Center; intro.BackgroundColor = Color.LightGray;
            

            var lblBase = new Label
            {
                Text = "General Tips",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
                
            }; lblBase.FontSize = 20;

            var lblBase2 = new Label
            {
                Text = "Hiking Safety Tips",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            }; lblBase2.FontSize = 20;

            var lblBase3 = new Label
            {
                Text = "Common Animal Tracks",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            }; lblBase3.FontSize = 20;

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

            btnShowHide3 = new Button
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

            btnShowHide2.Clicked += (sender, e) =>
            {
                if (btnShowHide2.Text.Equals(ARROW_DOWN))
                {
                    btnShowHide2.Text = ARROW_UP;
                    InsideHikingTipsLayout.IsVisible = true;
                }
                else
                {
                    btnShowHide2.Text = ARROW_DOWN;
                    InsideHikingTipsLayout.IsVisible = false;
                }
            };

            btnShowHide3.Clicked += (sender, e) =>
            {
                if (btnShowHide3.Text.Equals(ARROW_DOWN))
                {
                    btnShowHide3.Text = ARROW_UP;
                    InsideTracksLayout.IsVisible = true;
                }
                else
                {
                    btnShowHide3.Text = ARROW_DOWN;
                    InsideTracksLayout.IsVisible = false;
                }
            };

            //layouts
            var GeneralTipsLayout = new StackLayout
            {
                Children = { btnShowHide1, lblBase },
                BackgroundColor = Color.Gray,
                Orientation = StackOrientation.Horizontal
            }; GeneralTipsLayout.Margin = 10;

            var HikingTipsLayout = new StackLayout
            {
                Children = { btnShowHide2, lblBase2 },
                BackgroundColor = Color.Gray,
                Orientation = StackOrientation.Horizontal
            }; HikingTipsLayout.Margin = 10;

            var TracksLayout = new StackLayout
            {
                Children = { btnShowHide3, lblBase3 },
                BackgroundColor = Color.Gray,
                Orientation = StackOrientation.Horizontal
            }; TracksLayout.Margin = 10;

            var GeneralTipsPanel = new Label//inside panel
            {
                Text = "•	Animals may infest your campsite while looking for food. To avoid this, keep any food inside containers like a cooler with a lock on the lid.\n" +
                        " You can tie a rope around the container and hang it 7 feet above the ground. The goal here is to get the food away from the reach of an animal such as a bear.\n" +
                        "It is also a good idea to hang your food a good distance from your campsite in case any animals are attracted to it.\n" +
                        "\n•	Take care of any leftovers after a meal and make sure none is left exposed. Throw away trash in odor proof bags to avoid the smell of food.\n\n" +
                        "•	Wash dishes and utensils after use to get off any food particles.\n\n" +
                        "•	Avoid lotions or anything with a noticeable scent. Various scents can attract animals looking for food.\n\n" +
                        "•	Depending on your location, it may be a good idea to ask any park rangers for tips on the local animals and how to navigate around them safely.",
                
                FontSize = 18,
                Margin = 20,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            var HikingTipsPanel = new Label//inside panel
            {
                Text = "•	Do not approach or suprise wild animals. Some animals may attack if they feel threatened.\n\n" +
                        "•	Avoid hiking at night or off the trail. It is also a good idea to hike with a partner.\n\n" +
                        "•	Watch for any signs of tracks, droppings, or scratches on trees.This may indicate an animal is nearby and to be cautious.\n\n" +
                        "•	Try to make noise while hiking so animals know of your presence. Some good ideas are to clap your hands, sing, or talk.\n",
               
                FontSize = 18,
                Margin = 20,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            var TracksPanel = new Label//inside panel
            {
                Text = " Curious about what tracks you saw? \n Below are general animal tracks you may encounter in North America.",
                
                FontSize = 18,
                Margin = 20,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            InsideGeneralTipsLayout = new StackLayout
            {
                Children = { GeneralTipsPanel },
                BackgroundColor = Color.LightGray,
                IsVisible = false
            };

            InsideHikingTipsLayout = new StackLayout
            {
                Children = { HikingTipsPanel },
                BackgroundColor = Color.LightGray,
                IsVisible = false
            };

            InsideTracksLayout = new StackLayout
            {
                Children = { TracksPanel,beaverl,beaver,bbearl,bbear,bobcatl,bobcat,
                    coyotel,coyote,deerl,deer,opl,op,rabbitl,rabbit,racl,racoon,skunkl,skunk,sql,sq,wolfl,wolf },// Add images here
                BackgroundColor = Color.LightGray,
                IsVisible = false
            };

            beginingLayout = new StackLayout
            {
                Children = { image, title, intro },

            };

            var pgrBase = new PanGestureRecognizer();
            pgrBase.PanUpdated += OnPanUpdated;
            pgrBase.PanUpdated += OnPanUpdated2;
            pgrBase.PanUpdated += OnPanUpdated3;

            var pgrDetails = new PanGestureRecognizer();
            pgrDetails.PanUpdated += OnPanUpdated;
            pgrDetails.PanUpdated += OnPanUpdated2;
            pgrDetails.PanUpdated += OnPanUpdated3;

            GeneralTipsLayout.GestureRecognizers.Add(pgrBase);
            InsideGeneralTipsLayout.GestureRecognizers.Add(pgrDetails);

            HikingTipsLayout.GestureRecognizers.Add(pgrBase);
            InsideHikingTipsLayout.GestureRecognizers.Add(pgrDetails);

            TracksLayout.GestureRecognizers.Add(pgrBase);
            InsideTracksLayout.GestureRecognizers.Add(pgrDetails);

            var layoutAll = new StackLayout
            {
                Children = { beginingLayout, GeneralTipsLayout, InsideGeneralTipsLayout, HikingTipsLayout, InsideHikingTipsLayout, TracksLayout, InsideTracksLayout },
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
                        InsideHikingTipsLayout.IsVisible = true;
                        btnShowHide2.Text = ARROW_UP;
                    }

                    if (e.TotalY < -20)
                    {
                        InsideHikingTipsLayout.IsVisible = false;
                        btnShowHide2.Text = ARROW_DOWN;
                    }
                    break;
            }
        }

        private void OnPanUpdated3(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    if (e.TotalY > 20)
                    {
                        InsideTracksLayout.IsVisible = true;
                        btnShowHide3.Text = ARROW_UP;
                    }

                    if (e.TotalY < -20)
                    {
                        InsideTracksLayout.IsVisible = false;
                        btnShowHide3.Text = ARROW_DOWN;
                    }
                    break;
            }
        }
    }
}