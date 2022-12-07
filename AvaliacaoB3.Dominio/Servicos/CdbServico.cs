using AutoMapper;
using AvaliacaoB3.Dominio.Dto;
using AvaliacaoB3.Dominio.Entidades;
using AvaliacaoB3.Dominio.Interfaces.Servicos;
using AvaliacaoB3.Dominio.Validadores;
using FluentValidation;

namespace AvaliacaoB3.Dominio.Servicos
{
    public class CdbServico : ICdbServico
    {
        public Cdb CalcularCdb(CdbRequestDto cdbRequestDto)
        {
            if (ValidarDadosCdb(cdbRequestDto, out Cdb cdb))
                cdb.CalcularCdb();

            return cdb;
        }

        private static bool ValidarDadosCdb(CdbRequestDto cdbRequestDto, out Cdb cdb)
        {
            cdb = new Cdb(cdbRequestDto.ValorInicial, cdbRequestDto.Prazo);

            var validador = Activator.CreateInstance<CdbValidador>();

            cdb.ValidationResult = validador.Validate(cdbRequestDto);

            return cdb.ValidationResult.IsValid;
        }
    }
}
