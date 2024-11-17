using Application.Request;
using Application.Request.Auth;
using FluentValidation;

namespace API.Validation.Authenticaction
{
    public class NewEmailValidator: AbstractValidator<UpdateEmailVerification>
    {
        public NewEmailValidator()
        {
            RuleFor(user => user.NewEmail)
               .NotEmpty().WithMessage("Email is required.")
               .EmailAddress().WithMessage("A valid email is required.");
        }
    }
}
