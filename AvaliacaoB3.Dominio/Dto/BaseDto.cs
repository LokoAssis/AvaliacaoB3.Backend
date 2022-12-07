using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoB3.Dominio.Dto
{
    public class BaseDto
    {
        public ValidationResult ValidationResult { get; set; }

        public BaseDto()
        {
            ValidationResult = new ValidationResult();
        }
    }
}
