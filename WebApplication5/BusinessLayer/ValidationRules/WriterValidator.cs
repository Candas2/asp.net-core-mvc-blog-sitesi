﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("İsim kısmı boş geçilemez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapılmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapılmalıdır.");
        }
    }
}
