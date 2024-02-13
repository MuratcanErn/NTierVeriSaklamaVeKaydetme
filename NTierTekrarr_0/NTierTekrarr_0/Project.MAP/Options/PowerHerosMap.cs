using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class PowerHerosMap:BaseMap<PowerHero>
    {
        public PowerHerosMap()
        {
            ToTable("Kahraman Güçleri");
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.HeroID,
                x.PowerID
            });
        }
    }
}
