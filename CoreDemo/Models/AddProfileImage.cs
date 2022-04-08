using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class AddProfileImage
    {
        // ekleme işlemleri bu class içerisinden gerçekleşecektir.
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        // Dosya şeklinde bir resim yüklemek için görselleri "IFromFile" şeklinde tanımlamamız yeterli olacaktır.
        public IFormFile WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }
    }
}
