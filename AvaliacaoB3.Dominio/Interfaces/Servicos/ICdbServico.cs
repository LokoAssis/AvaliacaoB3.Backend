using AvaliacaoB3.Dominio.Dto;
using AvaliacaoB3.Dominio.Entidades;

namespace AvaliacaoB3.Dominio.Interfaces.Servicos
{
    public interface ICdbServico
    {
        public Cdb CalcularCdb(CdbRequestDto cdbRequestDto);
    }
}
