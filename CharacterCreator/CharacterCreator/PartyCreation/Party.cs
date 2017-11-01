using CharacterCreator.CharacterRaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.PartyCreation
{
    public class Party<T> : IEnumerable<T> where T : Race
    {
        private T[] partyArray;
        private int capacity;
        private int count;

        public int Capacity
        {
            get
            {
                return capacity;
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

        public Party(T input)
        {
            if (typeof(Sentient).IsAssignableFrom(input.GetType()))
            {
                capacity = ((input as Sentient).Charisma % 5) + 3;
                partyArray = new T[capacity];
            }
            else
            {
                capacity = 1;
                partyArray = new T[capacity];
            }
            partyArray[0] = input;
            count = 1;
        }

        public void Hire(T input)
        {
            if (count < capacity)
            {
                //plus count after assign
                partyArray[count++] = input;
            }
        }

        public void Fire(int id)
        {
            if (id != 0 && id <= capacity && partyArray[id] != null)
            {
                if (id+1 != capacity)
                {
                    for(int i = id; i< capacity; i++)
                    {
                        if (partyArray[i + 1] != null && i + 1 != capacity)
                        {
                            partyArray[i] = partyArray[i + 1];
                        }
                        else
                            partyArray[i] = null;

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
            //return value and keep going
            for (int i = 0; i < count; i++)
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
