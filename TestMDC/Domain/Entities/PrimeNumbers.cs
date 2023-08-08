using FluentValidation;

namespace TestMDC.Domain.Entities
{
    public class PrimeNumbers
    {
        public int Number { get; set; }
    }

    public class PrimeNumberValidator : AbstractValidator<PrimeNumbers>
    {
        public PrimeNumberValidator()
        {
            RuleFor(s => s.Number).NotEmpty().WithMessage("It is necessary to write the number.");
        }
    }
}
