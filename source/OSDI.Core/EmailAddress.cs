namespace OSDI
{
    using System;

    /// <summary>
    /// An OSDI email address.
    /// </summary>
    public sealed class EmailAddress
    {
        public EmailAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException("Invalid address.", "address");
            }

            this.Address = address;
        }

        /// <summary>
        /// Gets the email address.
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// Gets or sets the type of the email.
        /// </summary>
        public EmailAddressType EmailAddressType { get; set; }
    }
}