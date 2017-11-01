using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.CharacterRaces
{
    public class Sentient : Race
    {
        private int intelligence;

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        public Sentient() { }
        public Sentient(int str, int sta, string nam, int intel) :
            base(str, sta, nam)
        {
            Strength = Strength * 2;
            Intelligence = intel;
        }
        
        public virtual int CalculateNumberOfLanguages(int mod = 0)
        {
            return (Intelligence + mod) % 3;
        }

        public override string PrintRace()
        {
           
            return base.PrintRace()+ "\nWith a intelligence of "+Intelligence;
        }
    }
}
