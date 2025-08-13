using Agendai.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agendai.Infra.Data.Persistence.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(u => u.UsuarioId);

            builder.Property(u => u.Nome).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
            builder.Property(u => u.SenhaHash).IsRequired().HasMaxLength(255);
            builder.Property(u => u.Role).IsRequired().HasMaxLength(50);
        }
    }
}
