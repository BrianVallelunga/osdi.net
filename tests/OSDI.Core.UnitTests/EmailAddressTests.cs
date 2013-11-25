namespace OSDI.Core.UnitTests
{
    using System;

    using Xunit;

    public class EmailAddressTests
    {
        [Fact]
        public void Equals_SameAddressAndNullTypes_AreEqual()
        {
            var emailAddress1 = new EmailAddress("test@opensupporter.org", null);
            var emailAddress2 = new EmailAddress("test@opensupporter.org", null);

            Assert.Equal(emailAddress1, emailAddress2);
        }

        [Fact]
        public void Equals_SameAddressAndSameTypes_AreEqual()
        {
            var emailAddress1 = new EmailAddress("test@opensupporter.org", EmailAddressType.Personal);
            var emailAddress2 = new EmailAddress("test@opensupporter.org", EmailAddressType.Personal);

            Assert.Equal(emailAddress1, emailAddress2);
        }

        [Fact]
        public void Equals_SameAddressAndDifferentTypes_AreNotEqual()
        {
            var emailAddress1 = new EmailAddress("test@opensupporter.org", EmailAddressType.Personal);
            var emailAddress2 = new EmailAddress("test@opensupporter.org", EmailAddressType.Work);

            Assert.NotEqual(emailAddress1, emailAddress2);
        }

        [Fact]
        public void Equals_SameAddressAndOneNullType_AreNotEqual()
        {
            var emailAddress1 = new EmailAddress("test@opensupporter.org", null);
            var emailAddress2 = new EmailAddress("test@opensupporter.org", EmailAddressType.Work);

            Assert.NotEqual(emailAddress1, emailAddress2);
        }

        [Fact]
        public void Equals_DifferentAddressesAndNullTypes_AreNotEqual()
        {
            var emailAddress1 = new EmailAddress("test1@opensupporter.org", null);
            var emailAddress2 = new EmailAddress("test2@opensupporter.org", null);

            Assert.NotEqual(emailAddress1, emailAddress2);
        }
    }
}