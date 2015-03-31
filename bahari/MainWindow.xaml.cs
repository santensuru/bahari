using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Navigation;
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

namespace bahari
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Bahari - Main Home :)";
        }

        private void Map_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ModernDialog.ShowMessage("Map", ":)", MessageBoxButton.OK);
        }

        private void AboutUs_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ModernDialog.ShowMessage("About Us", ":)", MessageBoxButton.OK);
            //NavigationService nav = NavigationService.GetNavigationService(this);
            //nav.Navigate(new Uri("AboutUs.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Galery_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ModernDialog.ShowMessage("Gallery", ":)", MessageBoxButton.OK);
        }

        private void Appendix_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ModernDialog.ShowMessage("Appendix", ":)", MessageBoxButton.OK);
        }

        private void Games_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ModernDialog.ShowMessage("Games", ":)", MessageBoxButton.OK);
        }

        private void Me_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ModernDialog.ShowMessage("Me", ":)", MessageBoxButton.OK);
        }

        private void Information_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ModernDialog.ShowMessage("Information", ":)", MessageBoxButton.OK);
        }
    }
}
