using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Race

    {
        // Filed of this class 
        private int strength;
        private int stamina;
        private string name;

        // propertie to get and set value // logic set and get value
        public int Strength {
            get {
                return strength;
            }
            set { strength = value; 
            }
        }
        public int Stamina
        {
            get
            {
                return stamina;
            }
            set
            {
                stamina = value;

            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }

        public Race()   //constructor to keep information for this class
        {
            // create  empty temporary one for if it need in the future use
        }

        //the order of template
        public Race( int str, int sta, string nam)
        {
            strength = str;

            Stamina = sta;

            name = nam;
        }

        // Create method to print character out with return type "string" 
        public virtual string PrintRace()
        {
            return "You play as " + Name + " \nYour strenght is " +
                Strength + "\n Your stamina is " + Stamina + "."; // Print into two line by using return keyword 
         }
    }
}
