using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class CharacterCreator // Create inherite class

    {
        public void MainMenu()
        {
            Race[] party = new Race[3];

            // take the order to create character for game
            Sentient elf = new Sentient();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "Snapp";
            elf.Intelligence = 200;

            NonSentient orc = new NonSentient(200, 80, "Bill", false);
            Human human = new Human(10, 10, "Deidre", 90); // Create a human character  

            party[0] = elf;
            party[1] = orc;
            party[2] = human;
            Console.WriteLine("You are playing as a " + party[2].GetType().Name + "n" + party [2].PrintRace()); // print out character by calling PrintRace method
            Console.WriteLine(human.CalculateNumberOfLanguages());
            Console.ReadLine();
        }

    }
}
