using CinemaDomain;
using FluentValidation;

namespace CinemaServices.Validators
{
    internal class IngressoItemValidator : AbstractValidator<IngressoItem>
    {
        public IngressoItemValidator()
        {
            RuleFor(x => x.Assento)
                .NotEmpty().WithMessage("Assento deve ser informado!")
                .NotNull().WithMessage("Assento deve ser informado!")
                .GreaterThan(0).WithMessage("Assento deve ser maior que zero!");

            RuleFor(x => x.Fileira)
                .NotEmpty().WithMessage("Fileira deve ser informada!")
                .NotNull().WithMessage("Fileira deve ser informada!")
                .GreaterThan(0).WithMessage("Fileira deve ser maior que zero!");

            RuleFor(x => x.Ingresso)
                .NotEmpty().WithMessage("Ingresso deve ser informado!")
                .NotNull().WithMessage("Ingresso deve ser informado!");
        }
    }
}
