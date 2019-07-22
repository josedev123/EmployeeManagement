using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = "HR", Email = "mary@wsdsds.com" },
                new Employee() { Id = 1, Name = "Karen", Department = "IT", Email = "karen@wsdsds.com" },
                new Employee() { Id = 1, Name = "Jan", Department = "HT", Email = "jan@wsdsds.com" }
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
