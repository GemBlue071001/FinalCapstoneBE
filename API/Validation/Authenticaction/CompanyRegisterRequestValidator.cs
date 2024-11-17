using Application.Request.Auth;
using Application.Request.Company;
using DocumentFormat.OpenXml.Spreadsheet;
using FluentValidation;

namespace API.Validation.Authenticaction
{
    public class CompanyRegisterRequestValidator : AbstractValidator<CompanyRegisterRequest>
    {
        public CompanyRegisterRequestValidator()
        {
            RuleFor(user => user.Email)
              .NotEmpty().WithMessage("Email is required.")
              .EmailAddress().WithMessage("A valid email is required.");
        }
    }
}
