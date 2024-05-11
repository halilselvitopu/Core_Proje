using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please enter a project name.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Please enter a Image URL.");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Please enter a Image URL.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Please enter a price value.");
            RuleFor(x => x.Ratio).NotEmpty().WithMessage("Please enter a ratio value.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Project name must be at least 3 characters long.");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Project name cannot exceed 100 characters.");
        }
    }
}
