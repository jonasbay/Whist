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
            mb.Entity<GameRounds>().HasKey(r => new { r.Id });
            mb.Entity<GameRounds>()
                .HasOne<Games>(r => r.Games)
                .WithMany(r => r.GameRoundsList)
                .HasForeignKey(r => r.Game_Id);
            

            //GameRoundPlayer

            //Games
            mb.Entity<Games>().HasKey(g => new { g.Id });

            // Location
            mb.Entity<Location>().HasKey(l => new { l.Id });
            mb.Entity<Location>()
                .HasOne<Games>(r => r.Games)
                .WithMany(r => r.LocationList)
                .HasForeignKey(r => r.Game_Id);

            //GamePlayers
            mb.Entity<GamePlayers>()
                .HasOne<Players>(r => r.player)
                .WithMany(r => r.gamePlayersList)
                .HasForeignKey(r => r.playerId);

            //Players
            mb.Entity<Players>()
                .HasKey(p => new {p.id});

            //SoleRoundWinner

            //Types
            mb.Entity<Types>().HasKey(r => new { r.Id });
           /* mb.Entity<Types>()
                .HasOne<GameRounds>(r => r.Games)
                .WithMany(r => r.GameRoundsList)
                .HasForeignKey(r => r.Game_Id);*/

            //SoleRound

            //NormalRound
        }
    }
    
}
