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
    /// Interaction logic for goster.xaml
    /// </summary>
    public partial class goster : Window
    {
        MySqlConnection bag = new MySqlConnection("Server=localhost;Database=veritakip;Uid=root;Pwd='';");
        System.Windows.Threading.DispatcherTimer zaman3;
        public goster()
        {
            InitializeComponent();
            bag.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM urunler ", bag);
            MySqlDataAdapter adabtor = new MySqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adabtor.Fill(tablo);
            dataGrid.ItemsSource = tablo.AsDataView();
            zaman3= new System.Windows.Threading.DispatcherTimer();
            zaman3.Interval = new TimeSpan(0, 0, 1);
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
    }
}
