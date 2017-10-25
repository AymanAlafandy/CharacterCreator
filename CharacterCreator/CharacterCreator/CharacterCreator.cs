using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class CharacterCreator
    {
        //it doesn't need any constractor
        //we creat method
        public void MainMenu()
        {
            Sentient elf = new Sentient();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "Snapp";

            //another way

            NonSentient orc = new NonSentient(200, 80, "Bill", false);
            Race human = new Race(10, 10, "Thomas");
            Console.WriteLine(orc.PrintRace());
            Console.ReadLine();
        }
    }
}
