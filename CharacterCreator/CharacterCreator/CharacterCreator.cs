using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class CharacterCreator
    {
        public void mainmenu()
        {

            Race elf = new Race();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "My Elf";

            Race orc = new Race(200, 80, "KIller");
            Race Human = new Race(2000, 5000, "Kunal");

            Console.WriteLine(Human.PrintRace());
            Console.ReadLine();

        }
    }
}
