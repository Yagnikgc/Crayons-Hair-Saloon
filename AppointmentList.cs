using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Crayons_Hair_Saloon
{
    [XmlRoot("CustomerList")]
    [XmlInclude(typeof(Male))]
    [XmlInclude(typeof(Female))]
    public class AppointmentList : IDisposable
    {
        List<Customer> alist = null;
        [XmlArray("Customers")]
        [XmlArrayItem("Customer", typeof(Customer))]
        public List<Customer> Alist { get => alist; set => alist = value; }

        public AppointmentList()
        {
            Alist = new List<Customer>(); 
        }

        public void Add(Customer customer)
        {
            Alist.Add(customer);
        }
        public void Remove(Customer customer)
        {
            Alist.Remove(customer);
        }
        public Customer this[int i]
        {
            get { return Alist[i]; }
        }
        public int Count()
        {
            return Alist.Count();
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
