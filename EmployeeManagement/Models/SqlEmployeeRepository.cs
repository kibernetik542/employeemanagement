using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public SqlEmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public Employee GetEmployee(int id) => _context.Employees.Find(id);
        public IEnumerable<Employee> GetAllEmployees() => _context.Employees.ToList();

        public Employee Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee Update(Employee employeeChanges)
        {
            var employee = _context.Employees.Attach(employeeChanges);
            employee.State = EntityState.Modified;
            _context.SaveChanges();
            return employeeChanges;
        }

        public Employee Delete(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return employee;
        }
    }
}
