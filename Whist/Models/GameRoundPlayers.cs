using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class GameRoundPlayers
    {
        public int gameRoundId { get; set; }
        public int bye { get; set; }
        public int points { get; set; }

        public GameRounds gameRounds { get; set; }
    }
}
