using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Race
    {
        private int strength;  // creating a private field
        private int stamina;
        private string name;

        public int Strength // creating a property to access the above private field
        {
            get {
                return strength;
            }
            set {
                strength = value;
            }
        }
        public int Stamina // creating a property to access the above private field
        {
            get {
                return stamina;
            }
            set {
                stamina = value;
            }
        }
        public string Name // creating a property to access the above private field
        {
            get { return name;
            }             
                set { name = value;
            }
        }

        public Race()   // this is a constructor.  It builds an instance of an empty class. No details betw curly braces
        {}

        public Race (int str, int sta, string nam) //Constructor that instantiates the class with specific information required
        {
            strength = str;

            Stamina = sta;

            name = nam;
        }

        public virtual string PrintRace() //Method created to print race from any other class, using CW and calling this method
        {
            return "You play as " + Name + "\nYour strength is " + Strength + ".\nYour stamina is " + Stamina + ".";
            //All instances of print and read should be done in a single class, not everywhere.  If we return a string, we can use this 
            //in another instance and then print out to screen (instead of using CW everywhere)

            //if using return, each method/ all paths must result in a return (a usable value)
        }



    }


}
