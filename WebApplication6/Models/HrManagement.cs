using WebApplication4.Models;
using WebApplication4.Models.common;

namespace WebApplication6.Models
{
    public class HrManagement:BaseEntity
    {
        public string Name { get; set; }
        List<Department> departments { get; set; }

    }
}
