using CharacterCreator.CharacterRaces;
using CharacterCreator.PartyCreation;
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
            Race[,] party = new Race[2, 3];

            Sentient elf = new Sentient();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "Snapp";
            elf.Intelligence = 200;
            elf.Charisma = 500;

            //NonSentient orc = new NonSentient(200, 80, "Bill",false);
            Human human = new Human(10, 10, "Deidré", 90,110);
            //Race ka ;
            //ka = human;
            //party[0,0] = elf;
            //party[0,1] = orc;
            //party[0,2] = human;

            //Console.WriteLine("You are playing as a " +
            //    party[0,2].GetType().Name + "\n" + 
            //    party[0,2].PrintRace());

            Party<Race> party1;
            party1 = new Party<Race>(human);

            Console.WriteLine(human.CalculateNumberOfLanguages());
            Console.ReadLine();
        }
    }
}
