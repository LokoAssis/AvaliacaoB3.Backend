using AvaliacaoB3.Dominio.Dto;
using FluentValidation;

namespace AvaliacaoB3.Dominio.Validadores
{
    public class CalculoCdbValidador : AbstractValidator<CalculoCdbRequestDto>
    {
        public CalculoCdbValidador()
        {
            RuleFor(x => x.ValorInicial)
                .GreaterThan(0).WithMessage("Valor informado deve ser positivo.");

            RuleFor(x => x.Prazo)
                .GreaterThan(1).WithMessage("Prazo informado deve ser maior que 1(um).");
        }
    }
}
