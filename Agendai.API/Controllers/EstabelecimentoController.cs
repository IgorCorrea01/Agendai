using Agendai.Application.Contracts.Services;
using Agendai.Application.DTOs.Request;
using Microsoft.AspNetCore.Mvc;

namespace Agendai.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstabelecimentoController : ControllerBase
    {
        private readonly IEstabelecimentoService _estabelecimentoService;

        public EstabelecimentoController(IEstabelecimentoService estabelecimentoService)
        {
            _estabelecimentoService = estabelecimentoService;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var estabelecimento = await _estabelecimentoService.GetByIdAsync(id);
                return Ok(estabelecimento);
            }
            catch (Exception ex) { return NotFound(ex.Message); }
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] EstabelecimentoRequest request)
        {
            try
            {
                await _estabelecimentoService.AddAsync(request);
                return Ok("Estabelecimento criado com sucesso.");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Guid id, [FromBody] EstabelecimentoRequest request)
        {
            try
            {
                await _estabelecimentoService.UpdateAsync(id, request);
                return NoContent();
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _estabelecimentoService.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex) { return NotFound(ex.Message); }
        }
    }
}
