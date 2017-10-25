using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Sentient1 : Racenew //we inherit all the functions r methods here
    {

        private int intelligence;
        private int stamina;
        private string name;
        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        //Attributes


        public Sentient1()
        { }
        public Sentient1(int str, int sta, string nam, int inte) : base(str, sta, nam)
        {
            Strength = Strength * 2;     //here it will go to racenew cllaa_>strength and then to charatercreater then executes the output
            Intelligence = inte;
        }

        public virtual int Calculatenumberoflanguages(int mod = 0)
        {
            return (Intelligence+ mod)% 3;
        }

        public override string Printrace()              //giving virtual means we can call  fuctions but  abstract classes wont call,overidde we use 
        {
            return base.Printrace()+"\n with a intelligence of"+Intelligence;
        }
    }
}