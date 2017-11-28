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
	public partial class Survival_Guide : CarouselPage
	{
		public Survival_Guide ()
		{
			InitializeComponent ();


		}
        void AnimalButtonClicked(object sender, EventArgs e)
        {

            this.CurrentPage = this.Children[2];

        }
        void FAidButtonClicked(object sender, EventArgs e)
        {
            this.CurrentPage = this.Children[1];
        }

    }


}