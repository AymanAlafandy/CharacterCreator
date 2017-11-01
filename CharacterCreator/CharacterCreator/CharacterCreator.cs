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
            // Race elf = new Race();      //Calling an instance of empty Race constructor

            Race[] party = new Race[3];

            Sentient elf = new Sentient();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "Snapp";
            elf.Intelligence = 200;

            NonSentient orc = new NonSentient(200, 80, "Bill",false); // Calling an instance of Race, same as above, but shorter version
            Human human = new Human(10, 10, "Deidre",90);
            party[0] = elf;
            party[1] = orc;
            party[2] = human;
            //In next CW line, check out GetType helpmethod
            Console.WriteLine("You are playing as a " + 
                            party[2].GetType().Name + "\n"+
                            party[2].PrintRace());
            Console.WriteLine(human.CalculateNumberOfLanguages());
            //Console.WriteLine(orc.PrintRace()); //calling the PrintRace instance from the class, can also have orc.PrintRace, etc
            Console.ReadLine();
        }    
    }
}
