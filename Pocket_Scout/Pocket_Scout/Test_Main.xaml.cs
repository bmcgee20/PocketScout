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
	public partial class Test_Main : ContentPage
	{
		public Test_Main ()
		{
			InitializeComponent ();
		}
        void ButtonClicked(object sender, EventArgs args)
        {
            //push the next page onto the navigation
            Navigation.PushAsync(new ChatPage());
        }
    }
}