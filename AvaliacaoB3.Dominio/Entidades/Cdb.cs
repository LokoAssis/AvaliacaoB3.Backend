using AvaliacaoB3.Dominio.Dto;
using AvaliacaoB3.Dominio.Validadores;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoB3.Dominio.Entidades
{
    public class Cdb : EntidadeBase
    {
        private double valorLiquido;

        public double ValorLiquido
        {
            get { return Math.Round(valorLiquido, 2); }
            private set { valorLiquido = value; }
        }

        private double valorBruto;

        public double ValorBruto
        {
            get { return Math.Round(valorBruto, 2); }
            private set { valorBruto = value; }
        }

        private double ValorInicial { get; set; }

        private int Prazo { get; set; }

        public Cdb(double valorInicial, int prazo)
        {
            ValorInicial = valorInicial;
            Prazo = prazo;
        }

        public Cdb CalcularCdb()
        {
            double valorCalculado = ValorInicial;

            for (int i = 1; i <= Prazo; i++)
            {
                valorCalculado *= (1 + 0.9 / 100 * (108 / 100));
            }

            double rendimento = valorCalculado - ValorInicial;

            ValorBruto = valorCalculado;
            ValorLiquido = valorCalculado - (CalcularImposto(Prazo, rendimento));

            return this;
        }

        private static double CalcularImposto(int prazo, double rendimento)
        {
            return rendimento * (ObterPorcentagemImposto(prazo) / 100);
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
