using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mock_SQL_DATA.Shared.Models;

namespace Mock_SQL_GENERATOR.Server.Configurations
{
    public class TypeEfConfigurations :IEntityTypeConfiguration<TypeName>
{
    public void Configure(EntityTypeBuilder<TypeName> builder)
    {
        builder.HasKey(t => t.IdType).HasName("Type_pk");

        builder.Property(t => t.IdType).UseMySqlIdentityColumn();

        builder.ToTable("TypeName");

        builder.Property(t => t.Name).HasMaxLength(100).IsRequired();
    }
}
}
