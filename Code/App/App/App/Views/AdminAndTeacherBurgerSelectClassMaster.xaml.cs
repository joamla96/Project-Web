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

namespace App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminAndTeacherBurgerSelectClassMaster : ContentPage
    {
        public ListView ListView;

        public AdminAndTeacherBurgerSelectClassMaster()
        {
            InitializeComponent();

            BindingContext = new AdminAndTeacherBurgerSelectClassMasterViewModel();
            ListView = MenuItemsListView;
        }

        class AdminAndTeacherBurgerSelectClassMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<AdminAndTeacherBurgerSelectClassMenuItem> MenuItems { get; set; }
            
            public AdminAndTeacherBurgerSelectClassMasterViewModel()
            {
                MenuItems = new ObservableCollection<AdminAndTeacherBurgerSelectClassMenuItem>(new[]
                {
                    new AdminAndTeacherBurgerSelectClassMenuItem { Id = 0, Title = "Page 1" },
                    new AdminAndTeacherBurgerSelectClassMenuItem { Id = 1, Title = "Page 2" },
                    new AdminAndTeacherBurgerSelectClassMenuItem { Id = 2, Title = "Page 3" },
                    new AdminAndTeacherBurgerSelectClassMenuItem { Id = 3, Title = "Page 4" },
                    new AdminAndTeacherBurgerSelectClassMenuItem { Id = 4, Title = "Page 5" },
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