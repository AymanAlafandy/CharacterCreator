using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class CharacterCreator
    {
        public void MainMenu()
        {
            Race[] party = new Race[3];

            Sentient elf = new Sentient();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "Snapp";
            elf.Intelligence = 200;

            NonSentient orc = new NonSentient(200, 80, "Bill", false);
            Race human = new Race(10, 10, "Deidré");
            party[0] = elf;
            party[1] = orc;
            party[2] = human;
            Console.WriteLine(party[1].PrintRace());
            Console.ReadLine();
        }
    }
}
