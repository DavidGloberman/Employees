using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Model
{
    internal class Address
    {
        public string City { get; set; }
        public string Street {  get; set; }
        public int Num { get; set; }
        public Address(string city, string street, int num)
        {
            City = city;
            Street = street;
            Num = num;
        }
    }
}
