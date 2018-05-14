using System;
using System.Web.Services;

namespace DEV_11
{
    /// <summary>
    /// Counts days from the beginning of era.
    /// </summary>
    [WebService(Description = "Get to know how many days it has been since Christ's birth", Namespace = microsoftNamespace)]
    public class DaysFromTheBeginningOfEra : WebService
    {
        const string microsoftNamespace = "http://microsoft.com/webservices/";
        /// <summary>
        /// Counts days from incoming date to Christ's birth.
        /// </summary>
        /// <param name="date">Incoming date.</param>
        /// <returns>Total number of days</returns>
        [WebMethod]
        public int HowManyDays(DateTime date)
        {
            DateTime dateOfBeginning = new DateTime(0001, 1, 1);
            Console.WriteLine(dateOfBeginning.ToString("F"));
            int totalDays = (int)(date - dateOfBeginning).TotalDays;
            return totalDays;
        }
    }
}