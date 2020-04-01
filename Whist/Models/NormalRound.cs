using System;
using System.Collections.Generic;
using System.Text;

namespace Whist.Models
{
    public class NormalRound : Types
    {
        public int GameRoundId { get; set; }
        public int Tricks { get; set; }
        public int BidAttachment { get; set; }
        public int BitTricks { get; set; }
    }
}
