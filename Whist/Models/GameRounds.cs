using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class GameRounds
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int RoundNum { get; set; }
        public bool Ended { get; set; }
        public bool Started { get; set; }
        //public Types RoundType { get; set; }
        public Games Games { get; set; }
        //public SoleRound SoleRound { get; set; }
        //public NormalRound NormalRound { get; set; }
        public Types Types { get; set; }

        public List<GameRoundPlayers> GameRoundPlayersList { get; set; }
        public List<SoleRoundWinner> SoleRoundWinnerList { get; set; }
    }
}
