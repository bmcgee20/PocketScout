using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pocket_Scout
{
    /*
     * TO DO: Implement deleting members from current group
     *          Who is able to delete members? anyone or just group leader
     *          who is able to add members? anyone or just group leader
     *    What should the parameters for the search members functionality be?
     *          should they only be able to input a user name or search based on contains
     *              I can see the search based on contains being abused and people just trying to add randoms
     *    DONE: implement adding members form the search view
     *    Need someway to get back to group list from the search page
     *    implement actual accepting a invite, this requires the database though so saved for next story
     */
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupManager : ContentPage
    {
        List<string> usernameList = new List<string>
        {
            "John", "Jeff", "Jerry", "Jeffry","Jill","George","Johnny","Bill",
        };
        List<string> currentgroup = new List<string>
        {
            "sue","wayne", "miller", "mason","colton",
        };
        List<Invites> invitelist = new List<Invites>
            {
                new Invites{Username = "Bob Dole", IsVisible = false},
                new Invites{Username = "Sam", IsVisible = false},
                new Invites{Username = "Bill", IsVisible = false},
            };
        Invites lastTappedInvite = null;
        public GroupManager()
        {

            InitializeComponent();
            AddMemberView.IsVisible = false;
            CurrentGroupView.IsVisible = false;
            GroupMemberList.ItemsSource = currentgroup;
            InvitesList.ItemsSource = invitelist;

        }
        //TO DO: add a click on list items to invite the results that you obtain
        private void MemberSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var keyword = MemberSearchBar.Text;
            //will return all the near searchs in list
            var searchresults = from x in usernameList where x.ToLower().Contains(keyword.ToLower()) select x;
            SearchResultList.ItemsSource = searchresults;


        }
        //makes a new group
        //button location is on the invite list if you click the plus it will make a new group
        void MakeNewGroup(object sender, EventArgs args)
        {
            //create the new group in the database here
            InviteGroupView.IsVisible = false;
            CurrentGroupView.IsVisible = true;
        }

        //if you press an invite it will show the buttons under it (invite list view)
        private void InvitesList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var invite = e.Item as Invites;
            if(invite.IsVisible == false)
            {
                invitelist[invitelist.IndexOf(invite)].IsVisible = true;
            }
            else
            {
                invitelist[invitelist.IndexOf(invite)].IsVisible = false;
            }
            //just close any other open invite
            if (lastTappedInvite != null)
            {
                //if the last one is still open and not just a double click on the same one after close
                if (lastTappedInvite.IsVisible == true && lastTappedInvite!=invite)
                {
                    invitelist[invitelist.IndexOf(lastTappedInvite)].IsVisible = false;
                }
            }
            lastTappedInvite = invite;
            InvitesList.ItemsSource = null;
            InvitesList.ItemsSource = invitelist;
        }

        //if you press the accept button under invite list view
        private void Btn_InviteAccept_Clicked(object sender, EventArgs e)
        {
            //join this user to said group

            //TO DO: do this once begin working on server side part
        }
        //if you press the decline button under invite listview
        private void Btn_InviteDecline_Clicked(object sender, EventArgs e)
        {
            //just remove the invite from the list
            
            Button btn = (Button)sender;
            Invites deleteInvite = lastTappedInvite;
            invitelist.RemoveAt(invitelist.IndexOf(lastTappedInvite));
            InvitesList.ItemsSource = null;
            InvitesList.ItemsSource = invitelist;
            lastTappedInvite = null;
        }

        //if on current group view and click plus open the add member view
        private void AddMember(object sender, EventArgs e)
        {
            CurrentGroupView.IsVisible = false;
            AddMemberView.IsVisible = true;
        }
        //if you click on a result in the search member list
        private async void  SearchResultList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //string user = (string)sender;
            //notify you to make sure you want to add them
            var user = e.Item as string;

            var DoWeNotAddUser = await DisplayAlert("Add Member", "Add member "+ user+"?", "No", "Yes");
            if(DoWeNotAddUser)
            {
                //if they chose no
                //do nothing
            }
            else
            {
                //add user to group in database
                currentgroup.Add(user);
                //reset data in list
                GroupMemberList.ItemsSource = null;
                GroupMemberList.ItemsSource = currentgroup;
                //change views
                AddMemberView.IsVisible = false;
                CurrentGroupView.IsVisible = true;
                //reset the search results
                MemberSearchBar.Text = "";
                SearchResultList.ItemsSource = null;
                
            }
        }
    }
}