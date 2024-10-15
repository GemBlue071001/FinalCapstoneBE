using Application.Request;
using FluentValidation;

namespace API.Validation
{
    public class RegisterValidator : AbstractValidator<UserRegisterRequest>
    {
        public RegisterValidator()
        {
            RuleFor(user => user.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("A valid email is required.");
        }
    }
}
