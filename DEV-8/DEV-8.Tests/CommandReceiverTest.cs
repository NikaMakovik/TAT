using System;
using Xunit;
using System.Collections.Generic;

namespace DEV_8.Tests
{
    public class CommandReceiverTest
    {

        
        [Theory]
        [InlineData("kira", "kot", "female", 18, 18)]
        public void AverageAgeTest(string firstName, string secondName, string sex, int age, float expected)
        {
            Person person = new Person();
            person.FirstName = firstName;
            person.SecondName = secondName;
            person.Sex = sex;
            person.Age = age;
            List<Person> listOfPersonas = new List<Person>();
            listOfPersonas.Add(person);
            CommandReceiver receiver = new CommandReceiver(listOfPersonas);

            Assert.Equal(expected, receiver.AverageAge());
        }
    }
}
