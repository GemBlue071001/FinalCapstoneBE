using Application.Request.BusinessStream;
using Application.Request.Company;
using FluentValidation;

namespace API.Validation.BusinessStream
{
    public class BusinessStreamRequestValidator : AbstractValidator<BusinessStreamRequest>
    {
        public BusinessStreamRequestValidator()
        {
            RuleFor(businessStream => businessStream.BusinessStreamName)
                .NotEmpty().WithMessage("BusinessStreamName is required.");
            RuleFor(businessStream => businessStream.Description)
                .NotEmpty().WithMessage("Description is required.");
        }
    }
}
