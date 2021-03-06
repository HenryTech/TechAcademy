using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // An interface is a template for methods. With this interface, I'm going to force every one of my Combatant subclasses to specify how they perform these various generic attacks.
    interface IAttack
    {
        string twoHanded();
        string oneHanded();
        string swordAndBoard();
    }
    // Now I set up my abstract class, which focuses mostly on properties that will be inherited by all sub-classes. Since all sub-classes will have to have some sort of attack, I've inherited from the IAttack interface to force all sub-classes to specify how they will attack.
    abstract class Combatant : IAttack
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

        public abstract string twoHanded();
        public abstract string oneHanded();
        public abstract string swordAndBoard();
    }
    class Fighter : Combatant, IAttack
    {
        public Fighter()
        {

        }
        // I only want to set up Fighter heroes in this assembly, so the constructor is an internal method.
        internal Fighter(string name)
        {
            this.name = name;
            str = 16;
            dex = 12;
            con = 18;
            wis = 8;
            intel = 8;
            cha = 10;
            HP = 80;
        }

        public override string oneHanded()
        {
            return (name + " can perform a one-handed attack with sword, mace, ax, hammer, short sword or dagger.");
        }

        public override string swordAndBoard()
        {
            return (name + " can perform a weapon/shield attack with sword, mace, ax, hammer, short sword or dagger.");
        }

        public override string twoHanded()
        {
            return (name + " can perform a two-handed attack with sword, mace, ax or hammer.");
        }
    }
    // This is a sealed class. It's a subclass of Fighter, but I don't want anyone making child classes of Berserker, so I've sealed it.
    sealed class Berserker : Fighter
    {
        internal Berserker(string name)
        {
            this.name = name;
            str = 18;
            dex = 14;
            con = 16;
            wis = 6;
            intel = 6;
            cha = 8;
            HP = 90;
        }
        public override string swordAndBoard()
        {
            return (name + " cannot perform weapon/shield attack.");
        }
    }
    class Mage : Combatant
    {
        // I only want to set up Mage heroes in this assembly, so the constructor is an internal method.
        internal Mage(string name)
        {
            this.name = name;
            str = 8;
            dex = 10;
            con = 8;
            wis = 14;
            intel = 16;
            cha = 12;
            HP = 40;
        }

        public override string oneHanded()
        {
            return (name + " can perform one-handed attack with a wand or dagger.");
        }

        public override string swordAndBoard()
        {
            return (name + " cannot perform a weapon/shield attack.");
        }

        public override string twoHanded()
        {
            return (name + " can perform two-handed attack, but only with a magical staff.");
        }
        // Mages are super-smart and can divide any number by 10. So here's a method to do that demonstrating try/catch/finally!
        public void divByTen()
        {
            try
            {
                Console.WriteLine("What number would you like " + name + " to divide 10 by?");
                // Here I use a nullable int so that I can check to see if the user merely hit enter to continue or actually input a value.
                int? num = int.Parse(Console.ReadLine());
                if (num.HasValue)
                {
                    Console.WriteLine(name + " intones in a frail voice '10 / {0} = {1}!'", num, (10 / num));
                }else
                {
                    Console.WriteLine(name + " perceives your lack of interest and disappears in a puff of smoke!");
                }                
            }
            catch (DivideByZeroException ex)
            {
                // In this block, I output a silly message to the console and split up the ex into name and message, then invoke Log().
                Console.WriteLine(name + "develops a migraine. Divide by zero error!");
                string typeName = (ex.GetType().Name);
                string msg = (ex.Message);
                Log(typeName, msg);                
            }
            catch (FormatException ex)
            {
                Console.WriteLine(name + "knows you can't divide 10 by a string!");
                string typeName = (ex.GetType().Name);
                string msg = (ex.Message);
                Log(typeName, msg);
            }
            finally
            {
                Console.WriteLine(name + " is exhausted by your request and stumbles off, muttering about how their degree is in Arcane Studies, not basic math.");
            }
        }        
        public void Log(string typeName, string msg)
        {
            string logLine = String.Format("{0:G}: {1} | {2}.", System.DateTime.Now, typeName, msg);
            using (StreamWriter sw = File.AppendText("errorlog.txt"))
            {
                sw.Write("\r\nLog Entry : ");
                sw.WriteLine(logLine);
                sw.WriteLine("------------------------------------------------");
            }
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Fighter fafhrd = new Fighter("Fafhrd");
            fafhrd.stats();
            Console.WriteLine();
            Console.WriteLine(fafhrd.twoHanded());
            Console.WriteLine();

            Mage glam = new Mage("Glamrock Fairyfart");
            glam.stats();
            Console.WriteLine();
            Console.WriteLine(glam.oneHanded());
            glam.divByTen();
        }
    }
}
