using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Sentient : Race  //Sentient class inherits from Race class
    {
            private int intelligence;   //creating a property that is unique to sentient class

            public int Intelligence
            {
                get { return intelligence; }
                set { intelligence = value; }
            }

            public Sentient() { }
            public Sentient(int str, int sta, string nam, int intel) : base(str, sta, nam)  //creating instance of Sentient, but calls code from the base constructor also.
            {                                                                               // base = one step up, NOT necessarily to top of structure.
                Strength = Strength * 2;
                Intelligence = intel;
            }
        
            public virtual int CalculateNumberOfLanguages(int mod = 0) //assume modifier is 0
        {
            return (Intelligence + mod) % 3;   // % = modeless...returns the number that must be removed to make the number divisible by 3
        }

        //cannot override a constructor, only a function
        //U only ever use override if you want to change the base.
        //override takes the base and allows us to change it to our 'shape'
        //i.e, it takes PrintRace from Race, but adds extra bit of details also.
            public override string PrintRace()  
            {                                   
                return base.PrintRace()+"\nWith an intelligence of "+Intelligence;
            }
        }
    }

