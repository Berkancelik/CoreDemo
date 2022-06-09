using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class AdminController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdminNavbarPartial()
        {

            var userName = User.Identity.Name;
            ViewBag.v1 = userName;



            return PartialView();
        }
    }
}
