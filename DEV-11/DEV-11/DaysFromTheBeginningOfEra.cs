using System;
using System.Web.Services;

namespace DEV_11
{
    [WebService(Description = "Get to know how many days it has been since Christ's birth", Namespace = microsoftNamespace)]
    public class DaysFromTheBeginningOfEra : WebService
    {
        const string microsoftNamespace = "http://microsoft.com/webservices/";

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