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
        public void SizeTest()
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
        public void FindAllTest()
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
        public void FindbyIdTest()
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
        public void ClearTest()
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

    }
}
