using DeepCopyEfCoreTest.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeepCopyEfCoreTest.Models.Configs;

public class AgendaConfig : IEntityTypeConfiguration<Agenda>
{
    public void Configure(EntityTypeBuilder<Agenda> builder)
    {
        builder.HasKey(f => f.Id);
        builder.Property(f => f.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        
        builder
            .HasMany(f => f.Points)
            .WithOne()
            .IsRequired();
    }
}