using AdressbuchEntityFramework.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdressbuchEntityFramework.Model;

internal class AppDbContext : DbContext
{
   #region DB Sets

   internal DbSet<AdressEintrag> AdressEinträge { get; set; }
   internal DbSet<Adresse> Adressen { get; set; }

   #endregion

   #region Option-Methods

   /// <summary>
   /// Configures the DbContext
   /// </summary>
   /// <param name="optionsBuilder"></param>
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
      optionsBuilder.UseSqlite("Data Source=Adressen.db");
   }

   /// <summary>
   /// Creates the Model and Entity Options via FluentAPI
   /// </summary>
   /// <param name="modelBuilder"></param>
   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.Entity<AdressEintrag>()
         .HasMany(x => x.Adressen)
         .WithOne(x => x.AdressEintrag)
         .HasPrincipalKey(x => x.Id)
         .HasForeignKey(x => x.AdressEintragId);
   }

   #endregion
}