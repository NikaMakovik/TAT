using Xunit;
using System.Collections.Generic;

namespace DEV_8.Tests
{
    public class CommandReceiverTest
    {
        static List<Person> list = new List<Person>()
        {
            new Person()
            {
                FirstName = "thor",
                LastName = "odinson",
                Sex = "m",
                Age = 10
            },
            new Person()
            {
                FirstName = "loki",
                LastName = "lafeyson",
                Sex = "m",
                Age = 9
            },
            new Person()
            {
                FirstName = "sif",
                LastName = "lady",
                Sex = "f",
                Age = 8
            }
        };

        [Theory]
        [InlineData(9)]
        public void AverageAgeTest_GivenPerson_CorrectResult(float expected)
        {
            CommandReceiver receiver = new CommandReceiver(list);
            Assert.Equal(expected, receiver.AverageAge());
        }

        [Theory]
        [InlineData("thor", "odinson", "m", 10)]
        public void OldestPersonTest_GivenPerson_CorrectResult(string firstName, string secondName, string sex, int age)
        {
            Person expectedPerson = new Person
            {
                FirstName = firstName,
                LastName = secondName,
                Sex = sex,
                Age = age
            };
            CommandReceiver receiver = new CommandReceiver(list);
            Assert.Equal(expectedPerson, receiver.OldestPerson());
        }

        [Theory]
        [InlineData("sif")]
        public void MostPopularFemaleNameTest_GivenPerson_CorrectResult(string expected)
        {
            CommandReceiver receiver = new CommandReceiver(list);
            Assert.Equal(expected, receiver.MostPopularFemaleName());
        }
    }
}
