using System;
using Xunit;
using Assignment_ToDoIT.Data;

namespace Assignment_ToDoIT.TEST
{
    public class DataTest
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
        public void PersonSequencerTest()
        {
            // Arrange
            int personId = 0;
            int expected = 1;

            // Act
            //tests nextPersonId method
            int actual = PersonSequencer.nextPersonId(personId);
            //tests reset Method
            int actual2 = PersonSequencer.reset(expected);

            // Assert
            // Asserts nextPersonId
            Assert.Equal(expected, actual);
            // Asserts reset
            Assert.Equal(personId, actual2);

        }

    }
}
