using System.Collections.Generic;

namespace DEV_8
{
    /// <summary>
    /// Class-container to keep list of personas. Singleton pattern used.
    /// </summary>
    public class ListOfPersonas
    {
        private static ListOfPersonas listOfPersonas;
        private List<Person> personas = new List<Person>();
        private ListOfPersonas() { }

        /// <summary>
        /// Creates new class or returns already existed.
        /// </summary>
        /// <returns>Already existed class.</returns>
        public static ListOfPersonas GetListOfPersonas()
        {
            if (listOfPersonas == null)
            {
                listOfPersonas = new ListOfPersonas();
            }
            return listOfPersonas;
        }

        /// <summary>
        /// Returns list of personas.
        /// </summary>
        /// <returns>List of personas.</returns>
        public List<Person> GetPersonas()
        {
            return personas;
        }        
    }
}
