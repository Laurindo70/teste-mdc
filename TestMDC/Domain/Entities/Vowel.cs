using FluentValidation;

namespace TestMDC.Domain.Entities
{
    public class Vowel
    {
        public string Sentence { get; set; }
    }

    public class VowelCounterValidator : AbstractValidator<Vowel>
    {
        public VowelCounterValidator()
        {
            RuleFor(s => s.Sentence).NotEmpty().WithMessage("It is necessary to write the setence.");
        }
    }
}
