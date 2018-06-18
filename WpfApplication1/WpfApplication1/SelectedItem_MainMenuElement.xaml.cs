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
    /// Interaction logic for SelectedItem.xaml
    /// </summary>
    public partial class SelectedItem : Window
    {
        Main_Menu ownerform = null;
        public SelectedItem(Main_Menu ownerform)
        {
            InitializeComponent();
            this.ownerform = ownerform;
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_sidinsert_Click(object sender, RoutedEventArgs e)
        {
            //Main_Menu mm = new Main_Menu();
            //mm.dg_main.Items.Add(new { Product_Name = txt_pn.Text, Quantity = txt_qty.Text, Product_Code = txt_pc.Text });
            //mm.Show();
            string dk = "Animal Kingdom";
            //txt_pn.Text = dk;
            
           ownerform.PassValue(dk);



        }
    }
}
