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
	public partial class CampingListPage : ContentPage
	{   
        //the current rows added through the button
        int i = 2;
		public CampingListPage ()
		{
			InitializeComponent ();
		}
        //When the plus button is clicked
        void OnAdditionClicked(object sender, EventArgs args)
        {
            Image plus = (Image)sender;
            //rotate image X degrees in 1 second
            if (i % 2 == 0)
            {
                plus.RotateTo(360, 1000);
            }
            else
            {
                plus.RotateTo(0, 1000);
            }
            
            //Add a label for them to input their camping stuff here
            CampingListGrid.Children.Add(new Editor {Text="Potatoes", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.Start, Keyboard=Keyboard.Chat, IsEnabled =false }, 0, i);
            CampingListGrid.Children.Add(new Editor {Text="1 Bag", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.Start, Keyboard=Keyboard.Chat }, 1, i);
            CampingListGrid.Children.Add(new Editor {Text="John", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.Start, Keyboard= Keyboard.Chat}, 2, i);
            CampingListGrid.Children.Add(new Image { Source = "FinishedImage.png", VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center, Aspect = Aspect.AspectFit, HeightRequest = 10 },3,i);
            i++;
        }

    }
}