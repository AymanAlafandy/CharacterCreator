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
            //Race[,] party = new Race[2, 3];

            Sentient elf = new Sentient();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "Snapp";
            elf.Intelligence = 200;
            elf.Charisma = 500;

            NonSentient orc = new NonSentient(200, 80, "Bill", false);
            Human human = new Human(10, 10, "Deidré", 90, 111);
            NonSentient orc2 = new NonSentient(160, 180, "Bull", false);
            Human human2= new Human(30, 30, "joé", 50, 12);
            NonSentient orc3 = new NonSentient(35, 10, "Old bob", false);
            Human human3 = new Human(1110, 1110, "Clark Kent", 60, 2000);
            Human human4 = new Human(10, 10, "Flark Flent", 600, 2000);
            //Race ka ;
            //ka = human;
            //party[0,0] = elf;
            //party[0,1] = orc;
            //party[0,2] = human;

            //Console.WriteLine("You are playing as a " +
            //    party[0,2].GetType().Name + "\n" + 
            //    party[0,2].PrintRace());
            Dog dog = new Dog(1, 2, "Chuchu", false);
            Dog dog2 = new Dog(10, 10, "Fido",true);
            Party<Sentient> party;
            //party = new Party<Race>(orc);
            party = new Party<Sentient>(human);
            //party = new Party<Race>(elf);
            //party.Hire(orc);
            //party.Hire(human);
            //party.Hire(orc2);
            party.Hire(elf);
            party.Hire(human2);
            //party.Hire(orc3);
            party.Hire(human3);
            //party.Fire(2);
            //party.Hire(dog);

            foreach(var race in party)
            {
                Console.WriteLine(race.PrintRace()+"\n--------------------------------\n");
            }
            Console.ReadLine();
            Console.WriteLine(party.OrderByDescending(x => x.Strength).FirstOrDefault().PrintRace());
           
          //  Console.WriteLine(party.OrderBy(y => y.Name.StartsWith("B")));

            foreach (var race in party.Where(x => x.Name.StartsWith("A") || x.Intelligence< 80).OrderBy(x =>x.Name).OrderBy(x =>x.Charisma))
            {
                Console.WriteLine(race.PrintRace()+"\n-------------------------------------------");
            }

            //Console.WriteLine(human.CalculateNumberOfLanguages());
            Console.ReadLine();
        }
    }
}
