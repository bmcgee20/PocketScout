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
    public partial class FirstAid : ContentPage
    {
        public FirstAid()
        {
            InitializeComponent();
            var layout = new StackLayout { Padding = new Thickness(5, 10) };
            this.Content = new ScrollView { Content = layout };

            var title = new Label { Text = "First Aid", FontSize = 45 };
            var intro = new Label
            {
                Text = "  First Aid is essential to your upcoming camping trip." +
                " You never know when an injury may occur, so it is best to make sure you have a well-stocked first aid kit." +
                "\nBelow is a basic list of items that may be used as a basis for creating your own kit. First Aid kits can also be bought at a store." +
                " Also, remember to consider where you are heading along with what activities are planned when gathering additional items.",
                FontSize = 20
            };
            var bring = new Label { Text = "•	Band Aids (various sizes)\n" +
            "•	Gauze(various sizes)\n" +
            "•	Medical adhesive tape\n" +
            "•	Antiseptic wipes\n" +
            "•	Antibiotic cream\n" +
            "•	Antibacterial ointment\n" +
            "•	Antacid Tablets\n" +
            "•	Tweezers(for splinters)\n" +
            "•	Burn cream\n" +
            "•	Benadryl cream\n" +
            "•	Antihistamine(for allergic reactions)\n" +
            "•	Ibuprofen or other pain relief medications\n" +
            "•	Safety pins\n" +
            "•	Hand sanitizer\n", FontSize = 20};
            layout.Children.Add(title);
            layout.Children.Add(intro);
            layout.Children.Add(bring);
        }
    }
	

}