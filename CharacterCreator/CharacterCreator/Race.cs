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
        private int stamina;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Stamina
        {
            get { return stamina; }
            set { stamina = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }


        public Race()
        {
              
        }

        public Race(int str, int sta, string nam)
        {
            Strength = str;
            Stamina = sta;
            Name = nam;
        }

        public virtual string PrintRace()
        {
            return "You play as " + Name + ".\nYour strength is " + Strength + ".\nYou stamina is " + Stamina + ".";
        }

    }
}
