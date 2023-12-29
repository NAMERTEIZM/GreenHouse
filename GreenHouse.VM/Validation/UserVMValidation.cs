using FluentValidation;
using GreenHouse.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserVMValidator : AbstractValidator<UserVM>
{
    public UserVMValidator()
    {
        RuleFor(user => user.Adi).NotEmpty().WithMessage("Adı alanı boş olamaz.");
        RuleFor(user => user.Soyadi).NotEmpty().WithMessage("Soyadı alanı boş olamaz.");
        RuleFor(user => user.Email).NotEmpty().WithMessage("Email adresi boş olamaz").EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.");
        RuleFor(user => user.PasswordHash)
        .NotEmpty().WithMessage("Parola boş olamaz.")
        .MinimumLength(8).WithMessage("Parola en az 8 karakterden oluşmalıdır.")
        .MaximumLength(20).WithMessage("Parola en fazla 20 karakterden oluşmalıdır.")
        .Matches("[A-Z]").WithMessage("En az bir büyük harf içermelidir.")
        .Matches("[a-z]").WithMessage("En az bir küçük harf içermelidir.")
        .Matches("[0-9]").WithMessage("En az bir rakam içermelidir.")
        .Matches("[!@#]").WithMessage("En az bir özel karakter içermelidir (!, @, #).");

    }
}