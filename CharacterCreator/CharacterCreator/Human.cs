using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
   public class Human : Sentient
    {
        public Human() { }
        public Human(int str, int sta, string name, int intel):
            base(str, sta, name, intel)
        {

            Strength += 5;
            Stamina += intel;


        }

        public override int CalculateNumberOfLanguages(int mod = 8)
        {
            return base.CalculateNumberOfLanguages(mod);
        }

        //public override string PrintRace()
        //{
        //    return "You are playing as a " + this.GetType() +base.PrintRace();
        //}
    }
}
