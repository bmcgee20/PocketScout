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
        public GroupManager ()
		{
            
            InitializeComponent();
            AddMemberView.IsVisible = false;
            CurrentGroupView.IsVisible = false;

        }
        //TO DO: add a click on list items to invite the results that you obtain
        private void MemberSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var keyword = MemberSearchBar.Text;
            //will return all the near searchs in list
            var searchresults = from x in groups where x.ToLower().Contains(keyword.ToLower()) select x;

            SearchResultList.ItemsSource = searchresults;
        }
    }
}