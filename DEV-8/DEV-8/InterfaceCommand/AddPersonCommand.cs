using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace DEV_8
{
    /// <summary>
    /// Does 'add' command.
    /// </summary>
    class AddPersonCommand : ICommand
    {
        CommandReceiver receiver = new CommandReceiver();

        private void Receiver_SameLastNamesHappened(object sender, SameLastNamesHappenedEventArgs eventArgs)
        {
            string sameLastName = eventArgs.LastName;
            Console.WriteLine($"Similar last name '{sameLastName}' has detected. Here's list of namesake:");

            List<Person> newList = new List<Person>();
            foreach (Person p in ListOfPersonas.GetListOfPersonas().GetPersonas())
            {
                if (p.LastName == sameLastName)
                {
                    p.OutputPerson();
                    newList.Add(p);
                }
            }
            string path = @"D:\Workspace\TAT\DEV-8\DEV-8\listOfPersonas.json";
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, newList);
            }
        }
        /// <summary>
        /// Implements Interface member Execute to 'add' command.
        /// </summary>
        public void Execute()
        {
            receiver.SameLastNamesHappened += Receiver_SameLastNamesHappened;
            receiver.AddPerson();
        }
    }
}
