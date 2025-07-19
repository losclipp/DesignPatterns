using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace Builder.User;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
                .WithMessage("Name is required.")
            .Matches(@"^[A-Za-z]+$")
                .WithMessage("Only Alphabetical characters are allowed.");
        RuleFor(x => x.Surname)
            .NotEmpty()
                .WithMessage("Surname is required.")
            .Matches(@"^[A-Za-z]+$")
                .WithMessage("Only Alphabetical characters are allowed.");
        RuleFor(x => x.Age)
             .GreaterThan(0)
                .WithMessage("Age must be greater than 0.");
        RuleFor(x => x.Email)
            .EmailAddress()
            .When( x => !string.IsNullOrWhiteSpace(x.Email))
                .WithMessage("Invalid email address.");
        RuleFor(x => x.Phone)
            .Matches(@"^\+?[0-9]+$")
            .When(x => !string.IsNullOrWhiteSpace(x.Phone))
                .WithMessage("Invalid phone number.");

    }
}