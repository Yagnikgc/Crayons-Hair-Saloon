using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crayons_Hair_Saloon
{
    public interface ICustomer : IComparable<ICustomer>
    {
        string Name { get; set; }
        string ContactNumber { get; set; }
        string Email { get; set; }
        int Age { get; set; }
        string Tasks { get; set; }
    }
}
