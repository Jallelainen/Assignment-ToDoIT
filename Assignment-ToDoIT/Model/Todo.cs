using Assignment_ToDoIT.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_ToDoIT.Model
{
    public class Todo
    {
        //Fields
        readonly int toDoId = 0;
        string description;
        bool done;
        Person asignee;

        //Constructor
        public Todo (int toDoId, string description)
        {
            this.toDoId = TodoSequencer.NextTaskId();
            this.description = description;
        }

        public string ToDoInformation()
        {
            return $"Task Identification: {toDoId} \nDescription: {description}";
        }
    }
}
