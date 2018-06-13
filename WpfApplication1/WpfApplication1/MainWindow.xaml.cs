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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Main_Next_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Visibility = Visibility.Collapsed;
            Window1 win = new Window1();
            MainGrid.Visibility = Visibility.Hidden;
            main_grid2.Visibility = Visibility.Visible;
            win.Show();

        }

        private void Window_Activated(object sender, EventArgs e)
        {
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            if (MainGrid.Visibility == Visibility.Hidden || MainGrid.Visibility == Visibility.Collapsed)
            {
                MainGrid.Visibility = Visibility.Visible;
                main_grid2.Visibility = Visibility.Hidden;
            }
        }

        private void Main_Close_Click(object sender, RoutedEventArgs e)
        {
            CloseAllWindows(); 
        }

        private void Win1_Next_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Main_Close_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void fnt5_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Main_Close_MouseEnter(object sender, MouseEventArgs e)
        {
            fnt5.Foreground = new SolidColorBrush(Colors.Red);      
                
        }
        private void CloseAllWindows()
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--)
                App.Current.Windows[intCounter].Close();
        }

        private void Main_Finish_Click(object sender, RoutedEventArgs e)
        {
            CloseAllWindows();
        }
    }
}
