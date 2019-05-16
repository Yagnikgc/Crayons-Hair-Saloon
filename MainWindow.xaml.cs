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

namespace Crayons_Hair_Saloon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_logIn_Click(object sender, RoutedEventArgs e)
        {
            string uname = txt_username.Text;
            string passwd = txt_password.Password;
            bool check_form = true;
            if(uname != "Admin")
            {
                lbl_name_error.Visibility = Visibility.Visible;
                check_form = false;
            }
            else
            {
                lbl_name_error.Visibility = Visibility.Hidden;
            }
            if (passwd != "Admin123")
            {
                lbl_pwd_error.Visibility = Visibility.Visible;
                check_form = false;
            }
            else
            {
                lbl_pwd_error.Visibility = Visibility.Hidden;
            }
            if(check_form)
            {
                MessageBox.Show("LogIn Successfull.");
                HairSaloon hair = new HairSaloon();
                hair.Show();
                this.Close();
            }
        } 
    }
}