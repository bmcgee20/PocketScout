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
            MessageLister.ItemsSource = new List<GroupMember> {
                new GroupMember{Name="John", LastOnline="10/21/17" },
                new GroupMember{Name="Bill", LastOnline="8:21 pm" }
                };

        }
	}
}