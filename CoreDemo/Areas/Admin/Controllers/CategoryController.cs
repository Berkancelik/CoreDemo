
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    // Bu areaların adminden geldiğini bildirmiş oluruz. 
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page = 1)
        {
            // PAged list de başlangıç ikinci ise pagesize parametredir. yani her sayfada kaç değer olacak
            var values = cm.GetList().ToPagedList(page, 3);
            return View(values);
        }
    }
}
