using FluentValidation;
using MovieStoreC.Controllers;

namespace MovieStoreC.Validators
{
    public class TestValidator : AbstractValidator<TestRequest>
    {
        public TestValidator()
        {
            RuleFor(x => x.MagicNumber)
                .GreaterThan(0)
                .LessThan(10);
            RuleFor(x => x.Text)
                .NotNull()
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(250);
            RuleFor(x => x.DateTime)
                .NotNull()
                .GreaterThan(DateTime.MaxValue);
        }

    }
}
