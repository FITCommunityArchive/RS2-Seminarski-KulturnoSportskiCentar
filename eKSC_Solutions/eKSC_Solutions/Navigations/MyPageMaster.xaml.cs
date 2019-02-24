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

namespace eKSC_Solutions.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPageMaster : ContentPage
    {
        public ListView ListView;

        public MyPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MyPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyPageMenuItem> MenuItems { get; set; }
            
            public MyPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MyPageMenuItem>(new[]
                {new MyPageMenuItem {  Title = "Main menu" ,ImageSource= "home.png",TargetType=typeof(MainPage)},
                    new MyPageMenuItem {  Title = "Termini", ImageSource= "termini1.png",TargetType=typeof(Termini)},
                    new MyPageMenuItem { Title = "Javni događaji" ,ImageSource= "javni.png",TargetType=typeof(JavniDogadjaji)},
                    new MyPageMenuItem {  Title = "Događaji za posjetit" ,ImageSource= "remainder.png",TargetType=typeof(DogadjajiZaPrisustvovati)},
                    new MyPageMenuItem {  Title = "Vlastiti događaji" ,ImageSource= "vlastiti_dogadjaji.png",TargetType=typeof(VlastitiDogadjaji)},
                    new MyPageMenuItem { Title = "Profil" ,ImageSource= "profil.png",TargetType=typeof(Profil)},
                  new MyPageMenuItem { Title = "Odjava" ,ImageSource= "logout.png",TargetType=typeof(Login)},


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