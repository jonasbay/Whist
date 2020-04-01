using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class Players
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public List<GamePlayers> gamePlayersListForPlayers { get; set; }

    }
}
