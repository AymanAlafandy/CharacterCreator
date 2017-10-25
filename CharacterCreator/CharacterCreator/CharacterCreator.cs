using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class CharacterCreator
    {
        public void MainMenu()
        {
            Race[] party = new Race[3];

            Sentient elf = new Sentient();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "Ill";
            elf.Intelligence = 200;

            NonSentient orc = new NonSentient(200, 80, "Bill",false);
            Human human = new Human(10, 10, "Deidre", 90);

            party[0] = elf;
            party[1] = orc;
            party[2] = human;

            Console.WriteLine(party[0].PrintRace());
            Console.WriteLine(party[1].PrintRace());
            Console.WriteLine(party[2].PrintRace());
            Console.ReadKey();
        }
    }
}
