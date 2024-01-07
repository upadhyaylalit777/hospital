using hospital.Data;
using hospital.Models;
using Microsoft.AspNetCore.Mvc;





namespace hospital.Controllers
{
    public class HospitalController : Controller

    {
        private readonly ApplicationDbContext _db;

        public HospitalController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<DocDb> objDoctorList = _db.Docs.ToList();

            return View(objDoctorList);
        }
        
        public IActionResult Book()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Book(Book appointments)
        {
            _db.Books.Add(appointments);
            _db.SaveChanges();      
             return RedirectToAction("Index");  
        }
    }

}