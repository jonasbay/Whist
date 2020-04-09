﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Whist;

namespace Whist.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20200409082250_SeedData12")]
    partial class SeedData12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Whist.Models.GamePlayers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.ToTable("GamePlayers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameId = 2,
                            PlayerId = 7,
                            Points = 3
                        },
                        new
                        {
                            Id = 2,
                            GameId = 2,
                            PlayerId = 3,
                            Points = 4
                        },
                        new
                        {
                            Id = 3,
                            GameId = 2,
                            PlayerId = 1,
                            Points = 7
                        },
                        new
                        {
                            Id = 4,
                            GameId = 2,
                            PlayerId = 5,
                            Points = 6
                        },
                        new
                        {
                            Id = 5,
                            GameId = 3,
                            PlayerId = 4,
                            Points = 5
                        },
                        new
                        {
                            Id = 6,
                            GameId = 3,
                            PlayerId = 8,
                            Points = 4
                        },
                        new
                        {
                            Id = 7,
                            GameId = 3,
                            PlayerId = 6,
                            Points = 8
                        },
                        new
                        {
                            Id = 8,
                            GameId = 3,
                            PlayerId = 2,
                            Points = 6
                        },
                        new
                        {
                            Id = 9,
                            GameId = 1,
                            PlayerId = 3,
                            Points = 6
                        },
                        new
                        {
                            Id = 10,
                            GameId = 1,
                            PlayerId = 4,
                            Points = 10
                        },
                        new
                        {
                            Id = 11,
                            GameId = 1,
                            PlayerId = 5,
                            Points = 8
                        },
                        new
                        {
                            Id = 12,
                            GameId = 1,
                            PlayerId = 2,
                            Points = 500
                        });
                });

            modelBuilder.Entity("Whist.Models.GameRoundPlayers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameRoundId")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameRoundId");

                    b.ToTable("GameRoundPlayers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameRoundId = 1,
                            Points = 10
                        },
                        new
                        {
                            Id = 2,
                            GameRoundId = 2,
                            Points = 4
                        },
                        new
                        {
                            Id = 3,
                            GameRoundId = 4,
                            Points = 2
                        },
                        new
                        {
                            Id = 4,
                            GameRoundId = 3,
                            Points = 1
                        },
                        new
                        {
                            Id = 5,
                            GameRoundId = 6,
                            Points = 6
                        },
                        new
                        {
                            Id = 6,
                            GameRoundId = 7,
                            Points = 3
                        });
                });

            modelBuilder.Entity("Whist.Models.GameRounds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ended")
                        .HasColumnType("bit");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("RoundNum")
                        .HasColumnType("int");

                    b.Property<bool>("Started")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("GameRounds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ended = false,
                            GameId = 2,
                            RoundNum = 1,
                            Started = true
                        },
                        new
                        {
                            Id = 2,
                            Ended = false,
                            GameId = 1,
                            RoundNum = 1,
                            Started = false
                        },
                        new
                        {
                            Id = 3,
                            Ended = false,
                            GameId = 3,
                            RoundNum = 1,
                            Started = true
                        },
                        new
                        {
                            Id = 4,
                            Ended = false,
                            GameId = 1,
                            RoundNum = 2,
                            Started = false
                        },
                        new
                        {
                            Id = 5,
                            Ended = false,
                            GameId = 2,
                            RoundNum = 2,
                            Started = true
                        },
                        new
                        {
                            Id = 6,
                            Ended = false,
                            GameId = 1,
                            RoundNum = 3,
                            Started = false
                        },
                        new
                        {
                            Id = 7,
                            Ended = false,
                            GameId = 3,
                            RoundNum = 2,
                            Started = true
                        });
                });

            modelBuilder.Entity("Whist.Models.Games", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ended")
                        .HasColumnType("bit");

                    b.Property<bool>("Started")
                        .HasColumnType("bit");

                    b.Property<bool>("Updates")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Hallelujah",
                            Ended = false,
                            Started = true,
                            Updates = true
                        },
                        new
                        {
                            Id = 2,
                            Description = "Best Game",
                            Ended = false,
                            Started = false,
                            Updates = true
                        },
                        new
                        {
                            Id = 3,
                            Description = "Focused",
                            Ended = true,
                            Started = true,
                            Updates = false
                        });
                });

            modelBuilder.Entity("Whist.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameId = 2,
                            Name = "Denmark"
                        },
                        new
                        {
                            Id = 2,
                            GameId = 1,
                            Name = "USA"
                        },
                        new
                        {
                            Id = 3,
                            GameId = 3,
                            Name = "Kina"
                        });
                });

            modelBuilder.Entity("Whist.Models.Players", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Hans",
                            LastName = "Emil"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Alex",
                            LastName = "Hansen"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Joe",
                            LastName = "Moe"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Gurli",
                            LastName = "Kristensen"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Henriette",
                            LastName = "Bohl"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Top",
                            LastName = "Gunn"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Palle",
                            LastName = "Henriksen"
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Julie",
                            LastName = "Jensen"
                        });
                });

            modelBuilder.Entity("Whist.Models.SoleRoundWinner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameRoundId")
                        .HasColumnType("int");

                    b.Property<int>("Tricks")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameRoundId");

                    b.ToTable("SoleRoundWinner");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameRoundId = 1,
                            Tricks = 13
                        });
                });

            modelBuilder.Entity("Whist.Models.Types", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Types");
                });

            modelBuilder.Entity("Whist.Models.NormalRound", b =>
                {
                    b.HasBaseType("Whist.Models.Types");

                    b.Property<int>("BidAttachment")
                        .HasColumnType("int");

                    b.Property<int>("BitTricks")
                        .HasColumnType("int");

                    b.Property<int>("Tricks")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("NormalRound");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            BidAttachment = 2,
                            BitTricks = 5,
                            Tricks = 7
                        },
                        new
                        {
                            Id = 3,
                            BidAttachment = 5,
                            BitTricks = 5,
                            Tricks = 9
                        },
                        new
                        {
                            Id = 7,
                            BidAttachment = 4,
                            BitTricks = 10,
                            Tricks = 7
                        });
                });

            modelBuilder.Entity("Whist.Models.SoleRound", b =>
                {
                    b.HasBaseType("Whist.Models.Types");

                    b.Property<string>("SoloType")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("SoleRound");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SoloType = "Good"
                        },
                        new
                        {
                            Id = 4,
                            SoloType = "Solo"
                        },
                        new
                        {
                            Id = 5,
                            SoloType = "Clean solo"
                        },
                        new
                        {
                            Id = 6,
                            SoloType = "Strong Oak"
                        });
                });

            modelBuilder.Entity("Whist.Models.GamePlayers", b =>
                {
                    b.HasOne("Whist.Models.Games", "Games")
                        .WithMany("gamePlayersListForGames")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Whist.Models.Players", "Player")
                        .WithMany("GamePlayersListForPlayers")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Whist.Models.GameRoundPlayers", b =>
                {
                    b.HasOne("Whist.Models.GameRounds", "GameRounds")
                        .WithMany("GameRoundPlayersList")
                        .HasForeignKey("GameRoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Whist.Models.GameRounds", b =>
                {
                    b.HasOne("Whist.Models.Games", "Games")
                        .WithMany("GameRoundsList")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Whist.Models.Location", b =>
                {
                    b.HasOne("Whist.Models.Games", "Games")
                        .WithMany("LocationList")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Whist.Models.SoleRoundWinner", b =>
                {
                    b.HasOne("Whist.Models.GameRounds", "GameRound")
                        .WithMany("SoleRoundWinnerList")
                        .HasForeignKey("GameRoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Whist.Models.Types", b =>
                {
                    b.HasOne("Whist.Models.GameRounds", "GameRounds")
                        .WithOne("Types")
                        .HasForeignKey("Whist.Models.Types", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
