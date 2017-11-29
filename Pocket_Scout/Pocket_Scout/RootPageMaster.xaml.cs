using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pocket_Scout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootPageMaster : ContentPage
    {
        public ListView ListView;

        public RootPageMaster()
        {
            InitializeComponent();

            BindingContext = new RootPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class RootPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<RootPageMenuItem> MenuItems { get; set; }
            
            public RootPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<RootPageMenuItem>(new[]
                {
                    //Utilities and Weather links must direct to respective pages
                    new RootPageMenuItem { Id = 0, Title = "Geolocator", TargetType = typeof(RootPageDetail) },
                    new RootPageMenuItem { Id = 1, Title = "Camping List", TargetType = typeof(CampingListPage) },
                    new RootPageMenuItem { Id = 2, Title = "Utilities", TargetType = typeof(MainPage) },
                    new RootPageMenuItem { Id = 3, Title = "Camping Guides", TargetType = typeof(Survival_Guide) },
                    new RootPageMenuItem { Id = 4, Title = "Group Manager", TargetType = typeof(GroupManager) },
                    new RootPageMenuItem { Id = 5, Title = "Chat Room", TargetType = typeof(ChatPage) },
                    new RootPageMenuItem { Id = 6, Title = "Weather", TargetType = typeof(MainPage) },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}