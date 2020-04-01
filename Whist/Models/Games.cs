using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class Games
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public string description { get; set; }
        public bool started { get; set; }
        public bool ended { get; set; }
        public bool updates { get; set; }
        public List<GameRounds> GameRoundsList { get; set; }
        public List<Location> LocationList { get; set; }
        public List<GamePlayers> gamePlayersListForGames { get; set; }
    }
}
