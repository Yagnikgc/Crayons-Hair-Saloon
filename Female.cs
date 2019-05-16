using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crayons_Hair_Saloon
{
    public class Female : MyCustomer
    {
        public Female()
        {

        }
        public Female(string name, string contactNum, string email, int age, string task) : base(name, contactNum, email, age, task)
        {

        }
    }
}
