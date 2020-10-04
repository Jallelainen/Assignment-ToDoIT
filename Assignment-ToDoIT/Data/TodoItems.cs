using Assignment_ToDoIT.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_ToDoIT.Data
{
    public class TodoItems
    {
        Todo[] todoArray = new Todo[0];// todo items in array
        

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

        //extra method to create new todo object with status and asignee. To make it easier to test.
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

        //method to find todo objects with a done status
        public Todo[] FindByDoneStatus()
        {
            bool done = true;
            Todo[] doneArray = new Todo[0];// temporary array to fill with objects that are done

            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].Done == done)// checks if done status is true
                {
                    Array.Resize(ref doneArray, doneArray.Length + 1); // adds a spot in array 
                    doneArray[doneArray.Length - 1] = todoArray[i]; // adds person to new spot
                }
            }

            return doneArray;
        }

        //same as previous method but for assignee using the person Id
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

        //same as previous method but using the person object to find
        public Todo[] FindByAssignee(Person assignee)
        {
            if (assignee == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                return FindByAssignee(assignee.PersonId); // gets person objects ID according to encapsulation and uses previous method to find.
            }
        }

        //Finds todo objects with no assignee
        public Todo[] FindUnassignedTodoItems()
        {
            Todo[] unassignedArray = new Todo[0];

            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].Assignee == null) // checks if assignee property is null
                {
                    Array.Resize(ref unassignedArray, unassignedArray.Length + 1);
                    unassignedArray[unassignedArray.Length - 1] = todoArray[i];
                }
            }

            return unassignedArray;
        }

        //removes specific todo object using its id
        public void RemoveTodoItem(int todoId)
        {
            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].TodoId == todoId) //checks if id matches
                {

                    for (int k = i; k < todoArray.Length - 1; k++) //for loop starts at same place as previous loop stops
                    {
                        todoArray[k] = todoArray[k + 1];// in every iteration of the loop, it takes the object after k and moves it forward
                    }

                    Array.Resize(ref todoArray, todoArray.Length - 1);
                }

            }
        }
    }
}
