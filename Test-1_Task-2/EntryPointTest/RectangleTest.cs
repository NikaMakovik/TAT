using Xunit;

namespace Test_1_Task_2
{
    public class GetSquareTest
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(double.MaxValue, 0, 0)]        
        public void GetSquarePositiveTest(double length, double width, double expected)
        {
            Assert.Equal(expected, new Rectangle(length, width).GetSquare())
        }
    }
}
