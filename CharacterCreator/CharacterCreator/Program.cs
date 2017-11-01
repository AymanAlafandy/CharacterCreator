using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class Program
    {
        static void Main(string[] args)
        {

            CharacterCreator cc = new CharacterCreator(); //creating an instance of Character class
            cc.MainMenu();                                //calling MainMenu method  
            
            //the bottom has been removed and pasted into CharacterCreator class.  we want to keep
            //Program class / Main method as empty as possible.  Because everything that is in here is
            //immediately loaded and stored in memory for as long as the program in running.
            /*
            Race elf = new Race();      //Calling an instance of empty Race constructor
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "Snapp";

            Race orc = new Race(200, 80, "Bill"); // Calling an instance of Race, same as above, but shorter version
            Race human = new Race(10, 10, "Deidre");
            Console.WriteLine(human.PrintRace()); //calling the PrintRace instance from the class, can also have orc.PrintRace, etc
            Console.ReadLine();
            */
        }

    }
}

