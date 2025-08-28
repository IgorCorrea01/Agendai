using Agendai.Application.Contracts.Services;
using Agendai.Application.DTOs.Request;
using Microsoft.AspNetCore.Mvc;

namespace Agendai.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicoController : ControllerBase
    {
        private readonly IServicoService _servicoService;

        public ServicoController(IServicoService servicoService)
        {
            _servicoService = servicoService;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var servico = await _servicoService.GetByIdAsync(id);
                return Ok(servico);
            }
            catch (Exception ex) { return NotFound(ex.Message); }
        }

        [HttpGet("nome/{nome}")]
        public async Task<IActionResult> GetByName(string nome)
        {
            try
            {
                var servico = await _servicoService.GetByNameAsync(nome);
                return Ok(servico);
            }
            catch (Exception ex) { return NotFound(ex.Message); }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var servicos = await _servicoService.GetAllAsync();
            return Ok(servicos);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ServicoRequest request)
        {
            try
            {
                await _servicoService.AddAsync(request);
                return Ok("Serviço criado com sucesso.");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Guid id, [FromBody] ServicoRequest request)
        {
            try
            {
                await _servicoService.UpdateAsync(id, request);
                return NoContent();
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _servicoService.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex) { return NotFound(ex.Message); }
        }
    }

}
