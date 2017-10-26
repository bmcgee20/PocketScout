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
    public partial class ChatTextPageMaster : ContentPage
    {
        public ListView ListView;

        public ChatTextPageMaster()
        {
            InitializeComponent();

            BindingContext = new ChatTextPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class ChatTextPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ChatTextPageMenuItem> MenuItems { get; set; }
            
            public ChatTextPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<ChatTextPageMenuItem>(new[]
                {
                    new ChatTextPageMenuItem { Id = 0, Title = "Page 1" },
                    new ChatTextPageMenuItem { Id = 1, Title = "Page 2" },
                    new ChatTextPageMenuItem { Id = 2, Title = "Page 3" },
                    new ChatTextPageMenuItem { Id = 3, Title = "Page 4" },
                    new ChatTextPageMenuItem { Id = 4, Title = "Page 5" },
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