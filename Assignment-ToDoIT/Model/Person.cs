using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_ToDoIT.Model
{
    public class Person
    {
        //Static
        private static int counter = 0;

        //Fields
        private readonly int personId;
        string firstName;
        string lastName;

        //Constructor
        public Person ( string personFirstName, string personLastName)
        {
            personId = ++counter;

            firstName = personFirstName;
            lastName = personLastName;
        }

        public string PersonInformation()
        {
            return $"Identification: {personId} \nFirst Name: {firstName} \nLast Name: {lastName}";
        }
    }
}
