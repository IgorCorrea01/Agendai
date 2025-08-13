using Agendai.Domain.Repositories;
using Agendai.Infra.Data.Repositories;
using Agendai.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Agendai.Infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAgendaiInfra(this IServiceCollection services, IConfiguration configuration)
        {
            // - Serviços do usuario
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            // - Serviços do filme
            services.AddScoped<IEstabelecimentoRepository, EstabelecimentoRepository>();
            services.AddScoped<IEstabelecimentoService, EstabelecimentoService>();

            // - Serviços de serie
            services.AddScoped<IServicoRepository, ServicoRepository>();
            services.AddScoped<IServicoService, ServicoService>();

            // - Serviços do gênero
            services.AddScoped<IAgendamentoRepository, AgendamentoRepository>();
            services.AddScoped<IAgendamentoService, AgendamentoService>();

            // - Serviço de conexão com o banco de dados
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));


            services.AddAutoMapper(typeof(MappingDTOs));

            return services;
        }
    }
}