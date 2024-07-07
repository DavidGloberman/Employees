using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Model
{
    internal class EmployeeModel
    {
        public EmployeeModel(int id, int tZ, string firstName, string lastName, DateTime dob, Gender gender, Status status, int mobilePhone, int homePhone, Address address)
        {
            Id = id;
            TZ = tZ;
            FirstName = firstName;
            LastName = lastName;
            Dob = dob;
            Gender = gender;
            Status = status;
            MobilePhone = mobilePhone;
            HomePhone = homePhone;
            Address = address;
        }

        public int Id { get; set; }
        public int TZ { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public Gender Gender { get; set; }
        public Status Status { get; set; }
        public int MobilePhone { get; set; }
        public int HomePhone { get; set; }
        public Address Address { get; set; }
        public string FullName { get
            {
                return FirstName + " " + LastName;
            }}
        public int Age { get { return DateTime.Now.Year - Dob.Year; } }
    }
}
