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
            .NotEmpty()
                .WithMessage("Email is required.")
            .EmailAddress()
                .WithMessage("Invalid email address.");
        RuleFor(x => x.Phone)
            .NotEmpty()
            .WithMessage("Phone is required.")
            .Matches(@"^\+?[0-9]+$");

    }
}