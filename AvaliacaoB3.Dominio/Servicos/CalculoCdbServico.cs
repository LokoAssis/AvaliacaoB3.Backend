using AutoMapper;
using AvaliacaoB3.Dominio.Dto;
using AvaliacaoB3.Dominio.Interfaces.Servicos;
using AvaliacaoB3.Dominio.Validadores;
using FluentValidation;

namespace AvaliacaoB3.Dominio.Servicos
{
    public class CalculoCdbServico : ICalculoCdbServico
    {
        public CalculoCdbResponseDto CalcularCdb(CalculoCdbRequestDto calculoCdbRequestDto)
        {
            if (ValidarDadosCdb(calculoCdbRequestDto, out CalculoCdbResponseDto calculoResponseCdb))
            {
                double valorBruto = calculoCdbRequestDto.ValorInicial;

                for (int i = 1; i <= calculoCdbRequestDto.Prazo; i++)
                {
                    valorBruto *= (1 + 0.9 / 100 * (108 / 100));
                }

                double rendimento = valorBruto - calculoCdbRequestDto.ValorInicial;

                calculoResponseCdb.ValorBruto = valorBruto;
                calculoResponseCdb.ValorLiquido = valorBruto - (rendimento * (ObterPorcentagemImposto(calculoCdbRequestDto.Prazo) / 100));
            }

            return calculoResponseCdb;
        }

        private static bool ValidarDadosCdb(CalculoCdbRequestDto calculoCdbRequestDto, out CalculoCdbResponseDto calculoResponseCdb)
        {
            calculoResponseCdb = new CalculoCdbResponseDto();

            var validador = Activator.CreateInstance<CalculoCdbValidador>();

            calculoResponseCdb.ValidationResult = validador.Validate(calculoCdbRequestDto);

            return calculoResponseCdb.ValidationResult.IsValid;
        }

        private static double ObterPorcentagemImposto(int prazo)
        {
            double porcentagemImposto;

            if (prazo <= 6)
            {
                porcentagemImposto = 22.5;
            }
            else if (prazo > 6 && prazo <= 12)
            {
                porcentagemImposto = 20;
            }
            else if (prazo > 12 && prazo <= 24)
            {
                porcentagemImposto = 17.5;
            }
            else
            {
                porcentagemImposto = 15;
            }

            return porcentagemImposto;
        }
    }
}
