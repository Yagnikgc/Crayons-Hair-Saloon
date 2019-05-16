using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crayons_Hair_Saloon
{
    public abstract class Customer : ICustomer
    {
        private string name;
        private string contactNumber;
        private string email;
        private int age;
        private string tasks;
        public string Name { get => name; set => name = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Email { get => email; set => email = value; }
        public int Age { get => age; set => age = value; }
        public string Tasks { get => tasks; set => tasks = value; }
        public Customer()
        {

        }
        public Customer(string name, string contactNum, string email, int age,string task)
        {
            Name = name;
            ContactNumber = contactNum;
            Email = email;
            Age = age;
            Tasks = task;
        }
        public int CompareTo(ICustomer other)
        {
            return this.age.CompareTo(other.Age);
        }
    }
}
