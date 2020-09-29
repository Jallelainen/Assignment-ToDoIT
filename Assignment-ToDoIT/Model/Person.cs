using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_ToDoIT.Model
{
    public class Person
    {
        //Fields
        private readonly int personId = 0;
        string firstName;
        string lastName;

        //Constructor
        public Person ( string personFirstName, string personLastName)
        {
            ++personId;

            firstName = personFirstName;
            lastName = personLastName;
        }

        public string PersonInformation()
        {
            return $"Identification: {personId} \nFirst Name: {firstName} \nLast Name: {lastName}";
        }
    }
}
