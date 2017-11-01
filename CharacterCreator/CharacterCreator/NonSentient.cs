using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class NonSentient : Race_mosh
    {
        private bool tame;

        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }
        public  NonSentient() { }
        public NonSentient(int str, int sta, string nam, bool tam): base (str, sta, nam)
        {
            
        }
        public override string PrintRace()
        {
            return base.PrintRace() + "\nbaloon";
        }
    }
}
