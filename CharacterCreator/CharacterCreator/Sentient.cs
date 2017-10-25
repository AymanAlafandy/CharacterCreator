using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Sentient : Race
    {
        private int intelligence;

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        public Sentient() { }
        public Sentient(int str, int sta, string nam, int inte) :
            base(str, sta, nam)
        {
            Intelligence = inte;
        }
    }
}
