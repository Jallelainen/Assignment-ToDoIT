using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_ToDoIT.Model
{
    public class Todo
    {
        //Fields
        readonly int toDoId;
        string description;
        bool done;
        Person asignee;

        //Constructor
        public Todo (int toDoId, string description)
        {
            this.toDoId = toDoId;
            this.description = description;
        }

        public string ToDoInformation()
        {
            return $"Task Identification: {toDoId} \nDescription: {description}";
        }
    }
}
