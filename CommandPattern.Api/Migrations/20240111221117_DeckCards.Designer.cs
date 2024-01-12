﻿// <auto-generated />
using System;
using CommandPattern.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CommandPattern.Api.Migrations
{
    [DbContext(typeof(CommandPatternContext))]
    [Migration("20240111221117_DeckCards")]
    partial class DeckCards
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.Card", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CardPurposeId")
                        .HasColumnType("bigint");

                    b.Property<long>("CardTypeId")
                        .HasColumnType("bigint");

                    b.Property<long>("ColorIdentityId")
                        .HasColumnType("bigint");

                    b.Property<int?>("ConvertedManaCost")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RarityId")
                        .HasColumnType("bigint");

                    b.Property<long>("SetId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CardPurposeId");

                    b.HasIndex("CardTypeId");

                    b.HasIndex("ColorIdentityId");

                    b.HasIndex("RarityId");

                    b.HasIndex("SetId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CardPurposeId = 1L,
                            CardTypeId = 4L,
                            ColorIdentityId = 6L,
                            ConvertedManaCost = 0,
                            Description = "Black Lotus",
                            IsActive = true,
                            Name = "Black Lotus",
                            RarityId = 3L,
                            SetId = 1L
                        });
                });

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.CardPurpose", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CardPurposes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Mana Production",
                            IsActive = true,
                            Name = "Mana Production"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "Creature Removal",
                            IsActive = true,
                            Name = "Creature Removal"
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Enchantment Removal",
                            IsActive = true,
                            Name = "Enchantment Removal"
                        },
                        new
                        {
                            Id = 4L,
                            Description = "Artifact Removal",
                            IsActive = true,
                            Name = "Artifact Removal"
                        });
                });

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.CardType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CardTypes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Creature",
                            IsActive = true,
                            Name = "Creature"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "Basic Land",
                            IsActive = true,
                            Name = "Basic Land"
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Land",
                            IsActive = true,
                            Name = "Land"
                        },
                        new
                        {
                            Id = 4L,
                            Description = "Artifact",
                            IsActive = true,
                            Name = "Artifact"
                        },
                        new
                        {
                            Id = 5L,
                            Description = "Instant",
                            IsActive = true,
                            Name = "Instant"
                        },
                        new
                        {
                            Id = 6L,
                            Description = "Sorcery",
                            IsActive = true,
                            Name = "Sorcery"
                        },
                        new
                        {
                            Id = 7L,
                            Description = "Enchantment",
                            IsActive = true,
                            Name = "Enchantment"
                        });
                });

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.ColorIdentity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ColorIdentities");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Green",
                            IsActive = true,
                            Name = "G"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "Black",
                            IsActive = true,
                            Name = "B"
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Red",
                            IsActive = true,
                            Name = "R"
                        },
                        new
                        {
                            Id = 4L,
                            Description = "Blue",
                            IsActive = true,
                            Name = "U"
                        },
                        new
                        {
                            Id = 5L,
                            Description = "White",
                            IsActive = true,
                            Name = "W"
                        },
                        new
                        {
                            Id = 6L,
                            Description = "Colorless",
                            IsActive = true,
                            Name = "-"
                        });
                });

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.Deck", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FormatId")
                        .HasColumnType("bigint");

                    b.Property<long>("GuildId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ThemeId")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("WinRate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("FormatId");

                    b.HasIndex("GuildId");

                    b.HasIndex("ThemeId");

                    b.ToTable("Decks");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Sliver Tribal",
                            FormatId = 1L,
                            GuildId = 1L,
                            IsActive = true,
                            Name = "Slivers!",
                            ThemeId = 1L,
                            WinRate = 0m
                        });
                });

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.DeckCard", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CardId")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<long?>("DeckId")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("DeckId");

                    b.ToTable("DeckCards");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CardId = 1L,
                            DeckId = 1L,
                            Description = "Black Lotus",
                            IsActive = true,
                            Name = "Black Lotus",
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.Format", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Formats");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Commander",
                            IsActive = true,
                            Name = "Commander"
                        });
                });

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.Guild", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Guilds");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "W U",
                            IsActive = true,
                            Name = "Azorius"
                        });
                });

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.Rarity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rarities");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Common",
                            IsActive = true,
                            Name = "C"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "Uncommon",
                            IsActive = true,
                            Name = "U"
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Rare",
                            IsActive = true,
                            Name = "R"
                        },
                        new
                        {
                            Id = 4L,
                            Description = "legendary",
                            IsActive = true,
                            Name = "U"
                        });
                });

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.Set", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sets");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Alpha",
                            IsActive = true,
                            Name = "Alpha",
                            ReleaseYear = 1993
                        });
                });

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.Theme", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Themes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Creatures of the same type",
                            IsActive = true,
                            Name = "Tribal"
                        });
                });

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.Card", b =>
                {
                    b.HasOne("CommandPattern.Domain.Entities.Mtg.CardPurpose", "CardPurpose")
                        .WithMany()
                        .HasForeignKey("CardPurposeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommandPattern.Domain.Entities.Mtg.CardType", "CardType")
                        .WithMany()
                        .HasForeignKey("CardTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommandPattern.Domain.Entities.Mtg.ColorIdentity", "ColorIdentity")
                        .WithMany()
                        .HasForeignKey("ColorIdentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommandPattern.Domain.Entities.Mtg.Rarity", "Rarity")
                        .WithMany()
                        .HasForeignKey("RarityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommandPattern.Domain.Entities.Mtg.Set", "Set")
                        .WithMany()
                        .HasForeignKey("SetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardPurpose");

                    b.Navigation("CardType");

                    b.Navigation("ColorIdentity");

                    b.Navigation("Rarity");

                    b.Navigation("Set");
                });

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.Deck", b =>
                {
                    b.HasOne("CommandPattern.Domain.Entities.Mtg.Format", "Format")
                        .WithMany()
                        .HasForeignKey("FormatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommandPattern.Domain.Entities.Mtg.Guild", "Guild")
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommandPattern.Domain.Entities.Mtg.Theme", "Theme")
                        .WithMany()
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Format");

                    b.Navigation("Guild");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("CommandPattern.Domain.Entities.Mtg.DeckCard", b =>
                {
                    b.HasOne("CommandPattern.Domain.Entities.Mtg.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommandPattern.Domain.Entities.Mtg.Deck", "Deck")
                        .WithMany()
                        .HasForeignKey("DeckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Deck");
                });
#pragma warning restore 612, 618
        }
    }
}
