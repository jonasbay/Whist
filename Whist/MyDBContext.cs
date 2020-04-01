using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Whist.Models;

namespace Whist
{
    public class MyDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            // For SQLServer file, this is
            ob.UseSqlServer("Data Source=127.0.0.1,1433;Database=XXXX;User ID=SA;Password=SecurePassword1!");
        }

        public DbSet<GamePlayers> gameplayers { get; set; }

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
                .HasKey(p => new {id = p.Id});

            //SoleRoundWinner
            mb.Entity<SoleRoundWinner>()
                .HasOne<GameRounds>(a => a.GameRound)
                .WithMany(a => a.SoleRoundWinnerList)
                .HasForeignKey(a => a.GameRoundId);

            //Types
            mb.Entity<Types>().HasKey(r => new { r.Id });
            mb.Entity<Types>()
                .HasOne<GameRounds>(r => r.GameRounds)
                .WithMany(r => r.TypesList)
                .HasForeignKey(r => r.Id);

            //SoleRound

            //NormalRound
        }
    }
    
}
