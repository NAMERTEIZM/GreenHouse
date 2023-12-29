using FluentValidation;
using GreenHouse.VM.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Validation
{
    public class CategoryInsertVMValidator : AbstractValidator<CategoryInsertVM>
    {
        public CategoryInsertVMValidator()
        {
            RuleFor(category => category.KategoriAdi)
                .NotNull().WithMessage("Kategori Adı boş olamaz.")
                .NotEmpty().WithMessage("Kategori Adı boş olamaz.");

            RuleFor(category => category.UstKategoriID)
                .GreaterThanOrEqualTo(0).When(category => category.UstKategoriID != null)
                .WithMessage("Üst Kategori ID geçersiz.");
        }
    }
}
