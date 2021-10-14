using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.models
{
    class Match
    {
        public int Id { get; set; }
        public DateTime MatchTime { get; set; }
        public int Team1Id { get; set; }
        public int Team2Id { get; set; }
        public Team Team { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }


    }
}
