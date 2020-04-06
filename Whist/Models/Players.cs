﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Whist.Models
{
    public class Players
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<GamePlayers> GamePlayersListForPlayers { get; set; }

        public override string ToString()
        {
            //var gamePlayer = new StringBuilder();
            //foreach (var gp in GamePlayersListForPlayers)
            //{
            //    gamePlayer.Append(gp.Player).Append(", ");
            //}

            return string.Format("Players Id: {0}, Player first name: {1}, Player last name: {2}", Id, FirstName, LastName);
        }
    }
}
