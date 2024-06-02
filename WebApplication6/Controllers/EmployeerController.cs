using Microsoft.AspNetCore.Mvc;
using WebApplication4.DAL;

namespace WebApplication6.Controllers
{
    public class EmployeerController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public EmployeerController(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        public IActionResult Index(int id)
        {
            var viewModels = _appDbContext.Employees
                .Where(e => e.DepartmentId == id)
                .ToList();
            return View(viewModels);
        }
    }
}
