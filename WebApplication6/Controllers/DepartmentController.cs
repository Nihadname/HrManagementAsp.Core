using Microsoft.AspNetCore.Mvc;
using WebApplication4.DAL;

namespace WebApplication6.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public DepartmentController(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public IActionResult Index(int id)
        {
            var viewModals = _appDbContext.Departments.Where(e => e.HrManagementId == id).ToList();

            return View(viewModals);
        }
    }
}
