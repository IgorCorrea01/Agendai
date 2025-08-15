using Agendai.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agendai.Infra.Data.Persistence.Configurations
{
    public class ServicoConfiguration : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.ToTable("Servicos");

            builder.HasKey(u => u.ServicoId);

            builder.Property(u => u.Nome).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Preco).IsRequired();
            builder.Property(u => u.Duracao).IsRequired();
            builder.Property(u => u.EstabelecimentoId).IsRequired();
        }
    }
}
