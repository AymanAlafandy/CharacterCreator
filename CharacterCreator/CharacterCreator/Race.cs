using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Race
    {
        public int Strength { get { return strength; } set { strength = value; } }
        public int Stamina { get { return stamina; } set { stamina = value; } }
        public string Name { get { return name; } set { name = value; } }

        private int strength;
        private int stamina;
        private string name;

        public Race()
        {       
        }

        public Race(int str,int sta,string nam) //constructor builds the instance of the class.Creates memory spaces for methods and variable.
        {

            Strength = str;

            Stamina = sta;

            Name = nam;

        }

        public string PrintRace()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("==================================================");
            return " You Play as : " + Name + "."
                 +"\n Your Srength is : " + Strength + "."
                 + "\n your Stamina is : " + Stamina+ ".";
            
        }

    }
}
