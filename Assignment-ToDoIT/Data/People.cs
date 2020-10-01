using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assignment_ToDoIT.Model;

namespace Assignment_ToDoIT.Data
{
    public class People
    {
        Person[] peopleArray = new Person[0];

        public int Size()
        {

            int size = peopleArray.Length;

            return size;
        }

        public Person[] FindAll()
        {
            return peopleArray;
        }

        public Person FindById(int personId)
        {

            for (int i = 0; i < peopleArray.Length; i++)
            {
                if (peopleArray[i].PersonId == personId)
                {
                    return peopleArray[i];
                }

            }
            return null;
        }

        public Person NewPerson(string firstName, string lastName)
        {
            Person newPerson = new Person(PersonSequencer.nextPersonId(), firstName, lastName);

            Array.Resize(ref peopleArray, peopleArray.Length + 1);

            peopleArray[peopleArray.Length - 1] = newPerson;

            return newPerson;
        }

        public void Clear()
        {
            Array.Resize(ref peopleArray, 0);
            
        }


    }
}
