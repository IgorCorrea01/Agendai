using Agendai.Application.Contracts.Services;
using Agendai.Application.DTOs.Request;
using Microsoft.AspNetCore.Mvc;

namespace Agendai.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var usuario = await _usuarioService.GetByIdAsync(id);
                return Ok(usuario);
            }
            catch (Exception ex) { return NotFound(ex.Message); }
        }

        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            try
            {
                var usuario = await _usuarioService.GetByEmailAsync(email);
                return Ok(usuario);
            }
            catch (Exception ex) { return NotFound(ex.Message); }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var usuarios = await _usuarioService.GetAllAsync();
            return Ok(usuarios);
        }

        [HttpPost("registro")]
        public async Task<IActionResult> Registrar([FromBody] RegistroRequest request)
        {
            try
            {
                await _usuarioService.AddAsync(request);
                return Ok("Usuário registrado com sucesso.");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            try
            {
                var usuario = await _usuarioService.LoginAsync(request);
                return Ok(usuario);
            }
            catch (Exception ex) { return Unauthorized(ex.Message); }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Guid id, [FromBody] RegistroRequest request)
        {
            try
            {
                await _usuarioService.UpdateAsync(id, request);
                return NoContent();
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _usuarioService.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex) { return NotFound(ex.Message); }
        }
    }
}
