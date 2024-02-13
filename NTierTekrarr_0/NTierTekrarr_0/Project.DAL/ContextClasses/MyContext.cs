using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {
                
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new HeroMap());
            modelBuilder.Configurations.Add(new SideMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new RaceMap());
            modelBuilder.Configurations.Add(new PowerMap());
            modelBuilder.Configurations.Add(new PowerHerosMap());

        }
        public DbSet<Hero> Heros { get; set; }
        public DbSet<Side>Sides  { get; set; }
        public DbSet<Region>Regions { get; set; }
        public DbSet<Race>Races  { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<PowerHero> PowerHeroes  { get; set; }



    }
}
