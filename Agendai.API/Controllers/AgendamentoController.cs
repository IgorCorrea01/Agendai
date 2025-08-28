using Agendai.Application.Contracts.Services;
using Agendai.Application.DTOs.Request;
using Microsoft.AspNetCore.Mvc;

namespace Agendai.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : ControllerBase
    {
        private readonly IAgendamentoService _agendamentoService;

        public AgendamentoController(IAgendamentoService agendamentoService)
        {
            _agendamentoService = agendamentoService;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var agendamento = await _agendamentoService.GetByIdAsync(id);
                return Ok(agendamento);
            }
            catch (Exception ex) { return NotFound(ex.Message); }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var agendamentos = await _agendamentoService.GetAllAsync();
            return Ok(agendamentos);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AgendamentoRequest request)
        {
            try
            {
                await _agendamentoService.AddAsync(request);
                return Ok("Agendamento criado com sucesso.");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Guid id, [FromBody] AgendamentoRequest request)
        {
            try
            {
                await _agendamentoService.UpdateAsync(id, request);
                return NoContent();
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _agendamentoService.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex) { return NotFound(ex.Message); }
        }
    }
}
