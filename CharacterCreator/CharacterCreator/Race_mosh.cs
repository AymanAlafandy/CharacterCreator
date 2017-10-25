using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
     class Race_mosh
    {
        private int strength;
        private int stamina;
        private string name;

        public int Strength { get; set; }

        public int Stamina { get; set; }

        public string Name { get; set; }

       
        public Race_mosh() { }
        public Race_mosh(int str, int sta, string nam)
        {

            strength = str;
            name = nam;
            stamina = sta;

        }
        public string PrintRace()
        {
            return "You play as " + Name + "\nYour strength is " + Strength + "\nYour stamina is  " + stamina;
        }

    }
}


