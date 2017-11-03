using CharacterCreator.CharacterRaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.PartyCreation
{
    class Party<T> : IEnumerable<T> where T :Race
    {

        private T[] partyArray;
        private int capacity;
        private int count;

        public Party(T input)
        {

            if(typeof(Sentient).IsAssignableFrom(input.GetType()))
            {
                capacity = ((input as Human).Charisma % 5) + 3;
                partyArray = new T[capacity];
                
            }
            else
            {
                capacity = 1;
                partyArray = new T[1];
            }
        }
        public void Hire(T input)
        {
            partyArray = new T[1];
        }

        public void Fire(int Id)
        {
            if(Id != 0 && Id >= capacity)
            {
                partyArray[Id] = null;
                if(Id+1 != capacity)
                {

                    for (int i =partyArray.ToList().IndexOf(null); i<capacity;i++)
                    {

                    }
                }

            }


        }

        public IEnumerator<T> GetEnumerator()
        {
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
