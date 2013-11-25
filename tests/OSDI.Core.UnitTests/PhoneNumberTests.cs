namespace OSDI.Core.UnitTests
{
    using System;

    using Xunit;

    public class PhoneNumberTests
    {
        [Fact]
        public void Constructor_OnlyDigits_DoesNotThrowException()
        {
            Assert.DoesNotThrow(() => new PhoneNumber("5555555555"));
        }

        [Fact]
        public void Constructor_NonDigits_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new PhoneNumber("555INVALID"));
        }

        [Fact]
        public void Constructor_OnlyDigits_SetsNumber()
        {
            string number = "5555555555";

            var phoneNumber = new PhoneNumber(number);

            Assert.Equal(number, phoneNumber.Number);
        }
    }
}