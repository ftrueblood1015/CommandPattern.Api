﻿// <auto-generated />
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
    [Migration("20240110232654_guilds")]
    partial class guilds
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
#pragma warning restore 612, 618
        }
    }
}
