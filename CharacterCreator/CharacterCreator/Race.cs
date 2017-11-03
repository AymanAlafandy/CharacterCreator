using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Race
    {
        
       

        private int strength;

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        private int stamina;

        public int Stamina
        {
            get { return stamina; }
            set { stamina = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Race() { }


        public Race(int str, int sta, string nam)
        {
            strength = str;
            stamina = sta;
            name = nam;
        }

        public virtual string PrintRace()
        {
            return "You play as " + name + "\n Your strength is " + 
                strength + ". \n Your stamina is " + stamina + ".";
        }
        


    }
}
