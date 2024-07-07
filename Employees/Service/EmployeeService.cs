using Employees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Service
{
    internal class EmployeeService : IEmployeService
    {
        List<EmployeeModel> employees = [];

        public EmployeeService()
        {
            employees.Add(new EmployeeModel(1, 123456789, "Dudu", "Doe", new DateTime(1980, 1, 1), Gender.MALE, Status.WIDOWER, 0587165846, 025893654, new Address("ירושלים", "שטראוס", 12)));
            employees.Add(new EmployeeModel(2, 987654321, "Jane", "Smith", new DateTime(1985, 2, 2), Gender.FEMALE, Status.MARRIED, 0587165847, 025893655, new Address("תל אביב", "אלנבי", 34)));
            employees.Add(new EmployeeModel(3, 456789123, "Alice", "Johnson", new DateTime(2000, 3, 3), Gender.FEMALE, Status.DIVORCEE, 0587165848, 025893656, new Address("חיפה", "הרצל", 56)));
        }

        public void Create(EmployeeModel employee)
        {
            employees.Add(employee);
        }

        public void Delete(EmployeeModel employee)
        {
            employees.Remove(employee);
        }

        public List<EmployeeModel> GetAll()
        {
            return employees;
        }

        public EmployeeModel? GetById(int id)
        {
            foreach (EmployeeModel employee in employees)
            {
                if (employee.Id == id)
                {
                    return employee;
                }
            }
            return null;
        }

        public EmployeeModel? GetByTz(int tz)
        {
            foreach (EmployeeModel employee in employees)
            {
                if (employee.TZ == tz)
                {
                    return employee;
                }
            }
            return null;
        }

        public void Update(EmployeeModel employee)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == employee.Id)
                {
                    employees[i] = employee;
                }
            }
        }
    }
}
