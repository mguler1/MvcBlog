using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class BlogValidator: AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Başlık Adını Boş Geçemezsiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("İçerik Alanını Boş Geçemezsiniz");
        }
    }
}
