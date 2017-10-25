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
        //this is just for current testing NOT FOR FINAL RELEASE
        //just so that the messages will change colors based on if it is their message
        String currentUser = "Roger";
        List<Message> MessagesList;
		public ChatPage ()
		{

            this.ToolbarItems.Add(new ToolbarItem("Group", "ChatPageGroupButtonImage.png", () =>
            {
                //What the button does when it is pressed
                Navigation.PushAsync(new ChatGroupPage());
            }));
            InitializeComponent ();
            MessagesList = new List<Message> {
                new Message{MessageText="Hi Joe how is your camp spot?", UserSent="Bill", Time="8:19 PM" },
                new Message{MessageText="Pretty good, getting dark you got a campfire started yet?", UserSent="Joe", Time="8:22 PM" },
                new Message{MessageText="Yeah I started one about an hour ago", UserSent="George", Time="8:25 PM" },
                };
            MessageListView.ItemsSource = MessagesList;
        }
        //function that is called when send button is pressed
        void OnImageTapped(object sender, EventArgs args)
        {
            var buttonSend = (Image)sender;

            //Send the message
            //for current testing we are just adding it to the data source
            MessagesList.Add(new Message{ MessageText = Editor_Chat.Text, UserSent = currentUser, Time = DateTime.Now.ToString("h:mm tt")});
            MessageListView.ItemsSource = null;
            MessageListView.ItemsSource = MessagesList;
            //show a display to prove that the button has been clicked
            DisplayAlert("Title","Message","Quit");
        }
        
        
    }
}