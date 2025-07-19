using Dentify.Core.Models;
using Dentify.Core.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dentify.Data.Configurations;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable(TabelasEnum.usuarios.ToString());

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id").IsRequired().ValueGeneratedOnAdd();
        builder.Property(x => x.Nome).HasColumnName("nome").IsRequired().HasMaxLength(100);
        builder.Property(x => x.Email).HasColumnName("email").IsRequired().HasMaxLength(120);
        builder.Property(x => x.Senha).HasColumnName("senha").IsRequired().HasMaxLength(64);
    }
}
