using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Player
    {
        public int hp;
        public int maxHp;
        public int energy;
        public int maxEnergy;
        public int armor;
        public string name;
        public Stats skillStatstitics;
        public Player()
        {

        }
        public Player(int hp, int maxHp, int energy, int maxEnergy, int armor, string name)
        {
            this.hp = hp;
            this.maxHp = maxHp;
            this.energy = energy;
            this.maxEnergy = maxEnergy;
            this.armor = armor;
            this.name = name;
            
        }
        public void updatename(string name)
        {
            this.name = name;
        }
        public bool updateHp()
        {
            if(hp <= 0&&hp>maxHp)
            {
                return true;
            }
            return false;
        }
        public bool updateEnergy()
        {
            if(energy <= 0&&energy>maxEnergy)
            {
                return true;
            }
            return false;
        }
        public void updateArmor()
        {

        }
        public void learnSkills(Stats learnskills)
        {
            skillStatstitics = learnskills;
           
        }
        public string attack(Player p)
        {
            int effectivearmor = p.armor - (int)(skillStatstitics.penetration); 
            if(skillStatstitics.cost>energy)
            {
                return name + "attempted to use" + skillStatstitics.name + "But didn't have enough energy ";
            }
            energy = energy - skillStatstitics.cost;
            float totaldamage = skillStatstitics.damage * ((100 - effectivearmor) / 100);
            hp = hp - (int)totaldamage;
            string attackstring = name + " used" + skillStatstitics.name + " " + skillStatstitics.description + " agianst " + p.name + "doing " + totaldamage + "!"; 
            if(skillStatstitics.heal>0)
            {
                attackstring+=name + " healed for" + skillStatstitics.heal + "Health";
            }
            if(p.hp<=0)
            {
                attackstring += p.name + "died!";
            }
            else
            {
                float percentage = p.hp / p.maxHp * 100;
                attackstring += p.name + " is  at" + percentage + "health! ";
            }
            return attackstring;
        }

    }

}
