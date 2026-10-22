using CinemaDomain;
using FluentValidation;

namespace CinemaServices.Validators
{
    internal class IngressoValidator : AbstractValidator<Ingresso>
    {
        public IngressoValidator()
        {
            RuleFor(x => x.Documento)
                .NotEmpty().WithMessage("Documento deve ser informado!")
                .NotNull().WithMessage("Documento deve ser informado!")
                .Length(5, 50).WithMessage("Documento deve ter entre 5 e 50 caracteres!");

            RuleFor(x => x.DataCompra)
                .NotEmpty().WithMessage("Data da compra deve ser informada!")
                .NotNull().WithMessage("Data da compra deve ser informada!");

            RuleFor(x => x.Sessao)
                .NotEmpty().WithMessage("Sessão deve ser informada!")
                .NotNull().WithMessage("Sessão deve ser informada!");

            RuleFor(x => x.ValorTotal)
                .NotEmpty().WithMessage("Valor total deve ser informado!")
                .NotNull().WithMessage("Valor total deve ser informado!")
                .GreaterThan(0).WithMessage("Valor total deve ser maior que zero!");

            RuleFor(x => x.FormaPagamento)
                .NotEmpty().WithMessage("Forma de pagamento deve ser informada!")
                .NotNull().WithMessage("Forma de pagamento deve ser informada!")
                .Length(3, 20).WithMessage("Forma de pagamento deve ter entre 3 e 20 caracteres!");

            RuleFor(x => x.IngressoItens)
                .NotNull().WithMessage("Itens do ingresso devem ser informados!")
                .NotEmpty().WithMessage("Deve existir pelo menos um item no ingresso!");
        }
    }
}
