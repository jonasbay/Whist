using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class SoleRoundWinner
    {
        public int GameRoundId { get; set; }
        public int PlayerPos { get; set; }
        public int Tricks { get; set; }

        public GameRounds GameRound { get; set; }
    }
}
