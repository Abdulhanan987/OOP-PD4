using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Stats
    {
        public string name;
        public int damage;
        public string description;
        public float penetration;
        public int cost;
        public float heal;
        public Stats(){


                }
        public Stats(string name, int damage, string description, float penetration, int cost, float heal)
        {
            this.name = name;
          
            this.damage = damage;
            this.description = description;
            this.penetration = penetration;
            this.cost = cost;
            this.heal = heal;
        }
    }
   
}
