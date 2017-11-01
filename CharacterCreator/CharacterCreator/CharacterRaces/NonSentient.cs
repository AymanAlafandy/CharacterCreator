using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.CharacterRaces
{
    public class NonSentient : Race
    {
        private bool tame;

        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }

        public NonSentient() { }
        public NonSentient(int str, int sta, string nam, bool tam):
            base(str,sta,nam)
        {
            Tame = tam;
        }

        public override string PrintRace()
        {
            string output = base.PrintRace();
            if(Tame)
            {
                output = "This is a tame X\n" + output;
            }
            else
            {
                output = "This is a wild X\n" + output;
            }
            return output;
        }

    }
}
