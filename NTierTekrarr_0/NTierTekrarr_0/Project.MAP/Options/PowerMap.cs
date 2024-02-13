using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class PowerMap:BaseMap<Power>
    {
        public PowerMap()
        {
            ToTable("Güçler");
            Property(x => x.PowerName).HasColumnName("Güç Adı");
        }

    }
}
