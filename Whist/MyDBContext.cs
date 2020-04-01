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
                .HasForeignKey(t => t.Game_Id);
            

            //GameRoundPlayer
            mb.Entity<GameRoundPlayers>()
                .HasOne<GameRounds>(gr => gr.gameRounds)
                .WithMany(gr => gr.GameRoundPlayersList)
                .HasForeignKey(gr => gr.gameRoundId);

            //Games
            mb.Entity<Games>()
                .HasKey(g => new { g.Id });

            // Location
            mb.Entity<Location>().HasKey(l => new { l.Id });
            mb.Entity<Location>()
                .HasOne<Games>(r => r.Games)
                .WithMany(r => r.LocationList)
                .HasForeignKey(r => r.Game_Id);

            //GamePlayers
            mb.Entity<GamePlayers>()
                .HasOne<Players>(r => r.player)
                .WithMany(r => r.gamePlayersListForPlayers)
                .HasForeignKey(r => r.playerId);
            mb.Entity<GamePlayers>()
                .HasOne<Games>(g => g.games)
                .WithMany(g => g.gamePlayersListForGames)
                .HasForeignKey(g => g.gameId);

            //Players
            mb.Entity<Players>()
                .HasKey(p => new {p.id});

            //SoleRoundWinner
            mb.Entity<SoleRoundWinner>()
                .HasOne<GameRounds>(a => a.gameRound)
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
