using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoB3.Dominio.Dto
{
    public class CalculoCdbRequestDto : BaseDto
    {
        public double ValorInicial { get; set; }

        public int Prazo { get; set; }
    }
}
