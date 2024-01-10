using CommandPattern.Domain.Entities.Mtg;
using Microsoft.EntityFrameworkCore;

namespace CommandPattern.Infrastructure
{
    public class CommandPatternContext : DbContext
    {
        public CommandPatternContext(DbContextOptions<CommandPatternContext> options) : base(options) { }

        public DbSet<Domain.Entities.Mtg.Set> Sets => Set<Domain.Entities.Mtg.Set>();
        public DbSet<CardType> CardTypes => Set<CardType>();
        public DbSet<ColorIdentity> ColorIdentities => Set<ColorIdentity>();
        public DbSet<Rarity> Rarities => Set<Rarity>();
        public DbSet<CardPurpose> CardPurposes => Set<CardPurpose>();
        public DbSet<Theme> Themes => Set<Theme>();
        public DbSet<Guild> Guilds => Set<Guild>();

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

            modelBuilder.Entity<Rarity>().HasData(
                new Rarity { Id = 1, Description = "Common", IsActive = true, Name = "C" },
                new Rarity { Id = 2, Description = "Uncommon", IsActive = true, Name = "U" },
                new Rarity { Id = 3, Description = "Rare", IsActive = true, Name = "R" },
                new Rarity { Id = 4, Description = "legendary", IsActive = true, Name = "U" }
            );

            modelBuilder.Entity<CardPurpose>().HasData(
                new CardPurpose { Id = 1, Description = "Mana Production", IsActive = true, Name = "Mana Production" },
                new CardPurpose { Id = 2, Description = "Creature Removal", IsActive = true, Name = "Creature Removal" },
                new CardPurpose { Id = 3, Description = "Enchantment Removal", IsActive = true, Name = "Enchantment Removal" },
                new CardPurpose { Id = 4, Description = "Artifact Removal", IsActive = true, Name = "Artifact Removal" }
            );

            modelBuilder.Entity<Theme>().HasData(
                new Theme { Id = 1, Description = "Creatures of the same type", IsActive = true, Name = "Tribal" }
            );

            modelBuilder.Entity<Guild>().HasData(
                new Guild { Id = 1, Description = "W U", IsActive = true, Name = "Azorius" }
            );
        }
    }
}
