using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class CharacterCreater1
    {
        public void Mainmenu()
        {


            Racenew[] party= new Racenew[3];      //Racenew[,] party= new Racenew[2,3];  **multi dimensional arrAY


            Sentient1 rcn = new Sentient1();
            rcn.Strength = 56;
            rcn.Stamina = 105;
            rcn.Name = "SAI";
            rcn.Intelligence = 200;
            //we can create either way to create a instance for a class

            /*Sentient1 cn1 = new Sentient1(200, 60, "sai",20); */
            //thats why we need to create constructor,if we have constructor then no need to give r declare like above

            Nonesentient1 cn1 = new Nonesentient1(200, 60, "sai", false);
            Human human = new Human(180, 50, "s",90);
            party[0] = rcn;
            party[1] = cn1;                                                            //  party[0,0] = rcn; party[0,1] = cn1; party[0,2] = human;

            party[2] = human;                                                         // party[1,0] = rcn; party[1,1] = cn1; party[1,2] = human;

            Console.WriteLine("You are playing as a" + party[2].GetType().Name+"\n"+ party[2].Printrace());                                           //Console.WriteLine(party[0,1].Printrace());
            Console.WriteLine(human.Calculatenumberoflanguages());
            Console.ReadLine();
        }

    }
}
