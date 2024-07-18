using Application.Request.KPI;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations.KPI
{
    public class KPIRequestValidator : AbstractValidator<KPIRequest>
    {
        public KPIRequestValidator()
        {
            RuleFor(kpi => kpi.Weight)
                .InclusiveBetween(1, 100)
                .WithMessage("Weight must be between 1 and 100.");
        }
    }
}
