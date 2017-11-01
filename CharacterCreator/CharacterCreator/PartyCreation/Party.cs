using CharacterCreator.CharacterRaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.PartyCreation
{
    // implement interface 
    public class Party<T> : IEnumerable<T> where T :Race //when T inherit from Race 
    {
        private T[] partyArray;
        private int capacity;
        private int count;

        public int Capacity {
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

        public Party(T input) //we cant give array a size
            {
                if(typeof(Sentient).IsAssignableFrom(input.GetType())) //replace input to that variable
                {
                     capacity = ((input as Sentient).Charisma % 5) + 3;
                     partyArray = new T[capacity]; //fill how many array to put in
                //Console.WriteLine(("Step" as Human).ToString());
                }
            else
            {
                capacity = 1;
               
                partyArray = new T[1];

            }
            partyArray[0] = input; // be able to save the size of value, create a person
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
               // partyArray[id] = null;
                if(id+1 != capacity)//if this is not the last slot we have to check
                {
                    //loop throught the space the check 
                    //for (int i = 1; i < partyArray.ToList().IndexOf(null); i++) ;

                    for (int i = partyArray.ToList().IndexOf(null); i< capacity; i++)
                    {
                       
                        if (partyArray[i+1] != null && i+1 == capacity)
                        {
                            partyArray[i] = partyArray[i + 1];
                        }
                        else
                        {
                            partyArray[i] = null; 
                        }
                    }
                    count--;
                }

               
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
