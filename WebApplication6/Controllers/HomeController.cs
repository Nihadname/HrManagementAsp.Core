using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.DAL;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext  _appDbContext;
        public HomeController(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var appViewModals = _appDbContext.hrManagements.ToList();
                         

            return View(appViewModals);
        }
    }
}
