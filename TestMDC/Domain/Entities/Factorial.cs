using FluentValidation;

namespace TestMDC.Domain.Entities
{
    public class Factorial
    {
        public int Number { get; set; }
    }
    public class FactorialValidator : AbstractValidator<Factorial>
    {
        public FactorialValidator()
        {
            RuleFor(s => s.Number).NotEmpty().WithMessage("It is necessary to write the number.");
        }
    }
}
