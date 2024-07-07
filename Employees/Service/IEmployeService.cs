using Employees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Service
{
    internal interface IEmployeService
    {
        List<EmployeeModel> GetAll();

        EmployeeModel? GetById(int id);
        EmployeeModel? GetByTz(int id);
        void Create (EmployeeModel employee);
        void Update (EmployeeModel employee);
        void Delete (EmployeeModel employee);
    }
}
