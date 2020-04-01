using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class GamePlayers
    {
        public int gameId { get; set; }
        public int playerPosition { get; set; }
        public int playerId { get; set; }
        public int points { get; set; }

        public Players player { get; set; }
        public Games games { get; set; }
    }
}
