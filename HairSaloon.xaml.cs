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

namespace Crayons_Hair_Saloon
{
    /// <summary>
    /// Interaction logic for HairSaloon.xaml
    /// </summary>
    public partial class HairSaloon : Window
    {
        public HairSaloon()
        {
            InitializeComponent();
        }

        private void Btn_bookApt_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void Btn_showApt_Click(object sender, RoutedEventArgs e)
        {
            ShowData showData = new ShowData();
            showData.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
