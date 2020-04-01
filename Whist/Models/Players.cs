using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class Players
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<GamePlayers> GamePlayersListForPlayers { get; set; }
    }
}
