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
        private int charisma;

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        public int Charisma
        {
            get { return charisma; }
            set { charisma = value; }
        }

        public Sentient() { }
        public Sentient(int str, int sta, string nam, int intel, int cha) :
            base(str, sta, nam)
        {
            Strength = Strength * 2;
            Intelligence = intel;
            Charisma = cha;
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
