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
        public Type RoundType { get; set; }
        public Games Games { get; set; }

        public List<GameRoundPlayers> GameRoundPlayersList { get; set; }
        public List<SoleRoundWinner> SoleRoundWinnerList { get; set; }
    }
}
