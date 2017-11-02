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
            //Race elf = new Race();
            //  Race[] party = new Race[3];
            Race[,] party = new Race[2,3];
            Sentient elf = new Sentient();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "Snapp";
            elf.Intelligence = 200;

            //  Race orc = new Race(200, 80, "Bill");
            Non_Sentient orc = new Non_Sentient(200, 80, "Bill", false);
            //  Race human = new Race(200, 80, "Bhanu");

            Human human = new Human(200, 80, "Bhanu",90);

            // Sentient orc = new Sentient(200, 80, "Bill", 20);
            party[0,0]= elf;
            party[0,1] = orc;
            party[0,2] = human;

            //party[1, 0] = elf;
            //party[1, 1] = orc;
            //party[1, 2] = human;

            //  Console.WriteLine(party[0,1].PrintRace());
            Console.WriteLine("You are playing as" + party[0,2].GetType().Name +"\n"+
              party[0,2].PrintRace());
            Console.WriteLine(human.CalculateNumberOfLanguages());
            Console.ReadLine();
        }
    }
}
