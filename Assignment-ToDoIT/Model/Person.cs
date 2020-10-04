using System;
using System.Collections.Generic;
using System.Text;
using Assignment_ToDoIT.Data;

namespace Assignment_ToDoIT.Model
{
    public class Person
    {

        //Fields
        private readonly int personId;
        private string firstName;
        private string lastName;

        //encapsulation
        public int PersonId { get { return personId; } }

        //Constructor
        //creates a person object
        public Person (int id, string personFirstName, string personLastName)
        {
            personId = id;

            firstName = personFirstName;
            lastName = personLastName;
        }

        //returns parts of object. Helps with testing.
        public string PersonInformation()
        {
            return $"Identification: {personId} \nFirst Name: {firstName} \nLast Name: {lastName}";
        }
    }
}
