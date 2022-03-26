using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilmez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilmez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilmez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapın");


        }
    }
}
