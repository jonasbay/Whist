using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class GamePlayers
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int PlayerId { get; set; }
        public int Points { get; set; }

        public Players Player { get; set; }
        public Games Games { get; set; }

        public override string ToString()
        {
            //var gamePlayer = new StringBuilder();
            //foreach (var gp in GamePlayersListForPlayers)
            //{
            //    gamePlayer.Append(gp.Player).Append(", ");
            //}

            return string.Format("Players Id: {0}, Points: {1}", PlayerId, Points);
        }

    }
}
