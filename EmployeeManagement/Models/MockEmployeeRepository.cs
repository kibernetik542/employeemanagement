using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Banu", Department = Dept.IT, Email = "banu@gmail.com" },
                new Employee() { Id = 2, Name = "Arzu", Department = Dept.IT, Email = "arzu@gmail.com" },
                new Employee() { Id = 3, Name = "Helena", Department = Dept.HR, Email = "helena@gmail.com" },
                new Employee() { Id = 4, Name = "John", Department = Dept.Financial, Email = "john@gmail.com" }
            };
        }

        public Employee GetEmployee(int id) => _employeeList.FirstOrDefault(e => e.Id == id);
        public IEnumerable<Employee> GetAllEmployees() => _employeeList.ToList();

        public Employee Add(Employee employee)
        {
           employee.Id = _employeeList.Max(e => e.Id) + 1;
           _employeeList.Add(employee);
           return employee;
        }

        public Employee Update(Employee employeeChanges)
        {
            var employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }

            return employee;
        }

        public Employee Delete(int id)
        {
            var employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }

            return employee;
        }
    }
}
