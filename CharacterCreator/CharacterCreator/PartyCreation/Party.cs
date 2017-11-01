using CharacterCreator.CharacterRaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.PartyCreation
{
    //we can limit what we can do with T

    public class Party<T> : IEnumerable<T> where T:Race //only instance from Race!
    {
        //implementing the interface and creating an array of T as using a list will be redudant
        //private T[] partyArray = new T[0]; we can do it without the constructor because we assign 2 instance for array and consume more memory

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
               
        public int Count{ get
            { 
                return count;
            }
            private set
            { 
                count=value;
            }
        }
        

        public Party(T input)
        {
            // we need thid instance because can use foreach!
            // if (input.GetType().Name=="Human") Human inheritance from Sentient, but still is Human, not Sentient
            if (typeof(Sentient).IsAssignableFrom(input.GetType()))
           
            {
                //partyArray = new T[((input as Sentient).Charisma % 5)+3];
                capacity = ((input as Sentient).Charisma % 5) + 3;
                partyArray = new T[capacity];
                //Console.WriteLine(("step" as Human).ToString());
            }
            else
            {
                capacity = 1;
                partyArray = new T[1];
            }
            //add first person
            partyArray[0] = input; // if we have  MORE CREture we have 3 more place to add into the slot
            Count = 1; //we have one entity in our array
        }
        public void Hire(T input)
        {
            if (count<capacity)
            {
               partyArray[count++] = input;
               // count++ it is up!
            }
            //we want to add this person to the last available slot to the partyArray
            //partyArray
        }
        public void Fire(int id)
        {
            if (id != 0 && id<=capacity && partyArray[id] !=null)
            {
                //partyArray[id] = null;//empty out a slot
                if (id + 1 != capacity) //if id didn't rich the last
                                        //{
                                        //    //a bubble sort-is moving the null down! This is the way a list work!
                                        //    for (int i = 1; i < partyArray.ToList().IndexOf(null); i++) //we don't want to start from 0! IndexOf find the spot whete the curent is
                                        //}
                { //we find null or we are one step from the bottom, we place the null at the bottom!
                    
                    //for (int i = partyArray.ToList().IndexOf(null); i < capacity; i++) //it is easier than for (int i = partyArray.ToList().IndexOf(null); i < capacity; i++)   for (int i = partyArray.ToList().IndexOf(null); i < capacity; i++)
                                                                                       //more easier with this code!
                        for (int i =id; i < capacity; i++)
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
           

        public IEnumerator<T> GetEnumerator() // use the interface check and to return all the information in the list
        {
            // throw new NotImplementedException();
            for (int i = 0; i < count; i++)
            {
                yield return partyArray[i]; //yield continuu to search in the box
            }
            //return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
            //throw new NotImplementedException();
        }
      }

  }   
    
 
