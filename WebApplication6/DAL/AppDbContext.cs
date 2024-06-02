using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;
using WebApplication6.Models;
namespace WebApplication4.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
      public  DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<HrManagement> hrManagements { get; set; }
    }
}
