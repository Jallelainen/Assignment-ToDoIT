using System;
using Xunit;
using Assignment_ToDoIT.Model;
using Assignment_ToDoIT.Data;

namespace Assignment_ToDoIT.TEST
{

    public class ModelTest
    {
        /* TEMPLATE
        [Fact]
        public void Test1()
        {
            // Arrange


            // Act


            // Assert

        }
        */
        
        [Fact]
        public void PersonTest()
        {
            // Arrange
            string firstName = "Test";
            string lastName = "Testsson";

            // Act
            Person result = new Person(firstName, lastName);

            // Assert
            Assert.NotNull(result);
            Assert.Contains(firstName, result.PersonInformation());
            Assert.Contains(lastName, result.PersonInformation());
        }

        [Fact]
        public void ToDoTest()
        {
            // Arrange
            int toDoId = 1;
            string description = "This is a description.";

            // Act
            Todo result = new Todo(toDoId, description);

            // Assert
            Assert.NotNull(result);
            Assert.Contains(toDoId.ToString(), result.ToDoInformation());
            Assert.Contains(description, result.ToDoInformation());
        }

    }
}
