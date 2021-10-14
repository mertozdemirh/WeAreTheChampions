using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public ICollection<Color> Colors { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<Match> Matches { get; set; }
    }
}
