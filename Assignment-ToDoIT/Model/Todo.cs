using Assignment_ToDoIT.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_ToDoIT.Model
{
    public class Todo
    {
        //Fields
        private readonly int toDoId;
        private string description;
        private bool done;
        private Person asignee;

        public int TodoId { get { return toDoId; } }

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
