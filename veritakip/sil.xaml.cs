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
using System.Data;
using MySql.Data.MySqlClient;
namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for sil.xaml
    /// </summary>
    public partial class sil : Window
    {
      
        MySqlConnection bag = new MySqlConnection("Server=localhost;Database=veritakip;Uid=root;Pwd='';");
        System.Windows.Threading.DispatcherTimer zaman3;
   
        public sil()
        {
            InitializeComponent();
            bag.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM urunler ", bag);
            MySqlDataAdapter adabtor = new MySqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adabtor.Fill(tablo);
            dataGrid.ItemsSource = tablo.AsDataView();
            zaman3 = new System.Windows.Threading.DispatcherTimer();
            zaman3.Interval = new TimeSpan(0, 0, 5);
            zaman3.Tick += Zaman3_Tick;
            zaman3.Start();
        }
        private void Zaman3_Tick(object sender, EventArgs e)
        {

            MySqlCommand komut2 = new MySqlCommand("SELECT * from urunler order By cikisTarihi asc ", bag);


            MySqlDataAdapter adabtor = new MySqlDataAdapter(komut2);


            DataTable tablo2 = new DataTable();
            adabtor.Fill(tablo2);
            dataGrid.ItemsSource = tablo2.AsDataView();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            System.Data.DataRowView satir = (System.Data.DataRowView)dataGrid.SelectedItem;
           
            if (dataGrid.SelectedIndex == -1) return;
          MySqlCommand komut3 = new MySqlCommand("delete from urunler where id='" + satir[0] + "' ", bag);
         
           MySqlDataAdapter adabtor = new MySqlDataAdapter(komut3);
            komut3.ExecuteNonQuery();
            komut3.Dispose();
            /*  System.Data.DataRowView saitr = (System.Data.DataRowView)dataGrid.SelectedItem;
       MessageBox.Show("Seçili id" + saitr[0].ToString());*/
        }

        
    }
}
