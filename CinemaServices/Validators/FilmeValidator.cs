using CinemaDomain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaServices.Validators
{
    public class FilmeValidator : AbstractValidator<Filme>
    {
        public FilmeValidator()
        {
            RuleFor(global => global.Nome)
                .NotEmpty().WithMessage("Nome do filme deve ser informado!")
                .NotNull().WithMessage("Nome do filme deve ser informado!")
                .Length(10, 50).WithMessage("Nome do filme deve ter entre 10 e 50 caracteres!");
            RuleFor(global => global.Duracao)
                .NotEmpty().WithMessage("Duração do filme deve ser informada!")
                .NotNull().WithMessage("Duração do filme deve ser informada!")
                .GreaterThan(0).WithMessage("Duração do filme deve ser maior que zero!");
            RuleFor(global => global.Genero)
                .NotEmpty().WithMessage("Genero do filme deve ser informado!")
                .NotNull().WithMessage("Genero do filme deve ser informado!");
            RuleFor(global => global.Classificacao)
                .NotEmpty().WithMessage("Classificação do filme deve ser informada!")
                .NotNull().WithMessage("Classificação do filme deve ser informada!")
                .Length(1, 5).WithMessage("Classificação do filme deve ter entre 1 e 5 caracteres!");
        }
    }
}
