using AutoMapper;
using AvaliacaoB3.Aplicacao.ViewModels;
using AvaliacaoB3.Dominio.Dto;
using AvaliacaoB3.Dominio.Interfaces.Servicos;
using AvaliacaoB3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoB3.Controllers
{
    public class CalculoController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ICdbServico _cdbServico;

        public CalculoController(ICdbServico cdbServico, IMapper mapper)
        {
            _cdbServico = cdbServico;
            _mapper = mapper;
        }

        [HttpPost("calculos/cdb")]
        [ProducesResponseType(typeof(CdbResponseViewModel), StatusCodes.Status200OK)]
        public IActionResult Criar([FromBody] CdbRequestViewModel cdbRequestViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _cdbServico.CalcularCdb(_mapper.Map<CdbRequestDto>(cdbRequestViewModel));
            return Response(_mapper.Map<CdbResponseViewModel>(result));
        }
    }
}
