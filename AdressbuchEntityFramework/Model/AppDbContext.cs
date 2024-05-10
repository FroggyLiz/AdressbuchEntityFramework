﻿using AdressbuchEntityFramework.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdressbuchEntityFramework.Model;

internal class AppDbContext : DbContext
{
   public DbSet<AdressEintrag> AdressEinträge { get; set; }
   public DbSet<Adressen> Adressen { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
      optionsBuilder.UseSqlite("Data Source=Adressen.db");
   }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.Entity<Adressen>()
         .HasMany(x => x.AdressEintraege)
         .WithOne(x => x.Adressen)
         .HasPrincipalKey(x => x.Id)
         .HasForeignKey(x => x.AdressId);
   }
}