using Application.Request;
using FluentValidation;

namespace API.Validation.Authenticaction
{
    public class LoginValidator: AbstractValidator<LoginRequest>
    {
        public LoginValidator()
        {
            RuleFor(user => user.UserEmail)
               .NotEmpty().WithMessage("Email is required.")
               .EmailAddress().WithMessage("A valid email is required.");
            RuleFor(user => user.Password)
                .NotEmpty().WithMessage("Password is required.");                
        }
    }
}
