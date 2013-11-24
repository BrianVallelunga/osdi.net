namespace OSDI.Core.UnitTests
{
    using System;

    using Xunit;

    public class FlexEnumTests
    {
        public class TestEnum : FlexEnum
        {
            public TestEnum(string value)
                : base(value)
            {
            }
        }

        [Fact]
        public void Initialize_EmptyString_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => new TestEnum(string.Empty));
        }

        [Fact]
        public void Initialize_WhitespaceString_ArgumentExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => new TestEnum(" "));
        }

        [Fact]
        public void DistinctReferencesWithSameValue_AreEqual()
        {
            var test1 = new TestEnum("Test");
            var test2 = new TestEnum("Test");

            Assert.Equal(test1, test2);
        }

        [Fact]
        public void DistinctReferencesWithDifferentValues_AreNotEqual()
        {
            var test1 = new TestEnum("Test1");
            var test2 = new TestEnum("Test2");

            Assert.NotEqual(test1, test2);
        }

        [Fact]
        public void ImplicitAssignmentToString_HasSameValue()
        {
            var test = new TestEnum("Test");

            string testValue = test;

            Assert.Equal(test.Value, testValue);
        }

        [Fact]
        public void ToString_ReturnsValue()
        {
            var test = new TestEnum("Test");

            string testValue = test.ToString();

            Assert.Equal(test.Value, testValue);
        }
    }
}