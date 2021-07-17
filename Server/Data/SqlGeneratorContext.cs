using System;
using Microsoft.EntityFrameworkCore;
using Mock_SQL_DATA.Shared.Models;

namespace Mock_SQL_DATA.Server.Data
{
    public class SqlGeneratorContext :DbContext
{
    public SqlGeneratorContext()
    {

    }

    public SqlGeneratorContext(DbContextOptions<SqlGeneratorContext> options) : base(options)
    {

    }

    public virtual DbSet<TypeName> Type { get; set; }
    public virtual DbSet<ValueName> Value { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       // modelBuilder.ApplyConfiguration()
    }
}

}
