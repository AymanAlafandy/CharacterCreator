using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class Sentient : Race //we want our class to inheritence from race class
    {
        private int intelligence;

        public int Intelligence { get { return intelligence; } set { intelligence = value; } }
        //just to sill have the empty constractor
        public Sentient() { }
        public Sentient(int str, int sta, string nam, int inte) : base (str, sta, nam)
        //base is a tool to go one step upp.
        //we do not have to repeat the constractor information again.
        {
            Intelligence = inte;
        }
        public override string PrintRace()
        {
 
            return base.PrintRace() + "\n Whith an intelligence of " + intelligence;
        }
    }
}

//encapsulation is to limite the access to the date.