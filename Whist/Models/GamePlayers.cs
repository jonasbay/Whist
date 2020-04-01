using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class GamePlayers
    {
        public int GameId { get; set; }
        public int PlayerPosition { get; set; }
        public int PlayerId { get; set; }
        public int Points { get; set; }

        public Players Player { get; set; }
        public Games Games { get; set; }
    }
}
