using CinemaDomain;
using FluentValidation;

namespace CinemaServices.Validators
{
    internal class SalaValidator : AbstractValidator<Sala>
    {
        public SalaValidator()
        {
            RuleFor(x => x.Capacidade)
                .NotEmpty().WithMessage("Capacidade da sala deve ser informada!")
                .NotNull().WithMessage("Capacidade da sala deve ser informada!")
                .GreaterThan(0).WithMessage("Capacidade da sala deve ser maior que zero!");

            RuleFor(x => x.Numero)
                .NotEmpty().WithMessage("Número da sala deve ser informado!")
                .NotNull().WithMessage("Número da sala deve ser informado!")
                .GreaterThan(0).WithMessage("Número da sala deve ser maior que zero!");

            RuleFor(x => x.Fileiras)
                .NotEmpty().WithMessage("Quantidade de fileiras deve ser informada!")
                .NotNull().WithMessage("Quantidade de fileiras deve ser informada!")
                .GreaterThan(0).WithMessage("Quantidade de fileiras deve ser maior que zero!");

            RuleFor(x => x.Assentos)
                .NotEmpty().WithMessage("Quantidade de assentos deve ser informada!")
                .NotNull().WithMessage("Quantidade de assentos deve ser informada!")
                .GreaterThan(0).WithMessage("Quantidade de assentos deve ser maior que zero!");
            RuleFor(x => x.Capacidade)
                .Equal(x => x.Fileiras * x.Assentos)
                .When(x => x.Fileiras > 0 && x.Assentos > 0)
                .WithMessage("Capacidade da sala deve ser igual ao produto de fileiras e assentos!");
        }
    }
}
