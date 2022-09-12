using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;


namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        // Ekleme işlemi yapılırken, httpget ve httppost attributelerinin tanımlandığı metotların isimleri aynı olmak zorundadır.
        // Http Get --> SAyfa yüklenince
        // HttpPost --> Sayfada buton tetiklenince

        // HttpGet Attribute komutu sayfada ketegorize ya da benzeri işlemler kullanılırken, sayfa yüklendiği anda listelenmesi istenene niteliklerde kullanılabilir.


        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WriterValidator writerValidaor = new WriterValidator();
            ValidationResult results = writerValidaor.Validate(p);
            if (results.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "Deneme Test";
                writerManager.TAdd(p);
                return RedirectToAction("Index", "Blog");
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
}
