using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumber.Tests
{
    using Core;
    using FluentAssertions;

    [TestClass]
    public class RomanNumerTests
    {
        private readonly RomanNumber romanNumber;

        public RomanNumerTests()
        {
            this.romanNumber = new RomanNumber();
        }

        [TestMethod]
        public void Given1_WhenNumberToRoman_ThenIReturn()
        {
            var result = this.romanNumber.NumberToRoman(1);

            result.Should().Be("I");
        }

        [TestMethod]
        public void Given3_WhenNumberToRoman_ThenIIIReturn()
        {
            var result = this.romanNumber.NumberToRoman(3);

            result.Should().Be("III");
        }

        [TestMethod]
        public void Given5_WhenNumberToRoman_ThenVReturn()
        {
            var result = this.romanNumber.NumberToRoman(5);

            result.Should().Be("V");
        }

        [TestMethod]
        public void Given10_WhenNumberToRoman_ThenXReturn()
        {
            var result = this.romanNumber.NumberToRoman(10);

            result.Should().Be("X");
        }
    }
}
