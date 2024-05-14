using Application.Features.Brands.Commands.Create;
using FluentValidation;

namespace Application.Features.Brands.Commands;

public class CreateBrandCommandValidator : AbstractValidator<CreateBrandCommand>
{
    public CreateBrandCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty().MinimumLength(2);
    }
}
