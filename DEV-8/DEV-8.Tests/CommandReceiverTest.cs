using Xunit;
using System.Collections.Generic;

namespace DEV_8.Tests
{
    public class CommandReceiverTest
    {
        [Theory]
        [InlineData("jesus", "christ", "m", 33, 33)]
        public void AverageAgeTest_GivenPerson_CorrectResult(string firstName, string secondName, string sex, int age, float expected)
        {
            Person person = new Person
            {
                FirstName = firstName,
                LastName = secondName,
                Sex = sex,
                Age = age
            };
            List<Person> listOfPersonas = new List<Person>();
            listOfPersonas.Add(person);
            CommandReceiver receiver = new CommandReceiver(listOfPersonas);

            Assert.Equal(expected, receiver.AverageAge());
        }
        
        [Theory]
        [InlineData("jesus", "christ", "m", 33)]
        public void OldestPersonTest_GivenPerson_CorrectResult(string firstName, string secondName, string sex, int age)
        {
            Person person = new Person
            {
                FirstName = firstName,
                LastName = secondName,
                Sex = sex,
                Age = age
            };
            Person expectedPerson = new Person();
            expectedPerson = person;
            List<Person> listOfPersonas = new List<Person>();
            listOfPersonas.Add(person);
            CommandReceiver receiver = new CommandReceiver(listOfPersonas);

            Assert.Equal(expectedPerson, receiver.OldestPerson());
        }

        [Theory]
        [InlineData("jesus", "christ", "m", 33, "No females in list.")]
        [InlineData("mary", "blessed", "f", 49, "mary")]
        public void MostPopularFemaleNameTest_GivenPerson_CorrectResult(string firstName, string secondName, string sex, int age, string expected)
        {
            Person person = new Person
            {
                FirstName = firstName,
                LastName = secondName,
                Sex = sex,
                Age = age
            };
            List<Person> listOfPersonas = new List<Person>();
            listOfPersonas.Add(person);
            CommandReceiver receiver = new CommandReceiver(listOfPersonas);

            Assert.Equal(expected, receiver.MostPopularFemaleName());
        }
    }
}
