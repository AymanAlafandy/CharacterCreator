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
            //// take the order to create character for game
            //Race elf = new Race();
            //elf.Strength = 53;
            //elf.Stamina = 106;
            //elf.Name = "Snapp";

            //Race orc = new Race(200, 80, "Bill");
            //Race human = new Race(10, 10, "Deidre"); // Create a human character  
            //Console.WriteLine(human.PrintRace()); // print out character by calling PrintRace method


            //Console.ReadLine();


            // mainmenu is static main method and that will keep in memory untill program executed
            CharacterCreator cc = new CharacterCreator();
            cc.MainMenu();
        }
    }
}
