using hospital.Data;
using hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic;
using Microsoft.Data.SqlClient;



namespace hospital.Controllers
{
    public class HospitalController : Controller

    {
   //     BookDb dbop=new BookDb();
        private readonly ApplicationDbContext _db;
        
        public HospitalController(ApplicationDbContext db)
        {
            _db = db;
        }
      
        public IActionResult Index()
        {
            List<DocDb> objDoctorList = _db.Docs.ToList();
        
            return View();
        }

        public IActionResult Book()
        {
            return View();
        }
       // [HttpPost]
       // public IActionResult Book([Bind] Book bing) 
       // {
       //     try
       //     {
       //         if (ModelState.IsValid)
       //         {
                    
       //             string res = dbop.Saverecord(bing);
       //             TempData["msg"] = res;
       //         }
                
       //     }
       //     catch (Exception ex)
       //     {
       //         TempData["msg"] =ex.Message;

       //     }

            
               
       //     return View();

       //}
    }
}
