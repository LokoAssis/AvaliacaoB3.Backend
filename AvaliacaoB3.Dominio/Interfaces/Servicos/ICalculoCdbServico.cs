using AvaliacaoB3.Dominio.Dto;

namespace AvaliacaoB3.Dominio.Interfaces.Servicos
{
    public interface ICalculoCdbServico
    {
        public CalculoCdbResponseDto CalcularCdb(CalculoCdbRequestDto calculoCdbRequestDto);
    }
}
