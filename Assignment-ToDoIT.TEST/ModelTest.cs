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
        
        //tests constructors
        [Fact]
        public void PersonTest()
        {
            // Arrange
            int expectedId = 1;
            string firstName = "Test";
            string lastName = "Testsson";

            // Act
            Person result = new Person(expectedId, firstName, lastName);

            // Assert
            Assert.NotNull(result);
            Assert.Contains(firstName, result.PersonInformation());
            Assert.Contains(lastName, result.PersonInformation());
            Assert.Contains(expectedId.ToString(), result.PersonInformation());
        }

        [Fact]
        public void ToDoTest()
        {
            // Arrange
            int expected = 1;
            string description = "This is a description.";

            // Act
            Todo result = new Todo(expected, description);

            // Assert
            Assert.NotNull(result);
            Assert.Contains(expected.ToString(), result.ToDoInformation());
            Assert.Contains(description, result.ToDoInformation());
        }

    }
}
