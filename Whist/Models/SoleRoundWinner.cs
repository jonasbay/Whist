using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class SoleRoundWinner
    {
        public int Id { get; set; }
        public int GameRoundId { get; set; }
        public int Tricks { get; set; }

        public GameRounds GameRound { get; set; }
    }
}
