using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_ToDoIT.Data
{
    public class PersonSequencer
    {
        //static field
        private static int personId;

        //static methods
        //increases the value of personId by one. called when creating a new object. automatically assigns a new ID
        public static int nextPersonId()
        {

            int id = ++personId;

            return id;
        }

        //resets the value of personId to zero
        public static void Reset()
        {
            personId = 0;
        }
    }
}
