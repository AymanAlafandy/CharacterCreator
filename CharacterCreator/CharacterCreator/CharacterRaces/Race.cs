using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.CharacterRaces
{
    public class Race
    {
        private int strength;
        private int stamina;
        private string name;

        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value;
            }
        }
        public int Stamina
        {
            get
            {
                return stamina;
            }
            set
            {
                stamina = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //public void SetStamina(int sta)
        //{
        //    stamina = sta;
        //}
        //public Race (int str, int sta)
        //{
        //    Strength = str;
        //    Stamina = sta;
        //}

        public Race()
        {
        }

        //public Race(int str)
        //{
        //    Strength = str;
        //}
        //public Race(string nam)
        //{
        //    Name = nam;
        //}

        public Race(int str, int sta, string nam)
        {
            Stamina = sta;
            Name = nam;
            Strength = str;

       
        }

        public virtual string PrintRace()
        {
            return "You play as " + Name + "\nYour strength is " +
                Strength + ".\nYour stamina is " + Stamina + ".";
        }
    }
}
