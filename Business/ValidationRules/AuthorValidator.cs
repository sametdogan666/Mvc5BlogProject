using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar adı boş geçilemez");
            RuleFor(x => x.AuthorTitle).NotEmpty().WithMessage("Yazar başlık alanı boş geçilemez");
            RuleFor(x => x.AuthorImage).NotEmpty().WithMessage("Yazar görseli boş geçilemez");
            RuleFor(x => x.AuthorAbout).NotEmpty().WithMessage("Yazar hakkında kısmı boş geçilemez");
        }
    }
}
