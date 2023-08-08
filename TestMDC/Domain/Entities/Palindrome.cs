using FluentValidation;

namespace TestMDC.Domain.Entities
{
    public class Palindrome
    {
        public string Word { get; set; }
    }

    public class PalindromeValidator : AbstractValidator<Palindrome>
    {
        public PalindromeValidator()
        {
            RuleFor(s => s.Word).NotEmpty().WithMessage("It is necessary to write the word.");
        }
    }

}
