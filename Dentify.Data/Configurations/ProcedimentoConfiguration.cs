using Dentify.Core.Models;
using Dentify.Core.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dentify.Data.Configurations;

public class ProcedimentoConfiguration : IEntityTypeConfiguration<Procedimento>
{
    public void Configure(EntityTypeBuilder<Procedimento> builder)
    {
        builder.ToTable(TabelasEnum.procedimentos.ToString());

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id").IsRequired().ValueGeneratedOnAdd();
        builder.Property(x => x.DataInicio).HasColumnName("data_inicio").IsRequired();
        builder.Property(x => x.Descricao).HasColumnName("descricao").IsRequired();
        builder.Property(x => x.PacienteId).HasColumnName("paciente_id").IsRequired();
        builder.Property(x => x.ConvenioId).HasColumnName("convenio_id").IsRequired();

        builder.HasOne(p => p.Paciente)
            .WithMany(pa => pa.Procedimentos)
            .HasForeignKey(p => p.PacienteId);

        builder.HasOne(p => p.Convenio)
            .WithMany(c => c.Procedimentos)
            .HasForeignKey(p => p.ConvenioId);
    }
}
