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

        // get set functionality for encapsulation of previous fields
        public int TodoId { get { return toDoId; } }
        public bool Done { get { return done; } }
        public Person Assignee { get { return assignee; } }

        //Constructor
        //todo constructor that creates todo-object with only ID and despcription
        public Todo (int toDoId, string description)
        {
            this.toDoId = toDoId;
            this.description = description;
        }

        //Todo constructor chained to the previous one. this one adds functionality to assign a person and a status. Now you can create just ID and description or the whole thing.
        public Todo (int toDoId, string description, bool done, Person assignee) 
            : this(toDoId, description)
        {
            this.done = done;
            this.assignee = assignee;
        }

        // this returns the different parts of the object. Makes it easier to test. 
        public string ToDoInformation()
        {
            return $"Task Identification: {toDoId} \nDescription: {description}\nAsignee: {assignee}\nDone: {done}";
        }
    }
}
