using Entities.Concrete;
using FluentValidation;

namespace Business.Validation;

public class StaffValidator : AbstractValidator<Staff>
{
    public StaffValidator()
    {
        RuleFor(s => s.FirstName).MaximumLength(20).WithMessage("First Name parametresi 20 karakteri aşamaz");
        RuleFor(s => s.LastName).MaximumLength(20).WithMessage("Last Name parametresi 20 karakteri aşamaz");
        RuleFor(s => s.Email).NotEmpty().EmailAddress().WithMessage("Geçerli bir E-mail adresi giriniz");
        RuleFor(s => s.Phone).MaximumLength(12).WithMessage("Phone parametresi 12 karakteri aşamaz");
        RuleFor(s => s.AddressLine1).MaximumLength(200).WithMessage("Address Line1 parametresi 200 karakteri aşamaz");
        RuleFor(s => s.Country).MaximumLength(30).WithMessage("Country parametresi 30 karakteri aşamaz");
        RuleFor(s => s.City).MaximumLength(30).WithMessage("City parametresi 30 karakkteri aşamaz");
        RuleFor(s => s.Province).MaximumLength(30).WithMessage("Province parametresi 30 karakteri aşamaz");
    }
}
