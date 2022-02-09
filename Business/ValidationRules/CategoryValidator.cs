using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama alanını boş geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3)
                .WithMessage("Lütfen en az 3 karakterlik kategori adı girişi yapınız.");
            RuleFor(x => x.CategoryName).MaximumLength(50)
                .WithMessage("Lütfen en fazla 50 karakterlik kategori adı girişi yapınız");

        }
    }
}
