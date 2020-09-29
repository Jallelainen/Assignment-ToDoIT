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
        //increases the value of personId by one
        public static int nextPersonId(int id)
        {
            id = ++personId;

            return id;
        }

        //resets the value of personId to zero
        public static int reset(int id)
        {
            id = personId = 0;

            return id;
        }
    }
}
