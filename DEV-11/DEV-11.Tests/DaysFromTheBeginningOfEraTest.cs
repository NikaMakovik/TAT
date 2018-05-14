using System;
using Xunit;

namespace DEV_11
{
    public class DaysFromTheBeginningOfEraTest
    {
        DaysFromTheBeginningOfEra daysCount = new DaysFromTheBeginningOfEra();

        [Theory]
        [InlineData(0001, 1, 1, 1)]
        [InlineData(9999, 12, 31, 3652058)]
        public void HowManyDaysTest_ValidDate_Result(int year, int month, int day, int expected)
        {
            DateTime date = new DateTime(year, month, day);
            int actual = daysCount.HowManyDays(date);
            Assert.Equal(expected, actual);
        }
    }
}
