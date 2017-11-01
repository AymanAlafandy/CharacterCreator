using CharacterCreator.CharacterRaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.PartyCreation
{
    public class Party<T> : IEnumerable<T>  where T : Race   
                                                //we are inheriting from ienumerable
    {                                          //interface is a templet that never contains any code
                                               //interfaces can inherites from eachother

        private T[] partyArray;     //this is an array and not list
        private int capacity;  //how large is our array is
        private int count;                        //how many fiels in this array we want to fill

        public Party(T input)
        {
            if (typeof(Sentient).IsAssignableFrom(input.GetType())) //type of return the acutal type value
            {     //input.GetType().Name == "Human"
                //partyArray = new T[((input as Sentient).Charisma % 5) +3 ];
                capacity = ((input as Sentient).Charisma % 5) + 3;
                partyArray = new T[capacity];
            }
            else
            {
                partyArray = new T[1];
                partyArray = new T[1];
            }
            partyArray[0] = input; //that's mean if the array is sentient we still have 2 places du to +3
            count = 1;
        }

        public void Hire(T input)
        {
            if(count < capacity)
            {
                partyArray[count++] = input;
                //count++;
            }
        }
        public void Fire ( int id)
        {
            if (id != 0 && id <= capacity)
            {
                partyArray[id] = null;
                count--;
            }
        }

        public IEnumerator<T> GetEnumerator()       //we implement the interface and that must be do every time.
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }                                         
}
