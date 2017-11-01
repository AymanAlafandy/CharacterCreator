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
            Race[,] party = new Race[2,3];
            Sentient elf = new Sentient();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "Snapp";

            //another way

            NonSentient orc = new NonSentient(200, 80, "Bill", false);
            Human human = new Human(10, 10, "Thomas",90);
            party[0,0] = elf;
            party[0,1] = orc;
            party[0,2] = human;
            Console.WriteLine("You're playing as a "+ party[0,1].GetType().Name +"\n"+ party[0,2].PrintRace());
            Console.WriteLine(human.CalculateNumberOfLanguages());
            Console.ReadLine();
        }
    }
}
