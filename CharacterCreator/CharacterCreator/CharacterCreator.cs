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
            Sentient elf = new Sentient();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "Snapp";

            Sentient orc = new Sentient(200, 80, "Bill");
            Race human = new Race(10, 10, "Deidré");
            Console.WriteLine(orc.PrintRace());
            Console.ReadLine();
        }
    }
}
