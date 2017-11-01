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
        
        public int Capacity { get { return capacity; } } //we removed the set because we do not want the user to set the number of capacity

        public int Count { get { return count; } private set { count = value; } }           

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
            }
            partyArray[0] = input; //that's mean if the array is sentient we still have 2 places u to +3
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
            if (id != 0 && id <= capacity && partyArray[id] != null)
            {
                //partyArray[id] = null;
                if (id+1 != capacity)
                {
                    for(int i = id/*partyArray.ToList().IndexOf(null)*/; i < capacity; i++)
                    {
                        if (partyArray[i+1] != null && i+1 != capacity)
                        {
                            partyArray[i] = partyArray[i + 1];
                        }
                        else
                        {
                            partyArray[i] = null;
                        }
                        count--;
                    }
                }
                //count--;
            }
            else
            {
                partyArray[id] = null;
            }
        }

        public IEnumerator<T> GetEnumerator()       //we implement the interface and that must be do every time.
        {
            //throw new NotImplementedException();
            for(int i = 0; i < count; i++)   //we use count and not capaciti because we do not want to hite a null value
            {
                yield return partyArray[i];   //yield: each value get return to the program, untill hitt all the values
            }                                 //when you inherite IEnumerable then it is recommanded to use yield

         }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //throw new NotImplementedException();
            return GetEnumerator();
        }
    }                                         
}
