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
            Race_mosh[,] party = new Race_mosh[2, 3];
            Sentient elf = new Sentient();

            elf.Stamina = 106;
            elf.Strength = 53;
            elf.Name = "snapp";

            //or
            Race_mosh pake = new Race_mosh(200, 95, "moshenne");
            NonSentient buke = new NonSentient(200, 80, "Bill", false);
            party[0, 0] = elf;
            party[0, 1] = pake;
            party[0, 3] = buke;
            Console.WriteLine(party[0, 0].PrintRace());
        }
    }
}
