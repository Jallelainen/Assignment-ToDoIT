using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_ToDoIT.Data
{
    public class TodoSequencer
    {
        private static int taskId;

        public static int nextTaskId(int id)
        {
            id = ++taskId;

            return id;
        }

        public static int reset(int id)
        {
            id = taskId = 0;

            return id;
        }
    }
}
