using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            FillDataGrid();
           // FillDataGridTest();
        }
        public void PassValue(string strvalue)
        {
            var data = new DataGetSet { productname = strvalue };
            dg_main.Items.Add(data);
           
            
            
            
            
            
            
            
            
            // dg_main.Items.Add(new { Product_Code="Happy People"  });
           // this.txt_schbyname.Text = strvalue;
        }
        
        public void FillDataGrid()
        {
            string Constring = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(Constring))
            {
                CmdString = "SELECT Stock_Cat,Descrip,Sales_P FROM Stock_Card";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("ItemDetails");
                sda.Fill(dt);
                dg_mainmenu2.ItemsSource = dt.DefaultView;



            }


        }
        public void FillDataGridTest()
        {
            string Constring = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(Constring))
            {
                CmdString = "SELECT Stock_Cat,Descrip,Sales_P FROM Stock_Card";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("ItemDetails");
                sda.Fill(dt);
                dg_main.ItemsSource = dt.DefaultView;



            }


        }

        private void Main_Close2_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Do you want to exit?", "Confermation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {


                for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--)
                    App.Current.Windows[intCounter].Close();
            }
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

        private void txt_schbycode_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= txt_schbycode_GotFocus;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            //TextBox tb = (TextBox)sender;
            //tb.Text = string.Empty;
            //tb.GotFocus -= TextBox_GotFocus;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //  txt_schbycode.Visibility = Visibility.Hidden;
            cc_grid2.Visibility = Visibility.Hidden;

        }

        private void txt_schbyname_GotFocus(object sender, RoutedEventArgs e)
        {
            //TextBox tb = (TextBox)sender;
            //tb.Text = string.Empty;
            //tb.GotFocus -= txt_schbyname_GotFocus;
        }

        private void btn_schbycode_Click(object sender, RoutedEventArgs e)
        {
            //  txt_schbycode.Visibility = Visibility.Visible;
            //  txt_schbycode.Focus();

            txt_schbyname.Visibility = Visibility.Hidden;


        }

        private void schbyname_Click(object sender, RoutedEventArgs e)
        {

            txt_schbyname.Visibility = Visibility.Visible;
            txt_schbyname.Focus();

            // txt_schbycode.Visibility = Visibility.Hidden;
        }

        private void btn_newsale_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to close this window and create a new invoice", "Confermation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {

                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                Application.Current.Shutdown();


            }



        }

        private void txt_schbycode_LostFocus(object sender, RoutedEventArgs e)
        {
            //if(txt_schbycode.Text == "" )
            //  {
            //      txt_schbycode.Text = "Search product by code";

            //  }
        }

        private void txt_schbyname_LostFocus(object sender, RoutedEventArgs e)
        {
            //if (txt_schbyname.Text == "")
            //{
            //    txt_schbyname.Text = "Search product by product name";
            //}
        }

        private void Txt_schbyname_TextChanged(object sender, TextChangedEventArgs e)
        {







        }

        private void txt_schbyname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.RightShift)
            {
                if (cc_grid2.Visibility == Visibility.Visible)
                {
                    cc_grid2.Visibility = Visibility.Hidden;

                }
                else
                {
                    cc_grid2.Visibility = Visibility.Visible;
                }

            }
        }

        private void txt_schbyname_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            datatabletextchange();
            cc_grid2.Visibility = Visibility.Visible;
        }

        public void datatabletextchange()
        {


            try
            {
                string Constring = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(Constring))
                {
                    CmdString = "SELECT Stock_Cat,Descrip,Sales_P FROM Stock_Card WHERE Descrip LIKE '%" + txt_schbyname.Text + "%'";
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("ItemDetails");
                    sda.Fill(dt);
                    dg_mainmenu2.ItemsSource = dt.DefaultView;




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dg_mainmenu2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row_selected = dg.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                txt_schbyname.Text = row_selected["Descrip"].ToString();

                SelectedItem dd = new SelectedItem(this);
                dd.txt_pn.Text = row_selected["Descrip"].ToString();
                dd.txt_pup.Text = row_selected["Sales_P"].ToString();
                dd.txt_pc.Text = row_selected["Stock_Cat"].ToString();
                dd.Show();
            
            }
            
        }



        private void Dg_mainmenu2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //DataGrid dg = (DataGrid)sender;
            //DataRowView row_selected = dg.SelectedItem as DataRowView;
            //if (row_selected != null)
            //{
            //    txt_schbyname.Text = row_selected["Descrip"].ToString();
            //}
        }

        private void Btn_mmQty_Click(object sender, RoutedEventArgs e)
        {

            SelectedItem dt = new SelectedItem(this);
            
            dt.Show();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btn_insertclose_Click(object sender, RoutedEventArgs e)
        {
            //cc_inmenu.Visibility = Visibility.Collapsed;
        }
    }
    public class DataGetSet
    {

        public string productname { get; set; }

    }
}
