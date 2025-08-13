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
            // DbContext via DI (Npgsql)
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            // Repositories (implementações já existem)
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IEstabelecimentoRepository, EstabelecimentoRepository>();
            services.AddScoped<IServicoRepository, ServicoRepository>();
            services.AddScoped<IAgendamentoRepository, AgendamentoRepository>();

            // Removi AutoMapper e Services por enquanto (não existem/estão incompletos)
            return services;
        }
    }
}