using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class GameRounds
    {
        public int Id { get; set; }
        public int Game_Id { get; set; }
        public int RoundNum { get; set; }
        public int DealerPos { get; set; }
        public bool ended { get; set; }
        public bool started { get; set; }
        public string RoundType { get; set; }
        //public List<GameRoundPlayers> GameRoundPlayers { get; set; }
        //public List<SoleRoundWinner> SoleRoundWinner { get; set; }
    }
}
