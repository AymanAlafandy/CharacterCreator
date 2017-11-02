using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Non_Sentient : Race
    {
        private bool tame;
            
        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }
        public Non_Sentient(){}
        public Non_Sentient(int str,int sta,string nam,bool tam):base(str,sta,nam)
        {
            Tame = tam;
        }

        public string PrintRace()
        {
            //return "Balloon";
            //  return base.PrintRace()+ "\nBalloon";
            string output = base.PrintRace();
            if (Tame)
            {
                output = "This is a tame X\n" + output;

            }

            else
            {
                output = "This is a Wild X\n" + output;
            }
            return output;

        }

    }
}
