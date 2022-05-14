using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori adını en fazla 50 karakter olmalıdır.");
            RuleFor(x => x.CategoryName).MaximumLength(5).WithMessage("Kategori adını en az 5 karakter olmalıdır.");
        }
    }
}
