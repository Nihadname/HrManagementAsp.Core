using WebApplication4.Models.common;

namespace WebApplication4.Models
{
    public class Employee:BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public int Salary { get; set; }
        public DateTime CreatedTime { get; set; }
public int DepartmentId { get; set; }
        public Department department { get; set; }
    }
}
