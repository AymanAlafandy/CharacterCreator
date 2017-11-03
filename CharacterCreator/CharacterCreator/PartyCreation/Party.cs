using CharacterCreator.CharacterRaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.PartyCreation
{
    /*
     * We implement the IEnumerable<T> in order to be able to use, amoung otherthings,
     * the foreach-loop with instaces of the Party
     */
    public class Party<T> : IEnumerable<T> where T : Race
    {
        private T[] partyArray;
        private int capacity;
        private int count;

        /*
         * Both the Capacity and Count properties are made in such a way that the only
         * thing other classes can do with them is to read the value that their linked feild
         * contains
         */
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
            /*
             * We make sure that the type of the inparam "input" is of the type Sentient
             * or a child of it
             */
            if (typeof(Sentient).IsAssignableFrom(input.GetType()))
            {
                capacity = ((input as Sentient).Charisma % 3) + 7;
                partyArray = new T[capacity];
            }
            /*
             * otherwise we ensure that the party will only be the founding person
             */
            else
            {
                capacity = 1;
                partyArray = new T[1];
            }
            partyArray[0] = input;
            Count = 1;
        }

        /*
         * Since count will always be one highter than the index of the last added
         * party member, we can use count to add new members to the end of the roster
         */
        public void Hire(T input)
        {
            if (count < capacity)
            {
                partyArray[count++] = input;
            }
        }
        /*
         * The Fire method ensures that the array is kept orderd with all the nulls
         * at the bottom, it does this by constantly moving all members after the one
         * being removed up one step and the finaly setting the last doublett to null.
         */
        public void Fire(int id)
        {
            if (id != 0 && id <= capacity && partyArray[id] != null)
            {
                //partyArray[id] = null;
                if (id + 1 != capacity)
                {
                    /*
                     * mistake and overly convoluted
                     */
                    //for(int i = 1; i <partyArray.ToList().IndexOf(null);i++)
                    //{

                    //}
                    for (int i = id; i < capacity; i++)
                    {
                        if (partyArray[i + 1] != null && i + 1 != capacity)
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
        /*
         * These functions are what lets us implement the IEnumerable interface
         * The yield return lets the function return multiple times without having to call 
         * the function again and again.
         */
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
