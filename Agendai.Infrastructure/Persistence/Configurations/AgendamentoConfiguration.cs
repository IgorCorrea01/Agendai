using Agendai.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agendai.Infra.Data.Persistence.Configurations
{
    public class AgendamentoConfiguration : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("Agendamentos");

            builder.HasKey(u => u.AgendamentoId);

            builder.Property(u => u.ServicoId).IsRequired();
            builder.Property(u => u.ClienteId).IsRequired();
            builder.Property(u => u.DataHora).IsRequired();
            builder.Property(u => u.Status).IsRequired();
        }
    }
}
