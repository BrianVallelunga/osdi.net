namespace OSDI.Core.UnitTests
{
    using System;

    using Xunit;

    public class PersonTests
    {
        [Fact]
        public void Constructor_InitializesCollections()
        {
            var person = new Person();

            Assert.NotNull(person.EmailAddresses);
            Assert.NotNull(person.LanguagesSpoken);
            Assert.NotNull(person.PhoneNumbers);
            Assert.NotNull(person.PostalAddresses);
            Assert.NotNull(person.Profiles);
        }
    }
}