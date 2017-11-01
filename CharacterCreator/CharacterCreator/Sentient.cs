using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
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

        public Sentient(int str, int sta, string nam, int intlligence) : base(str,sta,nam)
        {
            Intelligence = intlligence;
        }

        public override string   PrintRace()
        {
            return base.PrintRace() +" with intelligence of "+ Intelligence;
        }
    }
}
