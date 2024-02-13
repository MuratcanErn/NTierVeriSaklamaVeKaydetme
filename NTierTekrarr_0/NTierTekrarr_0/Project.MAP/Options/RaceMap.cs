using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class RaceMap:BaseMap<Race>
    {
        public RaceMap()
        {
            ToTable("Irklar");
            Property(x => x.RaceName).HasColumnName("Irk Adı");
        }
    }
}
