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
            this.ToolbarItems.Add(new ToolbarItem("Add", "PlusPicture.png", () =>
            {
                //add a new item
            }));
            InitializeComponent();
            CampingListViewer.ItemsSource = new List<CampingItem> {
                new CampingItem{Item="Potato",Quantity="1 Bag",Person="John"},
                new CampingItem{Item="Carrots",Quantity="1 Bag",Person="Bill"},
                new CampingItem{Item="Tent",Quantity="1",Person="George"},
                new CampingItem{Item="Lighter Fluid",Quantity="1 Can",Person="John"},
                new CampingItem{Item="Sleeping Bag",Quantity="1 Each",Person="All"},
                new CampingItem{Item="Axe",Quantity="1",Person="George"},
                };
        }
        void OnAddItem(object sender, EventArgs args)
        {
            return;
            //let the user add a new one
        }
    }
}