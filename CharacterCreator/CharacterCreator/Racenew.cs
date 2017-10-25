using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Racenew                         //always specify the privacy of this class by giving access modifier-recommended
    {
        private int strength;
        private int stamina;
        private string name;

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        //Attributes


        public int Stamina
        {
            get { return stamina; }
            set { stamina = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }




        public Racenew()                         //It builds instance of class and its for the memory,which creates memory for variables,functions etc..
                                                 //if we dont create constructor,we need to callfields every time we call that racenew method
        {

        }

        public Racenew(int str, int sta, string nam)
        {
            Strength = str;
            Stamina = sta;         //here we can give attribute(starting vth big letter) or field name(starting vth small letter)
            Name = nam;
        }

        public virtual string Printrace()  //virtual class creates in parent class and override class creates in base/child classes

        {
            return "You play as" + Name + "\nStrength is" + Strength + "\nYour stamina is" + Stamina + ".";
        }


        }

    }

