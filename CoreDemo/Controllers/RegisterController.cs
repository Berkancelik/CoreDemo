using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {

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
        public IActionResult Degisecek()
        {
            return View();
        }
    }
}
