using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.CharacterRaces
{
    public class Human : Sentient
    {
        public Human() { }
        public Human(int str, int sta, string nam, int intel, int cha):
            base(str, sta, nam, intel, cha)
        {
            Strength += 5;
            Stamina += intel;
            Charisma += 10;
        }
        public override int CalculateNumberOfLanguages(int mod = 8)
        {
            return base.CalculateNumberOfLanguages(mod);
        }
        //public override string PrintRace()
        //{
        //    return base.PrintRace();
        //}

    }
}
