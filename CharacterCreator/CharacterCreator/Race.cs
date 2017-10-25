using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Race  //we make it public which isn't standart(public private protected)
    {
        private int strength;
        private int stamina;
        private string name;
 
        public int Stamina { get { return stamina; } set { stamina = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Strength { get { return strength; } set { strength = value; } }    //the first properity. write propp + tab tab
 
        //Aclass needs always constractor, it should be mentioned, so we specifie one
        public Race() //constractor:it build an instance of class, it contains information
            //what is it and what it does(it is for the memory not for the program)
            //it is nic to creat an empty constractor before the constractor!!!!
            //start with the smallest to the biggest.
        { }

        public Race (int str, int sta, string nam)
        {
            //Never use race = new race it does nothing just cost memeory lick.
            strength = str;

            Stamina = sta; //we choose this just to show, has nothing to do with anything else.

            name = nam;
    
        } 

        //creating the first method
        public virtual string PrintRace()        //virtual is one off 2 keywords is important when working with inheritance, means this class can be overloaded  
        {
            //we use return and not console.write due to progarmmering isuee here
            return "You Play as " + Name + "\nYour strength is " + Strength +
                ".\nYour stamina is " + Stamina + ".";
        }
    }
}
