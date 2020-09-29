using System;
using Xunit;
using Assignment_ToDoIT.Model;

namespace Assignment_ToDoIT.TEST
{

    public class PersonTest
    {
        // TEMPLATE
        [Fact]
        public void Test1()
        {
            // Arrange


            // Act


            // Assert

        }

        
        [Fact]
        public void NameConstructorTest()
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
    }
}
