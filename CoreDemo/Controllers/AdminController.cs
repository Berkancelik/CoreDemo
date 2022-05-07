using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class AdminController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        UserManager um = new UserManager(new EfUserRepository());

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
