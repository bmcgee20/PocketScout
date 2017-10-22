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
	public partial class ChatGroupPage : ContentPage
	{
		public ChatGroupPage ()
		{
			InitializeComponent ();
            //TO DO: Get members names from data base and last online 
            MessageLister.ItemsSource = new List<GroupMember> {
                new GroupMember{Name="John Doe", LastOnline="Last Seen at 10/21/17" },
                new GroupMember{Name="Bill Shepard", LastOnline="Last Seen at 8:21 pm" }
                };
        }
        //Hold finger on the user then select prompt to delete user from group
        public void OnRemoveUser(object sender, EventArgs e)
        {
            var menuItemRemove = ((MenuItem)sender);
            DisplayAlert("Group Changed:", "User was removed", "Proceed");
            //TO DO: implmenent functionality of deleting user
        }
        //if a group member is selected
        /*
        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
        }
        */
    }
}