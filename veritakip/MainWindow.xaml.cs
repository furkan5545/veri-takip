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
using System.Data;
using MySql.Data.MySqlClient;


namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        sifregirisekrani a = new sifregirisekrani();
         
     


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txt1.Text == "admin" && ps1.Password == "123")
            {

                a.anaekran = this;
                
                a.Show();
               
               


            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }
            
        }


        public void mesajgoster(string a)
        {
            MessageBox.Show(a);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            a.Close();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
