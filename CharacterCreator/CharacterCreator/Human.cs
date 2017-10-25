using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Human: Sentient
    {
        public Human()
        {

        }

        public Human(int str, int sta, string nam, int inte): base(str, sta, nam, inte)
        {
            Strength += 5;
            Stamina = inte;
        }

        public override string PrintRace()
        {
            return "You are playing as a "+ this.GetType().Name+ ".\n" + base.PrintRace();
        }

        public override int CalculateNumberOfLanguages(int mod = 8)
        {
            return base.CalculateNumberOfLanguages(mod);
        }
    }
}
