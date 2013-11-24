namespace OSDI
{
    public sealed class EmailAddressType : FlexEnum
    {
        /// <summary>
        /// An other type email address.
        /// </summary>
        public static readonly EmailAddressType Other = new EmailAddressType("Other");

        /// <summary>
        /// A personal email address.
        /// </summary>
        public static readonly EmailAddressType Personal = new EmailAddressType("Personal");

        /// <summary>
        /// A work email address.
        /// </summary>
        public static readonly EmailAddressType Work = new EmailAddressType("Work");

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAddressType"/> class.
        /// </summary>
        /// <param name="value">
        /// The value of the email type.
        /// </param>
        public EmailAddressType(string value)
            : base(value)
        {
        }
    }
}