using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class PowerHero : BaseEntity
    {
        public int HeroID { get; set; }
        public int PowerID { get; set; }
        //relations
        public Power Power { get; set; }
        public Hero Hero { get; set; }
    }

}