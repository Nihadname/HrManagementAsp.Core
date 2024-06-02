using WebApplication4.Models.common;
using WebApplication6.Models;

namespace WebApplication4.Models
{
    public class Department:BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double revenue = 1000000;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public List<Employee> Employees { get; set; }
        public int HrManagementId { get; set; }
        public HrManagement hrManagement { get; set; }

    }
}
