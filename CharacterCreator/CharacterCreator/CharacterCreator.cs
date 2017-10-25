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
            Race_mosh elf = new Race_mosh();
            elf.Stamina = 106;
            elf.Strength = 53;
            elf.Name = "snapp";

            //or
            Race_mosh pake = new Race_mosh(200, 95, "moshenne");
            Console.WriteLine(elf.PrintRace());
        }
    }
}
