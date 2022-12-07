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
        private readonly ICalculoCdbServico _calculoServico;

        public CalculoController(ICalculoCdbServico calculoServico, IMapper mapper)
        {
            _calculoServico = calculoServico;
            _mapper = mapper;
        }

        [HttpPost("calculos/cdb")]
        [ProducesResponseType(typeof(CalculoCdbResponseViewModel), StatusCodes.Status200OK)]
        public IActionResult Criar([FromBody] CalculoCdbRequestViewModel calculoCdbRequestViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _calculoServico.CalcularCdb(_mapper.Map<CalculoCdbRequestDto>(calculoCdbRequestViewModel));
            return Response(_mapper.Map<CalculoCdbResponseViewModel>(result));
        }
    }
}
