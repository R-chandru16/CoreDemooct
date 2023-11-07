using Microsoft.EntityFrameworkCore;

namespace CoreMVC.Models
{
    public class EmployeeDbContext:DbContext
    {

        public EmployeeDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set;}
      
    }
}
