using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class NonSentient : Race  // Inherit from Race
    {
        private bool tame;  //create private field

        public bool Tame   //Property that sets and gets from private field
        {
            get { return tame; }
            set { tame = value; }
        }

        public NonSentient() { }    //empty constructor
        public NonSentient(int str, int sta, string nam, bool tam) :        // specific constructor
            base(str, sta, nam)
        {
            Tame = tam;
        }

        public override string PrintRace()
        {
            string output = base.PrintRace();
            if (Tame)
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
