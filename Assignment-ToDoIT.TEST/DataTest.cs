using System;
using Xunit;
using Assignment_ToDoIT.Data;
using Assignment_ToDoIT.Model;

namespace Assignment_ToDoIT.TEST
{
    public class DataTest
    {
        /* TEMPLATE
        [Fact]
        public void Test()
        {
            // Arrange


            // Act


            // Assert

        }
        */

        [Fact]
        public void PersonSequencerTest()
        {
            // Arrange
            int expected = 1;
            int expected2 = 2;


            // Act
            //tests nextPersonId method
            PersonSequencer.Reset();
            int actual = PersonSequencer.nextPersonId();
            int actual2 = PersonSequencer.nextPersonId();


            // Assert
            // Asserts nextPersonId
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);


        }

        [Fact]
        public void TodoSequencerTest()
        {
            // Arrange
            int expected = 1;
            int expected2 = 2;

            // Act
            TodoSequencer.Reset();
            int actual = TodoSequencer.NextTaskId();
            int actual2 = TodoSequencer.NextTaskId();

            // Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);

        }

        [Fact]
        public void TodoResetTest()
        {
            // Arrange
            int expected = 1;
            TodoSequencer.NextTaskId();
            int num = TodoSequencer.NextTaskId();
            TodoSequencer.Reset();


            //tests reset Method
            int actual = TodoSequencer.NextTaskId();

            // Assert
            // Asserts reset
            Assert.Equal(expected, actual);
            Assert.True(num >= 2);

        }

        [Fact]
        public void PersonResetTest()
        {
            // Arrange
            int expected = 1;
            PersonSequencer.nextPersonId();
            int num = PersonSequencer.nextPersonId();


            //tests reset Method
            PersonSequencer.Reset();
            int actual = PersonSequencer.nextPersonId();

            // Assert
            Assert.Equal(expected, actual);
            Assert.True(num >= 2);//Assert control number

        }

        [Fact]
        public void PeopleSizeTest()
        {
            // Arrange
            PersonSequencer.Reset();
            int expected = 2;
            People people = new People();
            people.NewPerson("Lars", "Lilja");
            people.NewPerson("Jens", "Vik");

            // Act
            int actual = people.Size();


            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TodoSizeTest()
        {
            // Arrange
            TodoSequencer.Reset();
            TodoItems todo = new TodoItems();
            int expected = 2;
            todo.NewTodoItem("Do this");
            todo.NewTodoItem("Do that");

            // Act
            int actual = todo.Size();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PeopleFindAllTest()
        {
            // Arrange
            PersonSequencer.Reset();
            People people = new People();
            people.NewPerson("Lars", "Lilja");
            people.NewPerson("Jens", "Vik");

            // Act
            Person[] actual = people.FindAll();

            // Assert
            Assert.True(actual.Length == 2);
        }

        [Fact]
        public void TodoFindAllTest()
        {
            // Arrange
            TodoSequencer.Reset();
            TodoItems todo = new TodoItems();
            todo.NewTodoItem("Do this");
            todo.NewTodoItem("Do that");

            // Act
            Todo[] actual = todo.FindAllTodo();

            // Assert
            Assert.True(actual.Length == 2);
        }

        [Fact]
        public void PeopleFindbyIdTest()
        {
            // Arrange
            int personId = 1;
            int personId2 = 2;
            int personId3 = 3;

            People people = new People();
            PersonSequencer.Reset();

            people.NewPerson("Lasse", "Nääf");
            people.NewPerson("Nils", "Korv");

            // Act
            Person actual = people.FindById(personId);
            Person actual2 = people.FindById(personId2);
            Person actual3 = people.FindById(personId3);

            // Assert

            //person1
            Assert.Contains("Lasse", actual.PersonInformation());
            Assert.Contains("Nääf", actual.PersonInformation());
            Assert.Contains(personId.ToString(), actual.PersonInformation());
            
            //person2
            Assert.Contains("Nils", actual2.PersonInformation());
            Assert.Contains("Korv", actual2.PersonInformation());
            Assert.Contains(personId2.ToString(), actual2.PersonInformation());

            Assert.True(actual3 == null);
        }

        [Fact]
        public void TodoFindByIdTest()
        {
            // Arrange
            int todoId = 1;
            int todoId2 = 2;
            int todoId3 = 3;
            
            TodoItems todo = new TodoItems();
            TodoSequencer.Reset();

            todo.NewTodoItem("Do this");
            todo.NewTodoItem("Do that");


            // Act
            Todo actual = todo.FindByIdTodo(todoId);
            Todo actual2 = todo.FindByIdTodo(todoId2);
            Todo actual3 = todo.FindByIdTodo(todoId3);

            // Assert
            Assert.Contains("Do this", actual.ToDoInformation());
            Assert.Contains("Do that", actual2.ToDoInformation());

            Assert.True(actual3 == null);

        }

        [Fact]
        public void NewPersonTest()
        {
            // Arrange
            People people = new People();
            string firstName = "lasse";
            string lastName = "björk";
            int expectedId = 1;
            PersonSequencer.Reset();

            // Act

            Person result = people.NewPerson(firstName, lastName);

            // Assert
            Assert.NotNull(result);
            Assert.Contains(firstName, result.PersonInformation());
            Assert.Contains(lastName, result.PersonInformation());
            Assert.Contains(expectedId.ToString(), result.PersonInformation());
        }

        [Fact]
        public void NewTodoItemTest()
        {
            // Arrange
            TodoItems todo = new TodoItems();
            string description = "Do this";
            int expectedId = 1;
            TodoSequencer.Reset();

            // Act
            Todo result = todo.NewTodoItem(description);

            // Assert
            Assert.NotNull(result);
            Assert.Contains(description, result.ToDoInformation());
            Assert.Contains(expectedId.ToString(), result.ToDoInformation());
        }

        [Fact]
        public void PeopleClearTest()
        {
            // Arrange
            int expected = 0;
            People people = new People();
            PersonSequencer.Reset();
            people.NewPerson("Lasse", "Nääf");
            people.NewPerson("Nils", "Korv");

            // Act
            people.Clear();
            int actual = people.Size();

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void TodoClearTest()
        {
            // Arrange
            int expected = 0;
            TodoItems todo = new TodoItems();
            TodoSequencer.Reset();
            todo.NewTodoItem("Do this");
            todo.NewTodoItem("Do that");

            // Act
            todo.ClearTodo();
            int actual = todo.Size();

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}
