using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class SideMap:BaseMap<Side>
    {
        public SideMap()
        {
            ToTable("Taraflar");
            Property(x => x.SideName).HasColumnName("Tarafı");
        }
    }
}
