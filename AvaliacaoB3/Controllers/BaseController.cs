using AvaliacaoB3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoB3.Controllers
{
    [ApiController]
    [Route("api")]
    public class BaseController : ControllerBase
    {
        protected new IActionResult Response(BaseViewModel result)
        {
            if (result == null || result.ValidationResult.IsValid)
            {
                return Ok(new
                {
                    sucesso = true,
                    dados = result
                });
            }

            return BadRequest(new
            {
                sucesso = false,
                dados = result.ValidationResult.Errors
            });
        }

        protected IActionResult ResponseOK(object result)
        {
            return Ok(new
            {
                sucesso = true,
                dados = result
            });
        }
    }
}
