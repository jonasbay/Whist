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
    [Migration("20200409093827_Without seed")]
    partial class Withoutseed
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
                });

            modelBuilder.Entity("Whist.Models.SoleRound", b =>
                {
                    b.HasBaseType("Whist.Models.Types");

                    b.Property<string>("SoloType")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("SoleRound");
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