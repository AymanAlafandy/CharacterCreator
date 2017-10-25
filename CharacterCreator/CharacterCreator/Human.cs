using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class Human : Sentient1
    {
        public Human()
        { }
        public Human(int str, int sta, string nam, int inte) : base(str, sta, nam, inte)   //here it takses sentient1 clASS
        {
            Strength+= 5;
            Stamina += 5;
        }

        public override int Calculatenumberoflanguages(int mod = 8)
        {
            return Calculatenumberoflanguages(mod);
        }
        //public override string Printrace()
        //{
        //    return "You are playing as a "+this.GetType() +base.Printrace();
        //}
    }
}
