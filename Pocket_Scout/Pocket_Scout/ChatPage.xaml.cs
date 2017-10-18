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
	public partial class ChatPage : ContentPage
	{
		public ChatPage ()
		{

            this.ToolbarItems.Add(new ToolbarItem("Group", "ChatPageGroupButtonImage.png", () =>
            {
                //What the button does when it is pressed
                Navigation.PushAsync(new ChatGroupPage());
            }));
            InitializeComponent ();
		}
        //function that is called when send button is pressed
        void OnImageTapped(object sender, EventArgs args)
        {
            var buttonSend = (Image)sender;

            //Send the message

            //show a display to prove that the button has been clicked
            DisplayAlert("Title","Message","Quit");
        }
        
        
    }
}