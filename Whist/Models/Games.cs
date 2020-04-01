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
        public string Description { get; set; }
        public bool Started { get; set; }
        public bool Ended { get; set; }
        public bool Updates { get; set; }
        public List<GameRounds> GameRoundsList { get; set; }
        public List<Location> LocationList { get; set; }
        public List<GamePlayers> gamePlayersListForGames { get; set; }
    }
}
