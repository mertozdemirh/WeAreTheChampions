using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.models
{
    public class Color
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
