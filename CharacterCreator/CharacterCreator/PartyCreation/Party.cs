using CharacterCreator.CharacterRaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.PartyCreation
{
    public class Party<T> : IEnumerable<T> where T:Race //not really inheriting, just ensuring interface is here to be used.
    {                                                    //But only where T inerits from Race.   
        private T[] partyArray; //here T is used as a type indicator.
        private int capacity;
        private int count;

        public int Capacity
        { get
            { return capacity;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            private set
            {
                count = value;
            }
        }

        public Party(T input)          // creating constructor
        {            
            if(typeof(Sentient).IsAssignableFrom(input.GetType()))
            {
                capacity = ((input as Sentient).Charisma % 5) + 3;
                partyArray = new T[capacity]; 
            }
            else
            {
                capacity = 1;
                partyArray = new T[1];
            }
            partyArray[0] = input;
            count = 1;
        }

        public void Hire(T input)
        {
            if(count < capacity)
            {
                partyArray[count++] = input;                
            }
        }

        public void Fire(int id)
        {
            if (id != 0 && id <= capacity && partyArray[id] != null)
            {
                //partyArray[id] = null;
                if(id + 1 != capacity)
                {
                    //for(int i =1; i < partyArray.ToList().IndexOf(null); i++)
                    //{ }
                    for(int i = id; i < capacity; i++)
                    {
                        if(partyArray[i+1] != null && i+1 != capacity)
                        {
                            partyArray[i] = partyArray[i + 1];
                        }
                        else
                        {
                            partyArray[i] = null;
                        }
                    }

                }
                else
                {
                    partyArray[id] = null;
                }
                count--;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < count; i++)
            {
                yield return partyArray[i];
            }
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
