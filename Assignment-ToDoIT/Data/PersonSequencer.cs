using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_ToDoIT.Data
{
    public class PersonSequencer
    {
        private static int personId;

        public static int nextPersonId(int id)
        {
            id = ++personId;

            return id;
        }

        public static int reset(int id)
        {
            id = personId = 0;

            return id;
        }
    }
}
