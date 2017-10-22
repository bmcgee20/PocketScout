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
        //TO DO: let the user delete and edit entries in the list view
        //let a user cancel creating a new entry once they select creation
        List<CampingItem> testList = new List<CampingItem> {
                new CampingItem{Item="Potato",Quantity="1 Bag",Person="John"},
                new CampingItem{Item="Carrots",Quantity="1 Bag",Person="Bill"},
                new CampingItem{Item="Tent",Quantity="1",Person="George"},
                new CampingItem{Item="Lighter Fluid",Quantity="1 Can",Person="John"},
                new CampingItem{Item="Sleeping Bag",Quantity="1 Each",Person="All"},
                new CampingItem{Item="Axe",Quantity="1",Person="George"},
                };
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
            //item was not being added so add one here
            if (ItemBeingAdded == false)
            {
                //make the rest of UI disappear for adding data
                CampingListGrid.IsVisible = false;
                CampingListDivider.IsVisible = false;
                CampingListViewer.IsVisible = false;
                //need to switch to item being added
                ItemBeingAdded = true;
                addImage.RelRotateTo(360, 500);
                addImage.Source = "FinishedImage.png";
                StackAdd.Padding = 10;
                StackAdd.IsVisible = true;
            }
            else
            {
                ItemBeingAdded = false;
                
                //Clicked the finished button so close out the stacklayout and add it to listview
                StackAdd.IsVisible = false;
                StackAdd.Padding = 0;
                addImage.RelRotateTo(-360, 500);
                addImage.Source = "PlusPicture.png";
                //add to listview
                testList.Add(new CampingItem { Item = StackAddItem.Text, Quantity = StackAddQuantity.Text, Person = StackAddPerson.Text });
                //reset text to blank on editors so that next time it pops up it wont have last entry
                StackAddItem.Text = "";
                StackAddPerson.Text = "";
                StackAddQuantity.Text = "";
                //turn back on the rest of the UI
                StackAddItem.Unfocus(); StackAddPerson.Unfocus();StackAddQuantity.Unfocus();
                CampingListGrid.IsVisible = true;
                CampingListDivider.IsVisible = true;
                CampingListViewer.IsVisible = true;
                //add to databse here
            }
        }
        //when you press enter or done in any of the adds it should move to next text box
        void StackAddTextComplete(object sender, EventArgs args)
        {
            Entry currentEditor = (Entry)sender;
            currentEditor.Unfocus();
            if (currentEditor == StackAddItem)
            {
                StackAddQuantity.Focus();
            }else if (currentEditor == StackAddQuantity)
            {
                StackAddPerson.Focus();
            }
            else
            {
                StackAddPerson.Unfocus();
            }
        }
    }
}