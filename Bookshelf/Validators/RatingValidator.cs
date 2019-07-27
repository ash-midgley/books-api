using FluentValidation;
using Bookshelf.Models;

namespace Bookshelf.Validators
{
    public class RatingValidator : AbstractValidator<Rating>
    {
        public RatingValidator()
        {
            RuleFor(rating => rating.Description).NotNull();
            RuleFor(rating => rating.Code).NotNull();
        }
    }
}
