using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Nonesentient1 : Racenew
    {

        private bool tame;
        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }
        public Nonesentient1()
        { }
        public Nonesentient1(int str, int sta, string nam, bool tam) : base(str, sta, nam)
        {
            Tame = tam;
        }

        public override string Printrace()
        {
            string output = base.Printrace();
            if (Tame)
            {
                output = "This is a tame" + output;
            }
            else
            {
                output = "This ia a wild X" + output;
            }
            return output;
        }
    }
}
