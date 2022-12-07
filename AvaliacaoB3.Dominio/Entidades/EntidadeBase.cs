using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoB3.Dominio.Entidades
{
    public abstract class EntidadeBase
    {
        public ValidationResult ValidationResult { get; set; }

        protected EntidadeBase()
        {
            ValidationResult = new ValidationResult();
        }
    }
}
