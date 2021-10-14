using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.models
{
    public class WeAreTheChampionsContext:DbContext
    {
        public WeAreTheChampionsContext():base("name=WeAreTheChampionsCon")
        {

        }
        public DbSet<Team> Teams { get; set; } 
        public DbSet<Color> Colors { get; set; }        
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
