using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Racenew rcn= new Racenew();
            rcn.Strength = 56;
            rcn.Stamina = 105;
            rcn.Name = "SAi";                                       //we can create either way to create a instance for a class

            Racenew cn1= new Racenew(200, 60, "sai");
            Racenew cn2= new Racenew(180, 50, "s");
            Console.WriteLine(cn1.Printrace());
            Console.ReadLine();

        }
    }
}

