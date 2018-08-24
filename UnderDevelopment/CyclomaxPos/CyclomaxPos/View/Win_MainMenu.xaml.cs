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

namespace CyclomaxPos.View
{
    /// <summary>
    /// Interaction logic for Win_MainMenu.xaml
    /// </summary>
    public partial class Win_MainMenu : Window
    {
        public Win_MainMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void HamburgerMenuControl_OnItemClick(object sender, MahApps.Metro.Controls.ItemClickEventArgs e)
        {
           
           
                // set the content
                this.HamburgerMenuControl.Content = e.ClickedItem;
                // close the pane
                this.HamburgerMenuControl.IsPaneOpen = false;
            if (Grd_Main.Visibility == Visibility.Visible)
            {
                Grd_Main.Visibility = Visibility.Hidden;

            }
        
        }
    }
}
