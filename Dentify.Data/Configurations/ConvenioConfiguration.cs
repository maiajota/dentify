using Dentify.Core.Models;
using Dentify.Core.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dentify.Data.Configurations;

public class ConvenioConfiguration : IEntityTypeConfiguration<Convenio>
{
    public void Configure(EntityTypeBuilder<Convenio> builder)
    {
        builder.ToTable(TabelasEnum.convenios.ToString());

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id").IsRequired().ValueGeneratedOnAdd();
        builder.Property(x => x.Nome).HasColumnName("nome").IsRequired().HasMaxLength(50);
    }
}
