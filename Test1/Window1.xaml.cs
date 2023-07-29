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

namespace Test1
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void MinBtn_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
            this.Hide();

        }

        private void AggrandirBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
            this.Close();
                       
        }

        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditionBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FileBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {

        }

        private void About_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Projects_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Home_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Wallet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Transfert_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Parametre_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
