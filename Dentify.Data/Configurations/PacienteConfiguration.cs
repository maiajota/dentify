using Dentify.Core.Models;
using Dentify.Core.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dentify.Data.Configurations;

public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
{
    public void Configure(EntityTypeBuilder<Paciente> builder)
    {
        builder.ToTable(TabelasEnum.pacientes.ToString());

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id").IsRequired().ValueGeneratedOnAdd();
        builder.Property(x => x.Nome).HasColumnName("nome").IsRequired().HasMaxLength(100);
        builder.Property(x => x.Cpf).HasColumnName("cpf").IsRequired().HasMaxLength(11);
        builder.Property(x => x.Rg).HasColumnName("rg").IsRequired().HasMaxLength(9);
        builder.Property(x => x.Cep).HasColumnName("cep").HasMaxLength(8);
        builder.Property(x => x.Logradouro).HasColumnName("logradouro").HasMaxLength(80);
        builder.Property(x => x.Bairro).HasColumnName("bairro").HasMaxLength(30);
        builder.Property(x => x.Numero).HasColumnName("numero").HasMaxLength(5);
        builder.Property(x => x.Telefone).HasColumnName("telefone").IsRequired().HasMaxLength(11);
    }
}
