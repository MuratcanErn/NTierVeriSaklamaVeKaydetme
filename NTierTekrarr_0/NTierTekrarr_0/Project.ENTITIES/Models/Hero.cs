using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Hero:BaseEntity
    {
        public string HeroName { get; set; }
        public int RegionID { get; set; }
        public int RaceID { get; set; }
        //relations
        public Side Side { get; set; }
        public virtual Race Race { get; set; }
        public virtual Hero Heroo { get; set; }
        public virtual List<PowerHero> PowerHeros { get; set; }


    }
}
