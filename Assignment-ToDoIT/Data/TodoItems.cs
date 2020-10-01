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

        public void ClearTodo()
        {
            Array.Resize(ref todoArray, 0);
        }
    }
}
