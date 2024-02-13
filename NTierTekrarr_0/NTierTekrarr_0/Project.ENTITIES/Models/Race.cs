using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Race : BaseEntity
    {
        public string RaceName { get; set; }
        //relations
        public virtual List<Hero> Heros { get; set; }
    }
}
