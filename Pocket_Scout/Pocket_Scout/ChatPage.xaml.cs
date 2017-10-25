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
                new Message{MessageText="Hi Joe how is your camp spot?", UserSent="Bill", Time="8:19 PM", NotSameUser = true, colorMessage ="White" },
                new Message{MessageText="Pretty good, getting dark you got a campfire started yet?", UserSent="Joe", Time="8:22 PM", NotSameUser = true, colorMessage ="White" },
                new Message{MessageText="Yeah I started one about an hour ago", UserSent="George", Time="8:25 PM", NotSameUser = true , colorMessage ="White"},
                };
            MessageListView.ItemsSource = MessagesList;
        }
        //function that is called when send button is pressed
        void OnImageTapped(object sender, EventArgs args)
        {
            var buttonSend = (Image)sender;
            //Need to change format for user sent texts
            //if last message was from the same user dont show name
            /*int count = MessagesList.Count;
            if (count>0 && MessagesList[count-1].UserSent.Equals(currentUser))
            {
                //should be false here in final version
                MessagesList.Add(new Message { MessageText = Editor_Chat.Text, UserSent = null, Time = DateTime.Now.ToString("h:mm tt"), NotSameUser = true, colorMessage ="Green" });
            }
            else
            {
                MessagesList.Add(new Message { MessageText = Editor_Chat.Text, UserSent = currentUser, Time = DateTime.Now.ToString("h:mm tt"), NotSameUser = true , colorMessage = "White" });

            }*/


            //Send the message
            MessagesList.Add(new Message { MessageText = Editor_Chat.Text, UserSent = "Roger", Time = DateTime.Now.ToString("h:mm tt"), NotSameUser = false, colorMessage = "Green" });
            //for current testing we are just adding it to the data source
            //need to reformat the message to: change text to right align, background color to green with opacity 
            MessageListView.ItemsSource = null;
            MessageListView.ItemsSource = MessagesList;
            //reset text and hide keyboard
            Editor_Chat.Text = "";
            Editor_Chat.Unfocus();
        }        
    }
}