using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Here I'm setting up an abstract class Combatant, which will be used as a framework for setting up both monsters and heroes, with fields that will only be accessible to derived classes both within and without this assembly, and a backing field (hp) for a public HP field.
    // The monsters I'll be setting up won't have individual names, though, so the name field is only set up as protected, as it will not get used by the monster derived classes. 
    abstract class Combatant
    {
        protected string name;
        protected internal int str;
        protected internal int dex;
        protected internal int con;
        protected internal int wis;
        protected internal int intel;
        protected internal int cha;
        public int HP;
        protected internal int hp
        {
            get
            {
                return HP;
            }
            set
            {
                if (HP <= 100 && HP >= 0)
                {
                    HP = value;
                }
            }
        }

        // This is an internal method, as I only want to call this method from within this assembly.
        internal void stats()
        {
            Console.WriteLine("Your hero's name is {0}, they have {1} hitpoints, and their stats are:", name, HP);
            Console.WriteLine("Strength: " + str);
            Console.WriteLine("Dexterity: " + dex);
            Console.WriteLine("Constitution: " + con);
            Console.WriteLine("Wisdom: " + wis);
            Console.WriteLine("Intelligence: " + intel);
            Console.WriteLine("Charisma: " + cha);
        }
    }
    class Fighter : Combatant
    {
        // Now I have a derived class that contains all the fields of the Hero abstract class, but also adds a private property hasShield, set by whether or not shieldType is null.
        public string shieldType;
        private bool hasShield
        {
            get
            {
                return hasShield;
            }
            set
            {
                if (shieldType != null)
                {
                    this.hasShield = true;
                } else
                {
                    this.hasShield = false;
                }
            }
        }
        // I only want to set up Fighter heroes in this assembly, so the constructor is an internal method.
        internal Fighter(string name)
        {
            this.name = name;
            this.str = 16;
            this.dex = 12;
            this.con = 18;
            this.wis = 8;
            this.intel = 8;
            this.cha = 10;
            this.HP = 80;
        }               
    }
    class Mage : Combatant
    {
        // Similar to shieldType, Mages have a special private hasWand property, only accessible to Mage methods.
        public string wandType;
        private bool hasWand
        {
            get
            {
                if(wandType != null)
                {
                    return true;
                }else
                {
                    return false;
                }
            }
        }
        // I only want to set up Mage heroes in this assembly, so the constructor is an internal method.
        internal Mage(string name)
        {
            this.name = name;
            this.str = 8;
            this.dex = 10;
            this.con = 8;
            this.wis = 14;
            this.intel = 16;
            this.cha = 12;
            this.HP = 40;
        } 
    }
    

    public class Program
    {
        public static void Main(string[] args)
        {
            Fighter fafhrd = new Fighter("Fafhrd");
            fafhrd.stats();         

            Mage glam = new Mage("Glamrock Fairyfart");
            glam.stats();       
        }
    }
}
