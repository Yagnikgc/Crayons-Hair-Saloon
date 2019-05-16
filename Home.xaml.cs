using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Crayons_Hair_Saloon
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        static string file_name = "data.xml";
        ObservableCollection<MyCustomer> displayCustomer = null;
        ArrayList timeslot = new ArrayList();
        AppointmentList alist = new AppointmentList();
        MyCustomer customer = null;
        internal ObservableCollection<MyCustomer> DisplayCustomer { get => displayCustomer; set => displayCustomer = value; }
        public Home()
        {
            InitializeComponent();
            AddTimeSlotes();
            LoadCheckbox();
            DisplayCustomer = new ObservableCollection<MyCustomer>();
        }

        private void AddTimeSlotes()
        {
            timeslot.Add("9:00 AM");
            timeslot.Add("10:00 AM");
            timeslot.Add("11:30 AM");
            timeslot.Add("12:00 AM");
            timeslot.Add("1:00 PM");
            timeslot.Add("2:30 PM");
            timeslot.Add("3:00 PM");
            timeslot.Add("4:00 PM");
            timeslot.Add("5:30 PM");

            foreach (var i in timeslot)
            {
                cmb_time.Items.Add(i);
            }
            cmb_time.SelectedIndex = 0;
        }

        private void Btn_Home_Click(object sender, RoutedEventArgs e)
        {
            HairSaloon hairSaloon = new HairSaloon();
            hairSaloon.Show();
            this.Close();
        }

        private void Btn_bookApt_Click(object sender, RoutedEventArgs e)
        {
            bool result = true;
            string error_msg = "";
            string name = txt_name.Text;
            string contactNum = txt_contactNum.Text;
            string age = txt_age.Text;
            string mail = txt_mail.Text;
            string time = cmb_time.SelectedValue.ToString();
            string task = "";
            string gender = string.Empty;

            int iAge = 0;
            result = ValidateCheckBox();
            if (result == false)
            {
                error_msg += "Please select task.\n";
            }
            if (!int.TryParse(age, out iAge) || iAge < 0)
            {
                result = false;
                error_msg += "Please Enter Proper Age.\n";
            }
            if (rdb_male.IsChecked == true)
            {
                gender = "Male";
            }
            else if (rdb_female.IsChecked == true)
            {
                gender = "Female";
            }
            if(name == null || name == "")
            {
                result = false;
                error_msg += "Please Enter Name.\n";
            }
            double contact = 0;
            if (!double.TryParse(contactNum,out contact) || contactNum.Length != 10)
            {
                result = false;
                error_msg += "Please Enter Contact Number.\n";
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (mail == null || mail == "")
            {
                result = false;
                error_msg += "Please Enter Email Address.\n";
            }else if (!regex.Match(mail).Success)
            {
                result = false;
                error_msg += "Invalid Email Address.\n";
            }


            if (result)
            {
                if (cb_task1.IsChecked == true)
                {
                    task += cb_task1.Content+"\n";
                }
                if (cb_task2.IsChecked == true)
                {
                    task += cb_task2.Content + "\n";
                }
                if (cb_task3.IsChecked == true)
                {
                    task += cb_task3.Content + "\n";
                }
                if (cb_task4.IsChecked == true)
                {
                    task += cb_task4.Content + "\n";
                }
                customer = new MyCustomer(name, contactNum, mail, iAge, task);
                switch (gender)
                {
                    case "Male":
                        customer.Time = time;
                        customer.Customer = new Male(name,contactNum,mail,iAge,task);
                        break;
                    case "Female":
                        customer.Time = time;
                        customer.Customer = new Female(name, contactNum, mail, iAge, task);
                        break;
                    default:
                        MessageBox.Show("Invalid Gender");
                        break;
                }
                DisplayCustomer.Add(customer);
                dataGrid.ItemsSource = DisplayCustomer;
                clearComponent();
                MessageBox.Show("Please confirm your appointment.");
            }
            else
            {
                MessageBox.Show(error_msg);
            }
        }

        private void Rdb_male_Checked(object sender, RoutedEventArgs e)
        {
            if(cb_task1 != null)
            LoadCheckbox();
        }

        void LoadCheckbox() {
            if (rdb_male.IsChecked == true)
            {
                cb_task1.Content = "Hair Styling";
                cb_task2.Content = "Massage";
                cb_task3.Content = "Beard Styling";
                cb_task4.Content = "Threading";
            }
            else if (rdb_female.IsChecked == true)
            {
                cb_task1.Content = "Make Up";
                cb_task2.Content = "Facial";
                cb_task3.Content = "Smoothning";
                cb_task4.Content = "Foot Spa";
            }
        }
        
        bool ValidateCheckBox()
        {
            int count = 0;
            if (cb_task1.IsChecked == true)
            {
                count++;
            }
            if (cb_task2.IsChecked == true)
            {
                count++;
            }
            if (cb_task3.IsChecked == true)
            {
                count++;
            }
            if (cb_task4.IsChecked == true)
            {
                count++;
            }
            if (count == 0)
                return false;
            else
                return true;
        }

        void clearComponent()
        {
            cmb_time.SelectedIndex = 0;
            txt_name.Text = "";
            txt_contactNum.Text = "";
            txt_mail.Text = "";
            txt_age.Text = "";
 
        }

        private void Btn_ConfirmAppointment_Click(object sender, RoutedEventArgs e)
        {
            SaveData(alist);
        }
        public void SaveData(AppointmentList appointments)
        {
            foreach (MyCustomer customer in DisplayCustomer)
            {
                appointments.Add(customer.Customer);
            }
            XmlSerializer serializer = null;
            TextWriter writer = null;

            try
            {
                serializer = new XmlSerializer(typeof(AppointmentList));
                writer = new StreamWriter(file_name);
                serializer.Serialize(writer, appointments);
                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                writer.Close();
            }
            MessageBox.Show("Data has been Saved");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
