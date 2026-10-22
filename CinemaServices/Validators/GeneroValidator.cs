using CinemaDomain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaServices.Validators
{
    public class GeneroValidator : AbstractValidator<Genero>
    {
        public GeneroValidator()
        {
            RuleFor(global => global.Nome)
                .NotEmpty().WithMessage("Genero deve ser informado!")
                .NotNull().WithMessage("Genero deve ser informado!")
                .Length(5, 50).WithMessage("Genero deve ter entre 10 e 50 caracteres!");
        }
    }
}
