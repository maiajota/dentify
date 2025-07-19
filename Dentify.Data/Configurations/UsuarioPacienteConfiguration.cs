using Dentify.Core.Models;
using Dentify.Core.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dentify.Data.Configurations;

public class UsuarioPacienteConfiguration : IEntityTypeConfiguration<UsuarioPaciente>
{
    public void Configure(EntityTypeBuilder<UsuarioPaciente> builder)
    {
        builder.ToTable(TabelasEnum.usuarios_pacientes.ToString());

        builder.HasKey(x => new { x.IdUsuario, x.IdPaciente });

        builder.Property(x => x.IdUsuario).HasColumnName("id_usuario").IsRequired();
        builder.Property(x => x.IdPaciente).HasColumnName("id_paciente").IsRequired();

        builder.HasOne(up => up.Usuario)
            .WithMany(u => u.UsuariosPacientes)
            .HasForeignKey(up => up.IdUsuario);

        builder.HasOne(up => up.Paciente)
            .WithMany(p => p.UsuariosPacientes)
            .HasForeignKey(up => up.IdPaciente);
    }
}
