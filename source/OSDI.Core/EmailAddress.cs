namespace OSDI
{
    using System;

    /// <summary>
    /// An OSDI email address.
    /// </summary>
    public sealed class EmailAddress
    {
        public EmailAddress(string address, EmailAddressType emailAddressType)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException("Invalid address.", "address");
            }

            this.Address = address;
            this.EmailAddressType = emailAddressType;
        }

        /// <summary>
        /// Gets the email address.
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// Gets the type of the email.
        /// </summary>
        public EmailAddressType EmailAddressType { get; private set; }

        public override bool Equals(object obj)
        {
            var other = obj as EmailAddress;

            if (other == null)
            {
                return false;
            }

            if (string.Equals(this.Address, other.Address))
            {
                if (this.EmailAddressType == null && other.EmailAddressType == null)
                {
                    return true;
                }

                return object.Equals(this.EmailAddressType, other.EmailAddressType);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Address.GetHashCode() ^ (this.EmailAddressType != null ? this.EmailAddressType.GetHashCode() : 0);
        }
    }
}