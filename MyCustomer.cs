using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crayons_Hair_Saloon
{
    public class MyCustomer : Customer
    {
        string time;
        Customer customer;
        
        public MyCustomer()
        {

        }
        public MyCustomer(string name, string contactNum, string email, int age, string task):base(name,contactNum,email,age,task)
        {

        }

        public string Time { get => time; set => time = value; }
        public Customer Customer { get => customer; set => customer = value; }
    }
}
