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
    public partial class GroupManager : ContentPage
    {
        List<string> groups = new List<string>
        {
            "John", "Jeff", "Jerry", "Jeffry","Jill","George","Johnny","Bill",
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
            GroupMemberList.ItemsSource = groups;
            InvitesList.ItemsSource = invitelist;

        }
        //TO DO: add a click on list items to invite the results that you obtain
        private void MemberSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var keyword = MemberSearchBar.Text;
            //will return all the near searchs in list
            var searchresults = from x in groups where x.ToLower().Contains(keyword.ToLower()) select x;
            SearchResultList.ItemsSource = searchresults;


        }
        void MakeNewGroup(object sender, EventArgs args)
        {

        }

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
    }
}