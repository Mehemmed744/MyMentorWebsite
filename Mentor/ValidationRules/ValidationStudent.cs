using FluentValidation;
using Mentor.Entities;

namespace Mentor.ValidationRules
{
    public class ValidationStudent : AbstractValidator<StudentClass>
    {
        public ValidationStudent()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Write Your Name");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Maximum size of name can be 50");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Minimum input 2 character");
            
        }
    }
}