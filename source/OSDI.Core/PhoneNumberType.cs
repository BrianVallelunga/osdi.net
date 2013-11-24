namespace OSDI
{
    /// <summary>
    /// The type of phone number.
    /// </summary>
    public sealed class PhoneNumberType : FlexEnum
    {
        /// <summary>
        /// An evening phone number.
        /// </summary>
        public static readonly PhoneNumberType Evening = new PhoneNumberType("Evening");

        /// <summary>
        /// A home phone number.
        /// </summary>
        public static readonly PhoneNumberType Home = new PhoneNumberType("Home");

        /// <summary>
        /// A mobile phone number.
        /// </summary>
        public static readonly PhoneNumberType Mobile = new PhoneNumberType("Mobile");

        /// <summary>
        /// A work phone number.
        /// </summary>
        public static readonly PhoneNumberType Work = new PhoneNumberType("Work");

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberType"/> class.
        /// </summary>
        /// <param name="value">
        /// The new type of phone number.
        /// </param>
        public PhoneNumberType(string value)
            : base(value)
        {
        }
    }
}