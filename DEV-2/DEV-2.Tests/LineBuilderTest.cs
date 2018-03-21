using System;
using Xunit;

namespace DEV_2.Tests
{
    public class LineBuilderTest
    {
        [Theory]
        [InlineData("")]
        public void BuildNewLineFromOddIndeciesOfOld_NullString_ExpectException(string actual)
        {
            LineBuilder lineBuilder = new LineBuilder();
            Assert.Throws<ArgumentException>
                (() => lineBuilder.BuildNewLineFromOddIndeciesOfOld(actual));
        }

        [Theory]
        [InlineData("121212", "111")]
        [InlineData("21212", "222")]
        public void BuildNewLineFromOddIndeciesOfOld_String_CorrectResult(string actual, string expected)
        {
            LineBuilder lineBuilder = new LineBuilder();
            Assert.Equal(expected, lineBuilder.BuildNewLineFromOddIndeciesOfOld(actual));
        }
    }
}
