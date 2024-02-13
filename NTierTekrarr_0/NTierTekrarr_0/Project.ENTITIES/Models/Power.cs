using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Power:BaseEntity
    {
        public string PowerName { get; set; }
        //relations
        public virtual List<PowerHero> PowerHeros { get; set; }
        public override string ToString()
        {
            return PowerName;
        }
    }
}
