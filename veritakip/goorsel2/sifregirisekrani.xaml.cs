using System;
using System;
using MySql.Data.MySqlClient;
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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for sifregirisekrani.xaml
    /// </summary>
    public partial class sifregirisekrani : Window
    {
       
      
      
       
        System.Windows.Threading.DispatcherTimer zaman;
        int sayac = 1;

        public MainWindow anaekran;
        
        public sifregirisekrani()
        {
            InitializeComponent();
         
           
            zaman = new System.Windows.Threading.DispatcherTimer();
            zaman.Interval = new TimeSpan(0, 0, 10);
            zaman.Tick += Zaman_Tick;
            zaman.Start();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sil s = new sil();

            s.ShowDialog();
            
            //anaekran.mesajgoster("Merhaba "+txt1.Text + " " + txt2.Text);
          
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Ekle k = new Ekle();
            k.Show();
           

        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            goster g = new goster();

            g.Show();

        }
        private void Zaman_Tick(object sender, EventArgs e)
        {

            anaekran.Hide();
           
        }

        
    }
}
