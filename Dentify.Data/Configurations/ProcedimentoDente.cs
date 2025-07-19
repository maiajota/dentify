using Dentify.Core.Models;
using Dentify.Core.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dentify.Data.Configurations;

public class ProcedimentoDenteConfiguration : IEntityTypeConfiguration<ProcedimentoDente>
{
    public void Configure(EntityTypeBuilder<ProcedimentoDente> builder)
    {
        builder.ToTable(TabelasEnum.procedimentos_dentes.ToString());

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id").IsRequired().ValueGeneratedOnAdd();
        builder.Property(x => x.ProcedimentoId).HasColumnName("procedimento_id").IsRequired();
        builder.Property(x => x.DenteNumero).HasColumnName("dente_numero").IsRequired();

        builder.HasOne(pd => pd.Procedimento)
            .WithMany(p => p.ProcedimentoDente)
            .HasForeignKey(pd => pd.ProcedimentoId);
    }
}
