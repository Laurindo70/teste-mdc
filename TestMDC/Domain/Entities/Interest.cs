using FluentValidation;

namespace TestMDC.Domain.Entities
{
    public class Interest
    {
        public Double InitialCapital { get; set; }
        public Double InterestRate { get; set; }
        public int MonthsInvestment { get; set; }
    }

    public class InterestValidator : AbstractValidator<Interest>
    {
        public InterestValidator()
        {
            RuleFor(s => s.InitialCapital).NotEmpty().WithMessage("It is necessary to write the initial capital.");
            RuleFor(s => s.InterestRate).NotEmpty().WithMessage("It is necessary to write the Interest rate.");
            RuleFor(s => s.InitialCapital).NotEmpty().WithMessage("It is necessary to write the Investment Months.");
        }
    }
}
