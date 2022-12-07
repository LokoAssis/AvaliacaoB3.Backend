using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoB3.Dominio.Dto
{
    public class CalculoCdbResponseDto : BaseDto
    {
        private double valorLiquido;

        public double ValorLiquido
        {
            get { return valorLiquido; }
            set { valorLiquido = Math.Round(value, 2); }
        }

        private double valorBruto;

        public double ValorBruto
        {
            get { return valorBruto; }
            set { valorBruto = Math.Round(value, 2); }
        }
    }
}
