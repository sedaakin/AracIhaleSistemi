using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ViewModels.Validators
{
    public class AracValidator:AbstractValidator<AracVM>
    {
        public AracValidator()
        {
            RuleFor(x=>x.ID).NotNull().WithMessage("Bir araç seçiniz.");
            RuleFor(x => x.KaydedenKullanici).NotNull().WithMessage("Kaydeden kullanıcı boş olamaz.");
            RuleFor(x => x.KayitZamani).NotNull().WithMessage("Kayıt zamanı boş olamaz.");

        }
    }
}
