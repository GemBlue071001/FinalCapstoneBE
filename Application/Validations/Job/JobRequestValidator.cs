using Application.Request.Job;
using FluentValidation;


namespace Application.Validations.Job
{
    public class JobRequestValidator: AbstractValidator<JobRequest>
    {
        public JobRequestValidator() 
        { 
            RuleFor(j => j.Duration)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Duration must be positive");

            RuleFor(j => j.TotalMember)
                 .GreaterThanOrEqualTo(1)
                .WithMessage("TotalMember must be positive");
        }
    }
}
