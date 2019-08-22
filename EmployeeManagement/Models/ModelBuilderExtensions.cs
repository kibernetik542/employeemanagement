using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Banu", Department = Dept.IT, Email = "banu@gmail.com" },
                new Employee { Id = 2, Name = "Arzu", Department = Dept.IT, Email = "arzu@gmail.com" },
                new Employee { Id = 3, Name = "Jeremy", Department = Dept.None, Email = "jeremy@gmail.com" },
                new Employee { Id = 4, Name = "Max", Department = Dept.Financial, Email = "max@gmail.com" }
            );
        }
    }
}
