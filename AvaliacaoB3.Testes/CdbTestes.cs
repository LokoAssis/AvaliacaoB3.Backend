using AvaliacaoB3.Dominio.Dto;
using AvaliacaoB3.Dominio.Interfaces.Servicos;
using AvaliacaoB3.Testes.Dados;
using Xunit;

namespace AvaliacaoB3.Testes
{
    public class CdbTeste
    {
        private readonly ICdbServico _cdbServico;

        public CdbTeste(ICdbServico cdbServico)
        {
            _cdbServico = cdbServico;
        }

        [Theory]
        [ClassData(typeof(TesteCdb_Sucesso))]
        public void TestarCdbValidos(double valorInicial, int prazo, double valorLiquido, double valorBruto)
        {
            var cdbRequest = new CdbRequestDto { ValorInicial = valorInicial, Prazo = prazo };

            var result = _cdbServico.CalcularCdb(cdbRequest);

            Assert.Equal(valorLiquido, result.ValorLiquido);
            Assert.Equal(valorBruto, result.ValorBruto);
        }

        [Theory]
        [ClassData(typeof(TesteCdb_Invalido))]
        public void TestarCdbInvalidos(double valorInicial, int prazo)
        {
            var cdbRequest = new CdbRequestDto { ValorInicial = valorInicial, Prazo = prazo };

            var result = _cdbServico.CalcularCdb(cdbRequest);

            Assert.False(result.ValidationResult.IsValid);
        }
    }
}