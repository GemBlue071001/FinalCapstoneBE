using Application.Request.Assessment;
using FluentValidation;


namespace Application.Validations
{
    public class GradeAssessmentValidator : AbstractValidator<GradeAssessmentRequest>
    {
        public GradeAssessmentValidator()
        {
            RuleFor(req => req.Point)
                .InclusiveBetween(0, 10)
                .WithMessage("Point must be between 0 and 10.");
        }
    }
}
