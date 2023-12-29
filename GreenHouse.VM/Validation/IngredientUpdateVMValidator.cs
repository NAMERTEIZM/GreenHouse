using FluentValidation;
using GreenHouse.VM.Ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Validation
{
    public class IngredientUpdateVMValidator : AbstractValidator<IngredientUpdateVM>
    {
        public IngredientUpdateVMValidator()
        {
            RuleFor(ingredient => ingredient.Adi)
                .NotEmpty()
                .WithMessage("İçerik adı boş bırakılamaz.");

            RuleFor(ingredient => ingredient.Aciklama)
                .MaximumLength(500)
                .WithMessage("Açıklama en fazla 500 karakter olmalıdır.");

            RuleFor(ingredient => ingredient.RiskID)
                .GreaterThan(0)
                .WithMessage("Risk ID geçerli bir değer olmalıdır.");
        }
    }
}
