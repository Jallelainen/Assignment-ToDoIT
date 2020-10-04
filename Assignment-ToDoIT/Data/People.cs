using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assignment_ToDoIT.Model;

namespace Assignment_ToDoIT.Data
{
    public class People
    {
        //keeps all the person objects in this array
        Person[] peopleArray = new Person[0];


        // returns integer size of person array. 
        public int Size()
        {

            int size = peopleArray.Length;

            return size;
        }

        //returns whole array
        public Person[] FindAll()
        {
            return peopleArray;
        }

        //finds person with specific Id
        public Person FindById(int personId)
        {

            for (int i = 0; i < peopleArray.Length; i++)// for- loop goes trough whole array
            {
                if (peopleArray[i].PersonId == personId)//if-statement compares person in array to person Id. PersonId used to call get method according to encapsulation.
                {
                    return peopleArray[i];
                }

            }
            return null;
        }

        //method that creates a new person object.
        public Person NewPerson(string firstName, string lastName)
        {
            Person newPerson = new Person(PersonSequencer.nextPersonId(), firstName, lastName); // calls constructor. uses personsequencer to give new ID

            Array.Resize(ref peopleArray, peopleArray.Length + 1); // expands Array to fit new person

            peopleArray[peopleArray.Length - 1] = newPerson; // adds new person in array

            return newPerson;
        }

        //clears whole array by setting it to zero.
        public void Clear()
        {
            Array.Resize(ref peopleArray, 0);// removes all elements except zero
            Array.Resize(ref peopleArray, 2);// adds empty element
            peopleArray[0] = peopleArray[1]; // takes the empty element and overwrites last person

            Array.Resize(ref peopleArray, 0);// sets array to zero
        }

        //removes person beased on personId
        public void RemovePerson(int personId)
        {
            for (int find = 0; find < peopleArray.Length; find++) //for loop to find right person
            {
                if (peopleArray[find].PersonId == personId) // if-statement to confirm that it is the right person
                {
                    for (int remove = find; remove < peopleArray.Length - 1; remove++) //for loop to move all persons after the one you want to delete forward.
                    {
                        peopleArray[remove] = peopleArray[remove + 1];
                    }

                    Array.Resize(ref peopleArray, peopleArray.Length - 1); // removes unneccesary spot in array
                }
            }
        }


    }
}
