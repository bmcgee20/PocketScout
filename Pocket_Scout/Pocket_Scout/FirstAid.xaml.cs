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
    public partial class FirstAid : ContentPage
    {
        private StackLayout InsideGeneralTipsLayout, InsideKitTipsLayout;
        private StackLayout beginingLayout;
        private Button btnShowHide1, btnShowHide2;
        private const string ARROW_DOWN = "\u25Bc";//"\u2B07";
        private const string ARROW_UP = "\u25B2";//"\u2B06";

        public FirstAid()
        {
            InitializeComponent();


            //items
            var image = new Image
            {
                Source = "first_aid_icon.png",
                WidthRequest = 150,
                HeightRequest = 150,
                MinimumHeightRequest = 150,
                MinimumWidthRequest = 150,
                HorizontalOptions = LayoutOptions.Center
            };

            var title = new Label { Text = "First Aid", FontSize = 45 };

            var intro = new Label
            {
                Text = " First Aid is essential to your upcoming camping trip. " +
                " You never know when an injury may occur, so it is best to be familiar with basic first aid. " +
                "Here you can learn general tips and ideas for creating your own first aid kit."
                ,
                FontSize = 18
            };
            intro.Margin = 20; title.HorizontalOptions = LayoutOptions.Center; intro.BackgroundColor = Color.LightGray;


            var lblBase = new Label
            {
                Text = "General Tips",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center

            }; lblBase.FontSize = 20; 

            var lblBase2 = new Label
            {
                Text = "First Aid Kit",
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
                    InsideKitTipsLayout.IsVisible = true;
                }
                else
                {
                    btnShowHide2.Text = ARROW_DOWN;
                    InsideKitTipsLayout.IsVisible = false;
                }
            };

            //layouts
            var GeneralTipsLayout = new StackLayout
            {
                Children = { btnShowHide1, lblBase },
                BackgroundColor = Color.Gray,
                Orientation = StackOrientation.Horizontal
            };GeneralTipsLayout.Margin = 10;

            var KitTipsLayout = new StackLayout
            {
                Children = { btnShowHide2, lblBase2 },
                BackgroundColor = Color.Gray,
                Orientation = StackOrientation.Horizontal
            };KitTipsLayout.Margin = 10;

            var GeneralTitle = new Label//inside panel
            {
                Text = "How to treat minor cuts and scrapes:",
                Margin = 20,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            var GeneralTitle2 = new Label//inside panel
            {
                Text = "Make sure to see a doctor if:",
                Margin = 20,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            var GeneralTitle3 = new Label//inside panel
            {
                Text = "Treating bug bites:",
                Margin = 20,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            var GeneralTitle4 = new Label//inside panel
            {
                Text = "Treating mild sprains or strains:",
                Margin = 20,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            var GeneralTipsPanel = new Label//inside panel
            {
                Text = "   Firstly, you want to keep the cut/scrape clean to avoid infection. Make sure to wash your hands and stop any bleeding." +
                " After the bleeding has stopped, clean the wound and make sure to remove any dirt or debris in the process. "
                , Margin = 20, FontSize = 18,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            var GeneralTipsPanel2 = new Label//inside panel
            {
                Text = 
                "•	You cannot stop bleeding from the wound.\n" +
                "•	Pus drains from the cut.\n" +
                "•	You have a high fever.\n" +
                "•	The wound is severe enough that you think you may need stitches.\n" +
                "•	The cut or scrape is from a dirty or rusty object.This may need to be treated with a tetanus shot."
                ,
                Margin = 20,
                FontSize = 18,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            var GeneralTipsPanel3 = new Label//inside panel
            {
                Text =
    "Make sure to remove the stinger if the insect has left one in the infected area. Wash the area with soap and water. Ice may help to reduce swelling and pain from the infected area." +
                "\n You may also apply Benadryl and antihistamine creams to the infected area to stop or prevent itching. If there is pain, ibuprofen or acetaminophen can be used to reduce pain." +
                " Remember, if the allergic reaction occurs and is serious seek medical attention immediately!" ,
                Margin = 20,
                FontSize = 18,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            var GeneralTipsPanel4 = new Label//inside panel
            {
                Text =
                "•	Keep injured body part raised by putting pillow underneath." +
                "•	Wrap in a bandage or splint.\n" +
                "•	Hold ice on limb to reduce any swelling.\n",
                Margin = 20,
                FontSize = 18,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            var KitTipsPanel = new Label//inside panel
            {
                Text = "Below is a basic list of items that may be used as a basis for creating your own kit." +
                " First aid kits can also be purchased at the store. Also, remember to consider where you are heading along with what activities are planned when gathering additional items.\n\n"+
                "•	Band Aids (various sizes)\n" +
            "•	Gauze(various sizes)\n" +
            "•	Medical adhesive tape\n" +
            "•	Antiseptic wipes\n" +
            "•	Antibiotic cream\n" +
            "•	Antibacterial ointment\n" +
            "•	Antacid Tablets\n" +
            "•	Tweezers(for splinters)\n" +
            "•	Burn cream\n" +
            "•	Benadryl cream\n" +
            "•	Antihistamine(for allergic reactions)\n" +
            "•	Ibuprofen or other pain relief medications\n" +
            "•	Safety pins\n" +
            "•	Hand sanitizer"
                ,Margin = 20,
                FontSize = 18,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            InsideGeneralTipsLayout = new StackLayout
            {
                Children = { GeneralTitle,GeneralTipsPanel,GeneralTitle2,GeneralTipsPanel2,GeneralTitle3,GeneralTipsPanel3,GeneralTitle4,GeneralTipsPanel4 },
                BackgroundColor = Color.LightGray,
                IsVisible = false
            };

            InsideKitTipsLayout = new StackLayout
            {
                Children = { KitTipsPanel },
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
            pgrDetails.PanUpdated += OnPanUpdated2;

            GeneralTipsLayout.GestureRecognizers.Add(pgrBase);
            InsideGeneralTipsLayout.GestureRecognizers.Add(pgrDetails);

            KitTipsLayout.GestureRecognizers.Add(pgrBase);
            InsideKitTipsLayout.GestureRecognizers.Add(pgrDetails);

            var layoutAll = new StackLayout
            {
                Children = { beginingLayout, GeneralTipsLayout, InsideGeneralTipsLayout, KitTipsLayout, InsideKitTipsLayout },
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
                        InsideKitTipsLayout.IsVisible = true;
                        btnShowHide2.Text = ARROW_UP;
                    }

                    if (e.TotalY < -20)
                    {
                        InsideKitTipsLayout.IsVisible = false;
                        btnShowHide2.Text = ARROW_DOWN;
                    }
                    break;
            }
        }
    }
}