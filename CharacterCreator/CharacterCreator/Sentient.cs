using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    // class for those kind of thing can be aware by itself 
    public  class Sentient : Race 

    {
        private int intelligence;

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        public Sentient() { }
        public Sentient(int str, int sta, string nam, int intel) :
            base(str, sta, nam) // calling base class / one step up  
        {
            Strength = Strength * 2; // it vill return value from base class 
            Intelligence = intel;
        }

        public virtual int CalculateNumberOfLanguages(int mod = 0)
        {
            return (Intelligence + mod) % 3; // we get return remain the divison 
        }

        public override string PrintRace()
        {
            
            return base.PrintRace()+ "\nwith an intelligen of " + Intelligence;
        }
    }
}
