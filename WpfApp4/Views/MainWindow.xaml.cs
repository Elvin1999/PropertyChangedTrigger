using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp4.ViewModel;
using System.Collections.ObjectModel;
namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel MainViewModel { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel = new MainViewModel();
            MainViewModel.AllUsers = new ObservableCollection<Entities.User>() {
                new Entities.User()
                {
                    Id=1,Name="Elvin",Surname="Camalzade",Age=19
                },
                 new Entities.User()
                {
                    Id=2,Name="Elvin",Surname="Camalzade",Age=19
                },
                  new Entities.User()
                {
                    Id=3,Name="Elvin",Surname="Camalzade",Age=19
                },
                   new Entities.User()
                {
                    Id=4,Name="Elvin",Surname="Camalzade",Age=19
                }
            };

            DataContext = MainViewModel;

        }
    }
}
