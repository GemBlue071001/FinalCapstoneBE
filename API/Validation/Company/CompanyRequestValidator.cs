using Application.Request.BusinessStream;
using Application.Request.Company;
using FluentValidation;

namespace API.Validation.Company
{
    public class CompanyRequestValidator : AbstractValidator<CompanyRequest>
    {
        public CompanyRequestValidator()
        {
            RuleFor(company => company.CompanyName)
                .NotEmpty().WithMessage("CompanyName is required.");
            RuleFor(company => company.CompanyDescription)
                .NotEmpty().WithMessage("CompanyDescription is required.");
            RuleFor(company => company.EstablishedYear)
                .InclusiveBetween(1900, DateTime.Now.Year).WithMessage("Established year must be between 1900 and the current year.")
                .NotEmpty().WithMessage("Established year is required.");
            RuleFor(company => company.Country)
                .NotEmpty().WithMessage("Country is required.");
            RuleFor(company => company.City)
                .NotEmpty().WithMessage("City is required.");
            RuleFor(company => company.Address)
                .NotEmpty().WithMessage("Address is required.");
            RuleFor(company => company.NumberOfEmployees)
                .GreaterThan(0).WithMessage("Number of employees must be greater than 0.")
                .NotEmpty().WithMessage("Number of employees is required.");
        }
    }
}
