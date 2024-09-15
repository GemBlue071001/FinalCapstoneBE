using Application.Request;
using FluentValidation;


namespace Application.Validations.Job
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            
        }
    }
}
