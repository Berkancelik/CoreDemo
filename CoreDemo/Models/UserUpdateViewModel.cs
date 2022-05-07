using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserUpdateViewModel
    {
        //PascalCase burada ezilmiştir...
        public string NameSurname { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string ImageUrl { get; set; }
        public string Password { get; set; }
    }
}
