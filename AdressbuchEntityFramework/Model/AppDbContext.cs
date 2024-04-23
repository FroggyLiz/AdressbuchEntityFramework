using AdressbuchEntityFramework.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdressbuchEntityFramework.Model;

internal class AppDbContext : DbContext
{
    public DbSet<AdressEintrag> AdressEinträge { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Adressen.db");
    }
}