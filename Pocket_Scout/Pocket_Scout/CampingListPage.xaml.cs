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
            plus.RotateTo(360, 1000);
            //Add a label for them to input their camping stuff here
            CampingListGrid.Children.Add(new Editor { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.Start }, 0, i);
            CampingListGrid.Children.Add(new Editor { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.Start }, 1, i);
            CampingListGrid.Children.Add(new Editor { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.Start }, 2, i);
            i++;
        }

    }
}