namespace OSDI
{
    using System;

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = "It is meant to emulate an enum.")]
    public abstract class FlexEnum
    {
        protected FlexEnum(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("FlexEnumeration value is not valid");
            }

            this.Value = value;
        }

        public string Value { get; private set; }

        public static implicit operator string(FlexEnum flexEnum)
        {
            if (flexEnum != null)
            {
                return flexEnum.Value;
            }

            return null;
        }

        public override int GetHashCode()
        {
            return this.Value != null ? this.Value.GetHashCode() : 0;
        }

        public override bool Equals(object obj)
        {
            var other = obj as FlexEnum;

            if (other == null)
            {
                return false;
            }

            return string.Equals(this.Value, other.Value);
        }

        public bool Equals(FlexEnum other)
        {
            if (other == null)
            {
                return false;
            }

            return string.Equals(this.Value, other.Value);
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}