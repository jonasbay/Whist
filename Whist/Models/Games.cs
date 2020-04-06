using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class Games
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Started { get; set; }
        public bool Ended { get; set; }
        public bool Updates { get; set; }
        public List<GameRounds> GameRoundsList { get; set; }
        public List<Location> LocationList { get; set; }
        public List<GamePlayers> gamePlayersListForGames { get; set; }

        //public override string ToString()
        //{
        //    //var gamePlayer = new StringBuilder();
        //    //foreach (var gp in gamePlayersListForGames)
        //    //{
        //    //    gamePlayer.Append(gp.).Append(", ");
        //    //}

        //    var gamePlayer = "";
        //    if (gamePlayersListForGames != null)
        //    {
        //        gamePlayer = string.Join("; ", gamePlayersListForGames);
        //    }

        //    return string.Format("Game Id: {0}, PlayerId: {1}", Id, gamePlayer);
        //}
    }
}
