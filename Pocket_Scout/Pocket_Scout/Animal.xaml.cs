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
    public partial class Animal : ContentPage
    {
        public Animal()
        {
            InitializeComponent();
            var layout = new StackLayout { Padding = new Thickness(5, 10) };
            this.Content = new ScrollView { Content = layout };

            var title = new Label { Text = "Animal Guide", FontSize = 45 };
            var intro = new Label
            {
                Text = "  You will encounter various wildlife throughout your camping endeavors.  " +
                "Below are general tips on how to avoid attracting wildlife to your campsite. "
                ,FontSize = 20
            };
            var bring = new Label { Text = "General tips- \n" +
"•	Animals may infest your campsite while looking for food. To avoid this, keep any food inside containers like coolers with a lock on its lid.\n" +
" You can tie a rope around the container and hang it 7 feet above the ground. The goal here is to get the food away from the reach of an animal such as a bear.\n" +
"It is also a good idea to hang your food a good distance from your campsite in case any animals are attracted to it.\n" +
"•	Take care of any leftovers after a meal and make sure none is left exposed. Throw away trash in odor proof bags to avoid the smell of food.\n" +
"•	Wash dishes and utensils after use to get off any food particles.\n" +
"•	Avoid lotions or anything with a noticeable scent. Various scents can attract animals looking for food.\n" +
"•	Depending on your location, it may be a good idea to ask any park rangers for tips on the local animals and how to navigate around them safely.\n" +

"\nPlanning on hiking?" +
"\nHere are more tips on avoiding/interacting with animals safely:\n" +
"•	Do not approach wild animals.You especially do not surprise any that you encounter.Some animals may attack if they feel threatened.\n" +
"•	Avoid hiking at night or off the trail. It is also a good idea to hike with a partner.\n" +
"•	Watch for any signs of tracks, droppings, or scratches on trees.This may indicate an animal is nearby and to be cautious.\n" +
"•	Try to make noise while hiking so animals know of your presence. Some good ideas are to clap your hands, sing, or talk.\n"
, FontSize = 20 };
            layout.Children.Add(title);
            layout.Children.Add(intro);
            layout.Children.Add(bring);
        }
    }
}