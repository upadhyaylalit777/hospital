using hospital.Data;
using hospital.Models;
using Microsoft.AspNetCore.Mvc;

namespace hospital.Controllers
{
    public class DocsController : Controller
    {
        private readonly ApplicationDbContext _db1;
        public DocsController(ApplicationDbContext db)
        {
            _db1 = db;
        }

        public IActionResult Index()
        {
            List<Doctors> doctors = _db1.docts.ToList();
            return View(doctors);
        }
    }
}
