using CharacterCreator.CharacterRaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.PartCreation
{
    public class Party<T> : IEnumerable<T> where T :Race
    {

        private T[] partyArray;
        public Party(T input)
        {
if (typeof(Sentient).IsAssignableFrom(input.GetType()))
            {
                partyArray =  new T[(input as Human).Charisma];
            }
else
            {
                partyArray = new T[1];
            }

//public void Hire(T input)
//        {
//           if (count < capacity)
//            {
//                partyArray[count++] = input;
//            }
//        }
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
