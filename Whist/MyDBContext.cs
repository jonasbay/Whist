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

            //GameRounds

            //Games

            //Location

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

            //SoleRound

            //NormalRound
        }
    }
    
}
