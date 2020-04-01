using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class GameRoundPlayers
    {
        public int GameRoundId { get; set; }
        public int Bye { get; set; }
        public int Points { get; set; }

        public GameRounds GameRounds { get; set; }
    }
}
