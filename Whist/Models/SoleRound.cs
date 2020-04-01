using System;
using System.Collections.Generic;
using System.Text;

namespace Whist.Models
{
    public class SoleRound : Types
    {
        public int GameRoundId { get; set; }

        public Type SoloType { get; set; }

        public GameRounds GameRounds { get; set; }

    }
}
