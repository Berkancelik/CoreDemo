using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    // Bu areaların adminden geldiğini bildirmiş oluruz. 
    [Area("Admin")]
    [AllowAnonymous]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page = 1)
        {
            // PAged list de başlangıç ikinci ise pagesize parametredir. yani her sayfada kaç değer olacak
            var values = cm.GetList().ToPagedList(page, 3);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        } 
        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            {        

                CategoryValidator cv = new CategoryValidator();
                ValidationResult results = cv.Validate(p);
                if (results.IsValid)
                {
                    p.CategoryStatus = true;
                    cm.TAdd(p);
                    return RedirectToAction("Index", "Category");
                }
                else
                {
                    foreach (var item in results.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                }
                return View();
            }

            
        }
        public IActionResult CategoryDelete(int id)
        {
            var blogvalue = cm.TGetById(id);
            cm.TDelete(blogvalue);
            return RedirectToAction("Index");
        }
    }
}
