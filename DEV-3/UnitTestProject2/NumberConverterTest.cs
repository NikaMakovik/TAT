using System;
using System.Text;
using NUnit.Framework;

namespace DEV_3.Tests
{
    [TestFicture]
    public class NumberConverterTest
    {
        [TestCase(255, 16, "FF")]
        [TestCase(10, 2, "1010")]
        [TestCase(20, 20, "10")]
        [TestCase(Int32.MaxValue, 20, "1DB1F927")]
        [TestCase(0, 10, "0")]
        [Test]
        public void ConvertToNewNumeralSystem_(int accepted, int exception, string result)
        {
            NumberConverter numberConverter = new NumberConverter(accepted, exception);
            StringBuilder actual = numberConverter.ConvertToNewNumeralSystem();
            Assert.AreEqual(result, actual);
        }

        [TestCase(-1, 15)]
        [TestCase(1, 21)]
        [TestCase(1, 1)]
        [Test]
        public void CreatingRepresentationOfNumberInNewSystemTest_ArgumentOutOfRangeException(int acceptedNumber, int ecceptedFoundetion)
        {
            NumberConverter numberConverter = new NumberConverter(acceptedNumber, ecceptedFoundetion);
            Assert.Throws<Exception>
             (
                () => numberConverter.ConvertToNewNumeralSystem()
             );
        }

        private class TestFictureAttribute : Attribute
        {
        }
    }
}
