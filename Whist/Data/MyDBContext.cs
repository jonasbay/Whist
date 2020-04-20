using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Whist.Models;

namespace Whist.Data
{
    public class MyDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            // For SQLServer file, this is
            //ob.UseSqlServer("Data Source=127.0.0.1,1433;Database=Games_Whist;User ID=SA;Password=SecurePassword1!");
            ob.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Games_Whist");
        }

        public DbSet<GamePlayers> GamePlayers { get; set; }
        public DbSet<GameRoundPlayers> GameRoundPlayers { get; set; }
        public DbSet<GameRounds> GameRounds { get; set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<NormalRound> NormalRound { get; set; }
        public DbSet<Players> Players { get; set; }
        public DbSet<SoleRound> SoleRound { get; set; }
        public DbSet<SoleRoundWinner> SoleRoundWinner { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            //GameRounds
            mb.Entity<GameRounds>().HasKey(t => new { t.Id });
            mb.Entity<GameRounds>()
                .HasOne<Games>(t => t.Games)
                .WithMany(t => t.GameRoundsList)
                .HasForeignKey(t => t.GameId);
            

            //GameRoundPlayer
            mb.Entity<GameRoundPlayers>()
                .HasOne<GameRounds>(gr => gr.GameRounds)
                .WithMany(gr => gr.GameRoundPlayersList)
                .HasForeignKey(gr => gr.GameRoundId);

            //Games
            mb.Entity<Games>()
                .HasKey(g => new { g.Id });

            // Location
            mb.Entity<Location>().HasKey(l => new { l.Id });
            mb.Entity<Location>()
                .HasOne<Games>(r => r.Games)
                .WithMany(r => r.LocationList)
                .HasForeignKey(r => r.GameId);

            //GamePlayers
            mb.Entity<GamePlayers>().HasKey(p => new { p.Id });
            mb.Entity<GamePlayers>()
                .HasOne<Players>(r => r.Player)
                .WithMany(r => r.GamePlayersListForPlayers)
                .HasForeignKey(r => r.PlayerId);
            mb.Entity<GamePlayers>()
                .HasOne<Games>(g => g.Games)
                .WithMany(g => g.gamePlayersListForGames)
                .HasForeignKey(g => g.GameId);

            //Players
            mb.Entity<Players>()
                .HasKey(p => new { p.Id});

            //SoleRoundWinner
            mb.Entity<SoleRoundWinner>().HasKey(w => new { w.Id });
            mb.Entity<SoleRoundWinner>()
                .HasOne<GameRounds>(a => a.GameRound)
                .WithMany(a => a.SoleRoundWinnerList)
                .HasForeignKey(a => a.GameRoundId);

            //Types
            mb.Entity<GameRounds>()
                .HasOne(r => r.Types)
                .WithOne(r => r.GameRounds)
                .HasForeignKey<Types>();

            //--------------------------------------------------
            //Seed data
            mb.Entity<Players>().HasData(
                new Players { Id = 1, FirstName = "Hans", LastName = "Emil" },
                new Players { Id = 2, FirstName = "Alex", LastName = "Hansen" },
                new Players { Id = 3, FirstName = "Joe", LastName = "Moe" },
                new Players { Id = 4, FirstName = "Gurli", LastName = "Kristensen" },
                new Players { Id = 5, FirstName = "Henriette", LastName = "Bohl" },
                new Players { Id = 6, FirstName = "Top", LastName = "Gunn" },
                new Players { Id = 7, FirstName = "Palle", LastName = "Henriksen" },
                new Players { Id = 8, FirstName = "Julie", LastName = "Jensen" }
                );

            mb.Entity<Games>().HasData(
                new Games { Id = 1, Description = "Hallelujah", Started = true, Ended = false, Updates = true },
                new Games { Id = 2, Description = "Best Game", Started = false, Ended = false, Updates = true },
                new Games { Id = 3, Description = "Focused", Started = true, Ended = true, Updates = false }
                );

            mb.Entity<GamePlayers>().HasData(
                new GamePlayers { Id = 1, GameId = 2, PlayerId = 7, Points = 3 },
                new GamePlayers { Id = 2, GameId = 2, PlayerId = 3, Points = 4 },
                new GamePlayers { Id = 3, GameId = 2, PlayerId = 1, Points = 7 },
                new GamePlayers { Id = 4, GameId = 2, PlayerId = 5, Points = 6 },
                new GamePlayers { Id = 5, GameId = 3, PlayerId = 4, Points = 5 },
                new GamePlayers { Id = 6, GameId = 3, PlayerId = 8, Points = 4 },
                new GamePlayers { Id = 7, GameId = 3, PlayerId = 6, Points = 8 },
                new GamePlayers { Id = 8, GameId = 3, PlayerId = 2, Points = 6 },
                new GamePlayers { Id = 9, GameId = 1, PlayerId = 3, Points = 6 },
                new GamePlayers { Id = 10, GameId = 1, PlayerId = 4, Points = 10 },
                new GamePlayers { Id = 11, GameId = 1, PlayerId = 5, Points = 8 },
                new GamePlayers { Id = 12, GameId = 1, PlayerId = 2, Points = 500 }
                );

            mb.Entity<Location>().HasData(
                new Location { Id = 1, GameId = 2, Name = "Denmark" },
                new Location { Id = 2, GameId = 1, Name = "India" },
                new Location { Id = 3, GameId = 1, Name = "USA" },
                new Location { Id = 4, GameId = 3, Name = "China" }
                );

            mb.Entity<GameRounds>().HasData(
                new GameRounds { Id = 1, GameId = 2, Started = true, Ended = false, RoundNum = 1 },
                new GameRounds { Id = 2, GameId = 1, Started = false, Ended = false, RoundNum = 1 },
                new GameRounds { Id = 3, GameId = 3, Started = true, Ended = false, RoundNum = 1 },
                new GameRounds { Id = 4, GameId = 1, Started = false, Ended = false, RoundNum = 2 },
                new GameRounds { Id = 5, GameId = 2, Started = true, Ended = false, RoundNum = 2 },
                new GameRounds { Id = 6, GameId = 1, Started = false, Ended = false, RoundNum = 3 },
                new GameRounds { Id = 7, GameId = 3, Started = true, Ended = false, RoundNum = 2 }
                );

            mb.Entity<SoleRound>().HasData(
                new SoleRound { Id = 1, SoloType = "Good" },
                new SoleRound { Id = 4, SoloType = "Solo" },
                new SoleRound { Id = 5, SoloType = "Clean solo" },
                new SoleRound { Id = 6, SoloType = "Strong Oak" }
             );

            mb.Entity<NormalRound>().HasData(
                new NormalRound { Id = 2, Tricks = 7, BidAttachment = 2, BitTricks = 5 },
                new NormalRound { Id = 3, Tricks = 9, BidAttachment = 5, BitTricks = 5 },
                new NormalRound { Id = 7, Tricks = 7, BidAttachment = 4, BitTricks = 10 }
                );

            mb.Entity<GameRoundPlayers>().HasData(
                new GameRoundPlayers { Id = 1, GameRoundId = 1, Points = 10 },
                new GameRoundPlayers { Id = 2, GameRoundId = 2, Points = 4 },
                new GameRoundPlayers { Id = 3, GameRoundId = 4, Points = 2 },
                new GameRoundPlayers { Id = 4, GameRoundId = 3, Points = 1 },
                new GameRoundPlayers { Id = 5, GameRoundId = 6, Points = 6 },
                new GameRoundPlayers { Id = 6, GameRoundId = 7, Points = 3 }
                );

            mb.Entity<SoleRoundWinner>().HasData(
                new SoleRoundWinner { Id = 1, GameRoundId = 1, Tricks = 13 },
                new SoleRoundWinner { Id = 2, GameRoundId = 3, Tricks = 10 },
                new SoleRoundWinner { Id = 3, GameRoundId = 4, Tricks = 7 },
                new SoleRoundWinner { Id = 4, GameRoundId = 7, Tricks = 9 }
                );
        }
    }   
}
