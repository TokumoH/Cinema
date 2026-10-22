using CinemaDomain;
using FluentValidation;

namespace CinemaServices.Validators
{
    internal class SessaoValidator : AbstractValidator<Sessao>
    {
        public SessaoValidator()
        {
            RuleFor(x => x.Data)
                .NotEmpty().WithMessage("Data da sessão deve ser informada!")
                .NotNull().WithMessage("Data da sessão deve ser informada!");

            RuleFor(x => x.Sala)
                .NotEmpty().WithMessage("Sala deve ser informada!")
                .NotNull().WithMessage("Sala deve ser informada!");

            RuleFor(x => x.Preco)
                .NotEmpty().WithMessage("Preço da sessão deve ser informado!")
                .NotNull().WithMessage("Preço da sessão deve ser informado!")
                .GreaterThan(0).WithMessage("Preço da sessão deve ser maior que zero!");

            RuleFor(x => x.Filme)
                .NotEmpty().WithMessage("Filme da sessão deve ser informado!")
                .NotNull().WithMessage("Filme da sessão deve ser informado!");
        }
    }
}
