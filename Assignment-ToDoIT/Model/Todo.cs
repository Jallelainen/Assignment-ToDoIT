using Assignment_ToDoIT.Data;
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
        Person assignee;

        public int TodoId { get { return toDoId; } }
        public bool Done { get { return done; } }
        public Person Assignee { get { return assignee; } }

        //Constructor
        public Todo (int toDoId, string description)
        {
            this.toDoId = toDoId;
            this.description = description;
        }

        public Todo (int toDoId, string description, bool done, Person assignee) 
            : this(toDoId, description)
        {
            this.done = done;
            this.assignee = assignee;
        }

        public string ToDoInformation()
        {
            return $"Task Identification: {toDoId} \nDescription: {description}\nAsignee: {assignee}\nDone: {done}";
        }
    }
}
