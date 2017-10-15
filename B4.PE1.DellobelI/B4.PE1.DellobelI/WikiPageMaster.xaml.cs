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

namespace B4.PE1.DellobelI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WikiPageMaster : ContentPage
    {
        public ListView ListView;

        public WikiPageMaster()
        {
            InitializeComponent();

            BindingContext = new WikiPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class WikiPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<WikiPageMenuItem> MenuItems { get; set; }

            public WikiPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<WikiPageMenuItem>(new[]
                {
                    new WikiPageMenuItem { Id = 0, Title = "\u2302   Startpagina" },
                    new WikiPageMenuItem { Id = 1, Title = "\u2684   Willekeurig" },
                    new WikiPageMenuItem { Id = 2, Title = "\u2B07   In de buurt" },
                    new WikiPageMenuItem { Id = 3, Title = "\u33D2   Aanmelden" },
                    new WikiPageMenuItem { Id = 4, Title = "\u2699   Instellingen" },
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