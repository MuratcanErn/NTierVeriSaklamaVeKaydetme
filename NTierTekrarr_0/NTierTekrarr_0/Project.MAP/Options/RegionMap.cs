﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class RegionMap:BaseMap<Region>
    {
        public RegionMap()
        {
            ToTable("Bölgeler");
            Property(x => x.RegionName).HasColumnName("Bölge Adı");
        }
    }
}
