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
            //GameRoundPlayers
            mb.Entity<GameRounds>().HasKey(r => new { r.Id });
            /*mb.Entity<GameRounds>()
                .HasOne(r => r.Games)
                .WithMany(g => g.Id)
                .HasForeignKey(r => r.Game_Id);*/

            //GameRounds

            //Games
            mb.Entity<Games>()
                .HasKey(g => new { g.Id });

            // Location
            mb.Entity<Location>().HasKey(l => new { l.Id });

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

            //Types

            //SoleRound

            //NormalRound
        }
    }
    
}
