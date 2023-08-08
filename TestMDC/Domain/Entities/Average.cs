using FluentValidation;

namespace TestMDC.Domain.Entities
{
    public class Average
    {
        public Double Grades1 { get; set; }
        public Double Grades2 { get; set; }
        public Double Grades3 { get; set; }
    }

    public class AverageValidator : AbstractValidator<Average>
    {
        public AverageValidator()
        {
            RuleFor(s => s.Grades1).NotEmpty().WithMessage("It is necessary to write the first note.");
            RuleFor(s => s.Grades1).NotEmpty().WithMessage("It is necessary to write the second note.");
            RuleFor(s => s.Grades1).NotEmpty().WithMessage("It is necessary to write the third note.");
        }
    }
}
