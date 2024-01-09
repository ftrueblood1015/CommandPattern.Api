﻿using CommandPattern.Domain.Entities.Mtg;
using Microsoft.EntityFrameworkCore;

namespace CommandPattern.Infrastructure
{
    public class CommandPatternContext : DbContext
    {
        public CommandPatternContext(DbContextOptions<CommandPatternContext> options) : base(options) { }

        public DbSet<Domain.Entities.Mtg.Set> Sets => Set<Domain.Entities.Mtg.Set>();
        public DbSet<CardType> CardTypes => Set<CardType>();
        public DbSet<ColorIdentity> ColorIdentities => Set<ColorIdentity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Domain.Entities.Mtg.Set>().HasData(
                new Domain.Entities.Mtg.Set { Id = 1, Description = "Alpha", IsActive = true, Name = "Alpha", ReleaseYear = 1993 }
            );

            modelBuilder.Entity<CardType>().HasData(
                new CardType { Id = 1, Description = "Creature", IsActive = true, Name = "Creature" },
                new CardType { Id = 2, Description = "Basic Land", IsActive = true, Name = "Basic Land" },
                new CardType { Id = 3, Description = "Land", IsActive = true, Name = "Land" },
                new CardType { Id = 4, Description = "Artifact", IsActive = true, Name = "Artifact" },
                new CardType { Id = 5, Description = "Instant", IsActive = true, Name = "Instant" },
                new CardType { Id = 6, Description = "Sorcery", IsActive = true, Name = "Sorcery" },
                new CardType { Id = 7, Description = "Enchantment", IsActive = true, Name = "Enchantment" }
            );

            modelBuilder.Entity<ColorIdentity>().HasData(
                new ColorIdentity { Id = 1, Description = "Green", IsActive = true, Name = "G" },
                new ColorIdentity { Id = 2, Description = "Black", IsActive = true, Name = "B" },
                new ColorIdentity { Id = 3, Description = "Red", IsActive = true, Name = "R" },
                new ColorIdentity { Id = 4, Description = "Blue", IsActive = true, Name = "U" },
                new ColorIdentity { Id = 5, Description = "White", IsActive = true, Name = "W" },
                new ColorIdentity { Id = 6, Description = "Colorless", IsActive = true, Name = "-" }
            );
        }
    }
}
