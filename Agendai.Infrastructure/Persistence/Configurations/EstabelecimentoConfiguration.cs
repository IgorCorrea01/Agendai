using Agendai.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agendai.Infra.Data.Persistence.Configurations
{
    public class EstabelecimentoConfiguration : IEntityTypeConfiguration<Estabelecimento>
    {
        public void Configure(EntityTypeBuilder<Estabelecimento> builder)
        {
            builder.ToTable("Estabelecimentos");

            builder.HasKey(u => u.EstabelecimentoId);

            builder.Property(u => u.Nome).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Endereco).IsRequired().HasMaxLength(255);

            builder.Property(u => u.ProprietarioId).IsRequired();

            builder.HasMany(e => e.Servicos)
                    .WithOne(s => s.Estabelecimento)
                    .HasForeignKey(s => s.EstabelecimentoId);
        }
    }
}
