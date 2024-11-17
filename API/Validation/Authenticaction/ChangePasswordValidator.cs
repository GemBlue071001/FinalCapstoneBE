using Application.Request.Auth;
using FluentValidation;

namespace API.Validation.Authenticaction
{
    public class ChangePasswordValidator : AbstractValidator<ChangePasswordRequest>
    {
        public ChangePasswordValidator()
        {
            RuleFor(user => user.CurrentPassword)
            .NotEmpty().WithMessage("Current password is required.");

            RuleFor(user => user.NewPassword)
                .NotEmpty().WithMessage("New password is required.")
                .MinimumLength(7).WithMessage("Password must be more than 6 characters.");

            RuleFor(user => user.ConfirmPassword)
                .NotEmpty().WithMessage("Confirmation password is required.")
                .Equal(user => user.NewPassword).WithMessage("Confirmation password does not match the new password.");
        }
    }
}
