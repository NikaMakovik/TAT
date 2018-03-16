using System;
using System.Text;
using NUnit.Framework;

namespace DEV_3.Tests
{
    [TestFicture]
    public class NumberConverterTest
    {
        [TestCase(1000, 16, "3E8")]
        [TestCase(8, 2, "1000")]
        [TestCase(5, 17, "5")]
        [TestCase(Int32.MaxValue, 20, "1DB1F927")]
        [TestCase(0, 16, "0")]
        [Test]
        public void ConvertToNewNumeralSystem_Value_ExpectCorrectConvert(int accepted, int exception, string result)
        {
            NumberConverter numberConverter = new NumberConverter(accepted, exception);
            StringBuilder actual = numberConverter.ConvertToNewNumeralSystem();
            Assert.AreEqual(result, actual);
        }

        [TestCase(-1, 15)]
        [TestCase(1, 21)]
        [TestCase(1, 1)]
        [Test]
        public void ConvertToNewNumeralSystem_NotValidNumbers_ExpectExceptions(int acceptedNumber, int ecceptedFoundetion)
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
