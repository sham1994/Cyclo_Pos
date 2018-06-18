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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for SearchItem.xaml
    /// </summary>
    public partial class SearchItem : Window
    {
        
        public SearchItem()
        {
            InitializeComponent();
             FillDataGrid();

           

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
                grdItems.ItemsSource = dt.DefaultView;



            }

        }

        private void txt_SearchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string Constring = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(Constring))
                {
                    CmdString = "SELECT Stock_Cat,Descrip,Sales_P FROM Stock_Card WHERE Descrip LIKE '%" + txt_SearchName.Text + "%'";
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("ItemDetails");
                    sda.Fill(dt);
                    grdItems.ItemsSource = dt.DefaultView;




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (String.IsNullOrEmpty(txt_SearchName.Text))
            {
                FillDataGrid();
            }

           



        }
        

    private void txt_Searchcode_TextChanged(object sender, TextChangedEventArgs e)
            {
            if (String.IsNullOrEmpty(txt_SearchName.Text))
            {
                try
                {
                    string Constring = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
                    string CmdString = string.Empty;
                    using (SqlConnection con = new SqlConnection(Constring))
                    {
                        CmdString = "SELECT Stock_Cat,Descrip,Sales_P FROM Stock_Card WHERE Stock_Cat LIKE '%" + txt_Searchcode.Text + "%'";
                        SqlCommand cmd = new SqlCommand(CmdString, con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("ItemDetails");
                        sda.Fill(dt);
                        grdItems.ItemsSource = dt.DefaultView;




                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!String.IsNullOrEmpty(txt_SearchName.Text))
            {
                try
                {
                    string Constring = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
                    string CmdString = string.Empty;
                    using (SqlConnection con = new SqlConnection(Constring))
                    {
                        CmdString = "SELECT Stock_Cat,Descrip,Sales_P FROM Stock_Card WHERE Stock_Cat LIKE '%" + txt_Searchcode.Text + "%' and Descrip LIKE '%" + txt_SearchName.Text + "%'" ;
                        SqlCommand cmd = new SqlCommand(CmdString, con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("ItemDetails");
                        sda.Fill(dt);
                        grdItems.ItemsSource = dt.DefaultView;




                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            

        }

        private void txt_Searchcode_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textbox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txt_SearchName.Focus();
        }
    }
    }

   

