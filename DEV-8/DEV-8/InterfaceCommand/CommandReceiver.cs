using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_8
{
    /// <summary>
    /// Contains methods for commands.
    /// </summary>
    public class CommandReceiver
    {
        CommandInvoker commandInvoker = new CommandInvoker();
        List<Person> list = new List<Person>();
        public event EventHandler<SameLastNamesHappenedEventArgs> SameLastNamesHappened;

        public CommandReceiver()
        {
            list = ListOfPersonas.GetListOfPersonas().GetPersonas();
        }
        public CommandReceiver(List<Person> list)
        {
            this.list = list;
        }

        /// <summary>
        /// Invokes event SameLastNamesHappened.
        /// </summary>
        /// <param name="eventArgs">Event arguments.</param>
        public virtual void OnSameLastNamesHappened(SameLastNamesHappenedEventArgs eventArgs)
        {
            SameLastNamesHappened?.Invoke(this, eventArgs);
        }

        /// <summary>
        /// Represents user menu.
        /// </summary>
        public void UserMenu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Use 'add' to add new person");
                Console.WriteLine("Use 'info' to get info");
                Console.WriteLine("Use 'exit' to exit");

                string key = Console.ReadLine();
                switch (key)
                {
                    case "add":
                        commandInvoker.SetCommand(new AddPersonCommand());
                        break;
                    case "info":
                        commandInvoker.SetCommand(new OutputInfoCommand());
                        break;
                    case "exit":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("We don't know this command. Please try again.");
                        commandInvoker.SetCommand(new UserMenuCommand());
                        break;
                }
                commandInvoker.Run();
            }
        }
        /// <summary>
        /// Adds a person to list.
        /// </summary>
        public void AddPerson()
        {
            Person newPerson = new Person();

            Console.WriteLine("Please input first name");
            newPerson.FirstName = Console.ReadLine();
            Console.WriteLine("Please input second name");
            newPerson.LastName = Console.ReadLine();
            Console.WriteLine("Please input sex (m/f)");
            newPerson.Sex = Console.ReadLine();
            Console.WriteLine("Please input age");
            Int32.TryParse(Console.ReadLine(), out int age);
            newPerson.Age = age;


            bool key = false;
            foreach (Person p in list)
            {
                if (p.LastName == newPerson.LastName)
                {
                    key = true;
                }
            }
            if (key)
            {
                SameLastNamesHappenedEventArgs args = new SameLastNamesHappenedEventArgs();
                args.LastName = newPerson.LastName;
                OnSameLastNamesHappened(args);
            }

            list.Add(newPerson);
            Console.WriteLine("Successfully added.");
        }
        /// <summary>
        /// Outputs all information.
        /// </summary>
        public void OutputInfo()
        {
            commandInvoker.SetCommand(new AverageAgeCommand());
            commandInvoker.SetCommand(new OldestPersonCommand());
            commandInvoker.SetCommand(new MostPopularFemaleNameCommand());
            commandInvoker.Run();
        }
        /// <summary>
        /// Finds and outputs an average age.
        /// </summary>
        public float AverageAge()
        {
            float summaryAge = 0;
            int counter = 0;

            foreach (Person person in list)
            {
                summaryAge += person.Age;
                counter++;
            }
            float averageAge = summaryAge / counter;
            return averageAge;
        }
        /// <summary>
        /// Finsd and outputs an oldest person.
        /// </summary>
        public Person OldestPerson()
        {
            var oldestPerson = list.OrderByDescending(person => person.Age).First();
            return oldestPerson;
        }
        /// <summary>
        /// Find and outputs the most popular female name.
        /// </summary>
        public string MostPopularFemaleName()
        {
            List<string> femaleNames = new List<string>();
            
            foreach (Person person in list)
            {
                if (person.Sex == "f")
                {
                    femaleNames.Add(person.FirstName);
                }
            }
            if (femaleNames.Count == 0)
            {
                string exception = "No females in list.";
                return exception;
            }
            else
            {
                var mostPopularName = femaleNames.GroupBy(name => name).OrderBy(name => name.Count()).First();
                return mostPopularName.Key;
            }
        }
    }
}
