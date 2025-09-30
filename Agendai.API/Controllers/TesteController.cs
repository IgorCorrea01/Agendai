using Agendai.Infra.Data.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Agendai.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TesteController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("conexao")]
        public async Task<IActionResult> TestarConexao()
        {
            try
            {
                // Apenas testa se consegue abrir conexão
                var podeConectar = await _context.Database.CanConnectAsync();

                if (podeConectar)
                    return Ok("✅ Conexão com Postgres funcionando!");
                else
                    return StatusCode(500, "❌ Não foi possível conectar ao Postgres.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"❌ Erro ao conectar: {ex.Message}");
            }
        }
    }
}
