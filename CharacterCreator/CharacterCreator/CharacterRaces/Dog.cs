using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.CharacterRaces    //it called I hade ullterd the namespace to be match
{
    public class Dog : NonSentient
    {
        public Dog(int str, int sta, string nam, bool tam = true) : base(str, sta, nam, tam)
        {
            sta += 1;
        }

        public string Speak()
        {
            return "woff";
        }
    }
}
