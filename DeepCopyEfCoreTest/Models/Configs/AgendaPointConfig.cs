using DeepCopyEfCoreTest.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeepCopyEfCoreTest.Models.Configs;

public class AgendaPointConfig : IEntityTypeConfiguration<AgendaPoint>
{
    public void Configure(EntityTypeBuilder<AgendaPoint> builder)
    {
        builder.HasKey(f => f.Id);
        builder.Property(f => f.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
    }
}