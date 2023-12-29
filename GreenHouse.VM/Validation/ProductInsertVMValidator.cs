using FluentValidation;
using GreenHouse.VM.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Validation
{
    public class ProductInsertVMValidator : AbstractValidator<ProductInsertVM>
    {
        public ProductInsertVMValidator()
        {
            RuleFor(x => x.BarkodNumarasi).NotEmpty().WithMessage("Barkod numarası boş olamaz.");
            RuleFor(x => x.UrunAdi).NotEmpty().WithMessage("Ürün adı boş olamaz.");
            RuleFor(x => x.UrunAciklamasi).NotEmpty().WithMessage("Ürün açıklaması boş olamaz.");          
            RuleFor(x => x.UrunKategori).NotNull().WithMessage("Ürün kategorisi seçilmelidir.");

            RuleFor(x => x.Resims)
                .Must(x => x != null && x.Count == 2).WithMessage("2 adet resim seçmelisiniz.");
            RuleFor(x => x.UrunFirmas)
                .Must(x => x != null && x.Count > 0).WithMessage("En az bir firma seçilmelidir.");

            RuleFor(x => x.UrunIceriks)
                .Must(x => x != null && x.Count > 0).WithMessage("En az bir içerik seçilmelidir.");

        }
    }
}
