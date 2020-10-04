﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_ToDoIT.Data
{
    public class TodoSequencer
    {
        private static int taskId;

        //called when creating a new object. automatically assigns a new ID
        public static int NextTaskId()
        {
           int newId = ++taskId;

            return newId;
        }

        public static void Reset()
        {
            taskId = 0;

        }
    }
}
