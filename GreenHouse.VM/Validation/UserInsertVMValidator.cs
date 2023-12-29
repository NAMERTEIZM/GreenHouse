using FluentValidation;
using GreenHouse.VM.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Validation
{
    public class UserInsertVMValidator : AbstractValidator<UserInsertVM>
    {
        public UserInsertVMValidator()
        {
            RuleFor(user => user.Adi).NotEmpty().WithMessage("Adı alanı boş bırakılamaz.");
            RuleFor(user => user.Soyadi).NotEmpty().WithMessage("Soyadı alanı boş bırakılamaz.");
            RuleFor(user => user.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");
            RuleFor(user => user.PasswordHash).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.");
            RuleFor(user => user.Rol).NotNull().WithMessage("Rol seçimi yapılmalıdır.");
        }
    }
}
