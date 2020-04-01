using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whist.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int GameId { get; set; }
        public Games Games { get; set; }
    }
}
