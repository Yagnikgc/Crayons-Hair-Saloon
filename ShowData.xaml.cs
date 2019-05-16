using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace Crayons_Hair_Saloon
{
    /// <summary>
    /// Interaction logic for ShowData.xaml
    /// </summary>
    public partial class ShowData : Window
    {
        static string file_name = "data.xml";
        [XmlElement(ElementName = "AppoinmentList")]
        private AppointmentList list = null;
        public ShowData()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            XmlSerializer serializer = null;
            StreamReader reader = null;

            try
            {
                serializer = new XmlSerializer(typeof(AppointmentList));
                reader = new StreamReader(file_name);
                list = (AppointmentList)serializer.Deserialize(reader);
                dataGrid.ItemsSource = list.Alist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private void Btn_findCustomer_Click(object sender, RoutedEventArgs e)
        {
            string custName = txt_findCustomer.Text;
            if (custName.Length > 0)
            {
                var query = from appoinment in list.Alist
                            where appoinment.Name == custName
                            select appoinment;

                dataGrid.ItemsSource = query;

            }
            else
            {
                dataGrid.ItemsSource = list.Alist;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HairSaloon hairSaloon = new HairSaloon();
            hairSaloon.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
