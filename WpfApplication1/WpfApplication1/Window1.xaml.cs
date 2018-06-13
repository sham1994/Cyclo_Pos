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
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Navigation;
using System.Windows.Threading;
using System.ComponentModel;
using System.Xml;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"server=DESKTOP-9RNM4P1;user id=cmx;password=cmx3212; database=Cyclo_Test");


        private void Win2_Prev_Click(object sender, RoutedEventArgs e)
        {
            G1.Visibility = Visibility.Visible;
            G2.Visibility = Visibility.Hidden;
        }

        private void Win1_Next_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(g1_txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                //MessageBox.Show("Enter a valid email.");
                
                txt_msg.Visibility = Visibility.Visible;
                g1_txt_email.BorderBrush = new SolidColorBrush(Colors.Red);
                return;
            }
            else
            {
                //MessageBox.Show("A valid email.");
                g1_txt_email.BorderBrush = new SolidColorBrush(Colors.Green);
                g2_txt_email.Text = g1_txt_email.Text;
                //txt_msg2.Visibility = Visibility.Visible;

               




                if (g1_txt_email.Text == "")
                {
                    string myStringVariable1 = string.Empty;
                    //MessageBox.Show("Email is requierd", "Error!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    Msg_War.Visibility = Visibility.Visible;
                    g1_txt_email.BorderBrush = new SolidColorBrush(Colors.Red);
                    return;
                }


                if (g1_txt_email.Text.Length < 10)
                {
                    g1_txt_email.BorderBrush = new SolidColorBrush(Colors.Red);
                    Msg_War.Visibility = Visibility.Visible;
                }

                G2.Visibility = Visibility.Visible;

                G1.Visibility = Visibility.Hidden;
                g2_txt_firstname.Focus(); 

            }
        }

        private void Win3_Prev_Click(object sender, RoutedEventArgs e)
        {

            G2.Visibility = Visibility.Visible;
            G3.Visibility = Visibility.Hidden;
        }

        private void Win2_Next_Click(object sender, RoutedEventArgs e)
        {

            if (!Regex.IsMatch(g2_txt_firstname.Text, @"^[a-zA-Z]*[a-zA-Z0-9]"))
            {
                //MessageBox.Show("Enter a valid email.");

                txt_msg.Visibility = Visibility.Visible;
                g1_txt_email.BorderBrush = new SolidColorBrush(Colors.Red);
                return;
            }
            else
            {
                //MessageBox.Show("A valid email.");
                g1_txt_email.BorderBrush = new SolidColorBrush(Colors.Green);
                g2_txt_email.Text = g1_txt_email.Text;
                //txt_msg2.Visibility = Visibility.Visible;


            }






                
            G2.Visibility = Visibility.Hidden;
           



            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string query = "insert into User_details (email,first_name,last_name,password) values('" + this.g2_txt_email.Text + "','" + this.g2_txt_firstname.Text + "','"+ g2_txt_lastname.Text+ "','" + pass2.Password + "')";
                SqlCommand sqlcmd = new SqlCommand(query, con);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Account Created!", "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
              
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            G1.Visibility = Visibility.Hidden;
            G3.Visibility = Visibility.Visible;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            G1.Visibility = Visibility.Visible;
            if (G2.Visibility == Visibility.Visible || G3.Visibility == Visibility.Visible)
            {
                G2.Visibility = Visibility.Collapsed;
                    G3.Visibility = Visibility.Collapsed;
            }

            g1_txt_email.Focus();
            g2_txt_email.IsEnabled=false;
        }
         
        private void g1_txt_email_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (g1_txt_email.Text.Length > 1)
            //{

            //}


            //else
            //{
            //    MessageBox.Show("Not a valid Email address ");
            //}
            if (txt_msg.Visibility == Visibility.Visible)
            {
                txt_msg.Visibility = Visibility.Hidden;
            }










        }

        private void g1_txt_email_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void g1_txt_email_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)

        {

          
        }

        private void g1_txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Win1_Next_Click(sender,e);
            }
        }

        private void g2_txt_firstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                g2_txt_lastname.Focus();  

            }
        }

        private void pass2_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pass2.Password == "")
            {
                pass2.BorderBrush = new SolidColorBrush(Colors.Red);
                //pass1_noti.Text = "";
                //pass1_noti.Text = "Password Field 2 is Empty or Contains Less than 4 charcters!";

            }
            if (pass2.Password.Length > 4 && pass1.Password == pass2.Password)
            {
                pass2.BorderBrush = new SolidColorBrush(Colors.Green);
                pass1.BorderBrush = new SolidColorBrush(Colors.Green);
                pass2_noti.Visibility = Visibility.Hidden;
                Win2_Next.IsEnabled = true;
                
            }
            else if(pass1.Password != pass2.Password)
                {
                pass2.BorderBrush = new SolidColorBrush(Colors.Red);
                pass2_noti.Visibility = Visibility.Visible;
                Win2_Next.IsEnabled = false;
                
                return;
            }

        }

        private void pass1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pass1.Password.Length > 4 )
            {

                pass1_noti.Visibility = Visibility.Hidden;
                pass2.IsEnabled = true;

            }
            else if (pass1.Password.Length < 4 || pass1.Password== "")
            {
                pass1_noti.Visibility = Visibility.Hidden;
                    pass2.IsEnabled = true;
               
                
                pass1_noti.Text = "Characters less than 4!!!";
                pass1_noti.Visibility = Visibility.Visible;
                pass2.IsEnabled = false;
                return;
            }
        }

        private void g2_txt_lastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                pass1.Focus();
            }
        }

        private void pass2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Win2_Next.IsEnabled == true)
                {
                    Win2_Next.Focus();
                    Win2_Next_Click(sender, e);
                }
                else
                {
                    return;
                }
            }
        }

        private void pass1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                pass2.Focus();
            }
        }

        private void btn_Standard_Click(object sender, RoutedEventArgs e)
        {
            Standard_Select.Visibility = Visibility.Visible;

            if (Visual_Select.Visibility == Visibility.Visible)
            {
                
                Visual_Select.Visibility = Visibility.Hidden;
            }
        }

        private void btn_Visual_Click(object sender, RoutedEventArgs e)
        {
            
            Visual_Select.Visibility = Visibility.Visible;

            if (Standard_Select.Visibility == Visibility.Visible)
            {

                Standard_Select.Visibility = Visibility.Hidden;
            }




        }

        private void Win3_Next_Click(object sender, RoutedEventArgs e)
        {

            //this.Close();

            foreach (Window window in Application.Current.Windows)
            {

                if(window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).main_grid2.Visibility = Visibility.Hidden;
                    (window as MainWindow).main_grid3.Visibility = Visibility.Visible;
                    this.Close();

                }
            }
        }
    
    }

}
