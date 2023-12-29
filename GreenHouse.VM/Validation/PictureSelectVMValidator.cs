using FluentValidation;
using GreenHouse.VM.Picture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Validation
{
    public class PictureSelectVMValidator : AbstractValidator<PictureSelectVM>
    {
        public PictureSelectVMValidator()
        {

            RuleFor(picture => picture.ResimYolu)
                .NotEmpty()
                .WithMessage("Resim yolu alanı boş bırakılamaz.");

        }
    }
}
