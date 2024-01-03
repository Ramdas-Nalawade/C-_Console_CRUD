using EMPLOYEE_MANAGEMENT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYEE_MANAGEMENT.Services
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetAll()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { Id = 1, Name = "Shraddha" });
            return list;
        }
    }
}
