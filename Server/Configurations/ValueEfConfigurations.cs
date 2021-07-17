using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mock_SQL_DATA.Shared.Models;


namespace Mock_SQL_DATA.Server.Configurations
{
    public class ValueEfConfigurations : IEntityTypeConfiguration<ValueName>
{
    public void Configure(EntityTypeBuilder<ValueName> builder)
    {
        builder.HasKey(pm => new {pm.IdValue}).HasName("IdValue_pk");

        builder.Property(d => d.IdValue).UseMySqlIdentityColumn();
        
        // Nazwa tabeli (gdy jej nie ma będzie taka jak w Models
        builder.ToTable("ValueName");

        builder.HasOne(value => value.IdTypeNameNavigation)
            .WithMany(type => type.Values)
            .HasForeignKey(value => value.IdType)
            .HasConstraintName("TypeName_ValueName");


       // builder.Property(v => v.).HasMaxLength(100).IsRequired();

    }
}
}
