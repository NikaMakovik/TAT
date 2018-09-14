using System;

namespace DEV_8
{
    /// <summary>
    /// Class-container, has person information as fields.
    /// </summary>
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        /// <summary>
        /// Output person information.
        /// </summary>
        public void OutputPerson()
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine(Sex + ", " + Age);
            Console.WriteLine();
        }        
    }
}
