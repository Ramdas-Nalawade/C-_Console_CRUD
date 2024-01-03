using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMPLOYEE_MANAGEMENT.Entities;
using EMPLOYEE_MANAGEMENT.Services;

namespace EMPLOYEE_MANAGEMENT.Controllers
{
    public class EmployeeController
    {
        private IEmployeeService empService;

        public EmployeeController(IEmployeeService empService)
        {
            this.empService = empService;
        }
        public List<Employee> GetAll()
        {
            return empService.GetAll();
        }
    }
}
