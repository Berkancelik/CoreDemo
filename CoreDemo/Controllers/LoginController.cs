﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {

        // Aşağıdaki AllowAnonymous, sistemteki tüm kısıtlamaları burası için kaldır anlamını taşımaktadır.
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}
