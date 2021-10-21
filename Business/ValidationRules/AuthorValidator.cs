using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz");
            RuleFor(x => x.AuthorAbout).NotEmpty().WithMessage("İçerik Alanını Boş Geçemezsiniz");
        }
    }
}
