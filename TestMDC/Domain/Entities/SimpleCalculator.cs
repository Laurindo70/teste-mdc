using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace TestMDC.Domain.Entities
{
    public class SimpleCalculator
    {
        public float Number1 { get; set; }
        public float Number2 { get; set; }
        public string Operation { get; set; }
    }

    public class SimpleCalculatorValidator : AbstractValidator<SimpleCalculator>
    {
        public SimpleCalculatorValidator()
        {
            RuleFor(s => s.Number1).NotEmpty().WithMessage("It is necessary to write the first number.");
            RuleFor(s => s.Number2).NotEmpty().WithMessage("It is necessary to write the second number.");
            RuleFor(s => s.Operation).NotEmpty().WithMessage("It is necessary to select the operation.");
            RuleFor(s => s.Operation).Empty().When(x => !(x.Operation.Contains("-") || x.Operation.Contains("+") || x.Operation.Contains("/") || x.Operation.Contains("*"))).WithMessage("It is not an operation.");
        }
    }
}
