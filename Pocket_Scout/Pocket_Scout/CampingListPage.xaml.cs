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
        List<CampingItem> testList = new List<CampingItem> {
                new CampingItem{Item="Potato",Quantity="1 Bag",Person="John"},
                new CampingItem{Item="Carrots",Quantity="1 Bag",Person="Bill"},
                new CampingItem{Item="Tent",Quantity="1",Person="George"},
                new CampingItem{Item="Lighter Fluid",Quantity="1 Can",Person="John"},
                new CampingItem{Item="Sleeping Bag",Quantity="1 Each",Person="All"},
                new CampingItem{Item="Axe",Quantity="1",Person="George"},
                };
        //TO DO: let the user delete entries in the list view
        public CampingListPage ()
		{
			InitializeComponent ();

            //Just populates the list view for testing purposes
            CampingListViewer.ItemsSource = testList;
        }
        //false it item is not being added true otherwise
        Boolean ItemBeingAdded = false;
        void OnAddItem(object sender, EventArgs args)
        {
            Image addImage = (Image)sender;
            if (ItemBeingAdded == false)
            {
                //need to switch to item being added
                ItemBeingAdded = true;
                addImage.RelRotateTo(360, 500);
                addImage.Source = "FinishedImage.png";
                StackAdd.IsVisible = true;
            }
            else
            {
                //Clicked the finished button so close out the stacklayout and add it to listview
                StackAdd.IsVisible = false;
                addImage.RelRotateTo(-360, 500);
                addImage.Source = "PlusPicture.png";
                //add to listview
                testList.Add(new CampingItem { Item = StackAddItem.Text, Quantity = StackAddQuantity.Text, Person = StackAddPerson.Text });
                //add to databse here
            }
        }
    }
}