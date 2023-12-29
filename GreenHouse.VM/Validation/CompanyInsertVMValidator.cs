using FluentValidation;
using GreenHouse.VM.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Validation
{
    public class CompanyInsertVMValidator : AbstractValidator<CompanyInsertVM>
    {
        public CompanyInsertVMValidator()
        {
            RuleFor(company => company.FirmaAdi)
                .NotNull().WithMessage("Firma Adı boş olamaz.")
                .NotEmpty().WithMessage("Firma Adı boş olamaz.");

            RuleFor(company => company.FirmaTel)
                .Matches(@"^\d{10}$").WithMessage("Geçersiz telefon numarası.");

            RuleFor(company => company.FirmaAdresi)
                .NotNull().WithMessage("Firma Adresi boş olamaz.")
                .NotEmpty().WithMessage("Firma Adresi boş olamaz.");
        }
    }
}
