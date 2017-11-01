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
            Race[] party = new Race[3];
            Sentient elf = new Sentient();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "My Elf";

            Race orc = new Race(200, 80, "Killer");
            Race Human = new Race(2000, 5000, "Kunal");
            party[0] = elf;
            party[1] = orc;
            party[3] = Human ;


            Console.WriteLine(party[1].PrintRace());
            Console.WriteLine(Human.PrintRace());
            Console.ReadLine();

        }
    }
}
