using EMPLOYEE_MANAGEMENT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYEE_MANAGEMENT.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
    }
}
