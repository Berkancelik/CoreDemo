using EntityLayer.Concrete;
using FluentValidation;


namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            //Category Name
            RuleFor(x => x.CategoryName)
                .NotEmpty()
                .WithMessage("Kategori adını boş geçemezsiniz");

            RuleFor(x => x.CategoryName)
                .MaximumLength(50)
                .WithMessage("Kategori adını en fazla 50 karakter olmalıdır.");

            RuleFor(x => x.CategoryName)
                .MaximumLength(5)
                .WithMessage("Kategori adını en az 5 karakter olmalıdır.");

            //Category Description
            RuleFor(x => x.CategoryDescription)
                .NotEmpty()
                .WithMessage("Kategori açıklmasını boş geçemezsiniz");

            RuleFor(x => x.CategoryDescription)
                .MaximumLength(150)
                .WithMessage("Kategori açıklmasını en fazla 150 karakter olmalıdır.");

            RuleFor(x => x.CategoryDescription)
                .MaximumLength(5)
                .WithMessage("Kategori açıklmasını en az 5 karakter olmalıdır.");

        }
    }
}
