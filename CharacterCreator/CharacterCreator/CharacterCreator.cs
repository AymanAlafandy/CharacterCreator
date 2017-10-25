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
            Race elf = new Race();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "Snapp";

            //another way

            Race orc = new Race(200, 80, "Bill");
            Race human = new Race(10, 10, "Thomas");
            Console.WriteLine(human.PrintRace());
            Console.ReadLine();
        }
    }
}
