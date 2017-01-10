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
    /// Interaction logic for Ekle.xaml
    /// </summary>
    public partial class Ekle : Window
    {
        MySqlConnection bag = new MySqlConnection("Server=localhost;Database=veritakip;Uid=root;Pwd='';");
        System.Windows.Threading.DispatcherTimer zaman2;
        public Ekle()
        {
            InitializeComponent();
            zaman2 = new System.Windows.Threading.DispatcherTimer();
            zaman2.Interval = new TimeSpan(0, 0, 1);
            zaman2.Tick += Zaman2_Tick;
            zaman2.Start();
        }

        private void btnekle_Click(object sender, RoutedEventArgs e)
        {
            bag.Close();
            bag.Open();
            MySqlCommand komut2 = new MySqlCommand("INSERT INTO urunler (urunAd,urunAdedi,girisTarihi,cikisTarihi) VALUES ('" + textBox.Text + "','" + textBox1.Text + "','" + dt1.Text + "','" + dt2.Text + "')", bag);
            komut2.ExecuteNonQuery();
            komut2.Dispose();
        }
        private void Zaman2_Tick(object sender, EventArgs e)
        {

            MySqlCommand komut2 = new MySqlCommand("SELECT * from urunler ", bag);


            MySqlDataAdapter adabtor = new MySqlDataAdapter(komut2);


            DataTable tablo2 = new DataTable();
            adabtor.Fill(tablo2);
            dataGrid.ItemsSource = tablo2.AsDataView();

        }
    }
}
