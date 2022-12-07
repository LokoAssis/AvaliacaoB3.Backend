using AvaliacaoB3.Dominio.Dto;
using AvaliacaoB3.Dominio.Interfaces.Servicos;
using AvaliacaoB3.Testes.Dados;
using Xunit;

namespace AvaliacaoB3.Testes
{
    public class CalculoCdbTeste
    {
        private readonly ICalculoCdbServico _calculoCdbServico;

        public CalculoCdbTeste(ICalculoCdbServico calculoCdbServico)
        {
            _calculoCdbServico = calculoCdbServico;
        }

        [Theory]
        [ClassData(typeof(TesteCalculoCdb_Sucesso))]
        public void TestarCalculoCdbValidos(double valorInicial, int prazo, double valorLiquido, double valorBruto)
        {
            var calculoCdbRequest = new CalculoCdbRequestDto { ValorInicial = valorInicial, Prazo = prazo };

            var result = _calculoCdbServico.CalcularCdb(calculoCdbRequest);

            Assert.Equal(valorLiquido, result.ValorLiquido);
            Assert.Equal(valorBruto, result.ValorBruto);
        }

        [Theory]
        [ClassData(typeof(TesteCalculoCdb_Invalido))]
        public void TestarCalculoCdbInvalidos(double valorInicial, int prazo)
        {
            var calculoCdbRequest = new CalculoCdbRequestDto { ValorInicial = valorInicial, Prazo = prazo };

            var result = _calculoCdbServico.CalcularCdb(calculoCdbRequest);

            Assert.False(result.ValidationResult.IsValid);
        }
    }
}