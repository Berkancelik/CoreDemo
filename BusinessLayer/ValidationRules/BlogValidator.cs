using EntityLayer.Concrete;
using FluentValidation;


namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {

            // Blog Title
            RuleFor(x => x.BlogTitle)
                .NotEmpty()
                .WithMessage("Blog başlığını boş geçemezsiniz");

            RuleFor(x => x.BlogTitle)
                .MaximumLength(150)
                .WithMessage("Lütfen 150 karakterden daha az veri girişi yapın");

            RuleFor(x => x.BlogTitle)
                .MinimumLength(5)
                .WithMessage("Lütfen 5 karakterden daha fazla veri girişi yapın");

            //Blog Content
            RuleFor(x => x.BlogContent)
                .NotEmpty()
                .WithMessage("Blog içeriğini boş geçemezsiniz");

            RuleFor(x => x.BlogContent)
                .MaximumLength(50)
                .WithMessage("Lütfen 50 karakterden daha az veri girişi yapın");

            RuleFor(x => x.BlogContent)
                .MinimumLength(3)
                .WithMessage("Lütfen 3 karakterden daha fazla veri girişi yapın");

            //Blog Image
            RuleFor(x => x.BlogImage)
                .NotEmpty()
                .WithMessage("Blog görselini boş geçemezsiniz");


        }
    }
}
