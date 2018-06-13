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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Main_Menu.xaml
    /// </summary>
    public partial class Main_Menu : Window
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Close2_Click(object sender, RoutedEventArgs e)
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--)
                App.Current.Windows[intCounter].Close();
        }

        private void Main_Settings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCloseMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_2menu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainGrid_GotFocus(object sender, RoutedEventArgs e)
        {


            
          


          
                
                
                
            
           

          
        }

        private void GridMenu_LostFocus(object sender, RoutedEventArgs e)
        {
            GridMenu.Visibility = Visibility.Collapsed;
        }

        private void btn_mmSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchItem t = new SearchItem();
            t.Show();
        }
    }
}
