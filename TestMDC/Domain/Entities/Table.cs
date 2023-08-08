using FluentValidation;

namespace TestMDC.Domain.Entities
{
    public class Table
    {
        public int Number { get; set; }
    }

    public class TablelValidator : AbstractValidator<Table>
    {
        public TablelValidator()
        {
            RuleFor(s => s.Number).NotEmpty().WithMessage("It is necessary to write the number.");
        }
    }
}
