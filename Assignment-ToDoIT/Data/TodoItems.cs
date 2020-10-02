using Assignment_ToDoIT.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_ToDoIT.Data
{
    public class TodoItems
    {
        Todo[] todoArray = new Todo[0];
        

        public int Size()
        {
            return  todoArray.Length;
        }

        public Todo[] FindAllTodo()
        {
            return todoArray;
        }

        public Todo FindByIdTodo(int todoId)
        {
            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].TodoId == todoId)
                {
                    return todoArray[i];
                }

            }
            return null;
        }

        public Todo NewTodoItem(string description)
        {
            Todo newTodoItem = new Todo(TodoSequencer.NextTaskId(), description);

            Array.Resize(ref todoArray, todoArray.Length + 1);
            todoArray[todoArray.Length - 1] = newTodoItem;

            return newTodoItem;
        }

        public Todo NewTodoItem(string description, bool done, Person assignee)
        {
            Todo newTodoItem = new Todo(TodoSequencer.NextTaskId(), description, done, assignee);

            Array.Resize(ref todoArray, todoArray.Length + 1);
            todoArray[todoArray.Length - 1] = newTodoItem;

            return newTodoItem;
        }

        public void ClearTodo()
        {
            Array.Resize(ref todoArray, 0);
        }

        public Todo[] FindByDoneStatus()
        {
            bool done = true;
            Todo[] doneArray = new Todo[0];

            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].Done == done)
                {
                    Array.Resize(ref doneArray, doneArray.Length + 1);
                    doneArray[doneArray.Length - 1] = todoArray[i];
                }
            }

            return doneArray;
        }

        public Todo[] FindByAssignee(int personId)
        {
            Todo[] assigneeArray = new Todo[0];

            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].Assignee.PersonId == personId)
                {
                    Array.Resize(ref assigneeArray, assigneeArray.Length + 1);
                    assigneeArray[assigneeArray.Length - 1] = todoArray[i];
                }
            }

            return assigneeArray;
        }

        public Todo[] FindByAssignee(Person assignee)
        {
            if (assignee == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                return FindByAssignee(assignee.PersonId);
            }
        }

        public Todo[] FindUnassignedTodoItems()
        {
            Todo[] unassignedArray = new Todo[0];

            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].Assignee == null)
                {
                    Array.Resize(ref unassignedArray, unassignedArray.Length + 1);
                    unassignedArray[unassignedArray.Length - 1] = todoArray[i];
                }
            }

            return unassignedArray;
        }
    }
}
