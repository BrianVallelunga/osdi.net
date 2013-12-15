namespace OSDI
{
    using System;

    /// <summary>
    /// An OSDI email address.
    /// </summary>
    public sealed class EmailAddress
    {
        public EmailAddress(string address, EmailAddressType addressType, bool primary = false)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException("Invalid address.", "address");
            }

            this.Address = address;
            this.AddressType = addressType;
            this.Primary = primary;
        }

        /// <summary>
        /// Gets the email address.
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// Gets the type of the email address.
        /// </summary>
        public EmailAddressType AddressType { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating if this is the primary email address.
        /// </summary>
        public bool Primary { get; private set; }

        public override bool Equals(object obj)
        {
            var other = obj as EmailAddress;

            if (other == null)
            {
                return false;
            }

            if (string.Equals(this.Address, other.Address))
            {
                if (this.AddressType == null && other.AddressType == null)
                {
                    return true;
                }

                return object.Equals(this.AddressType, other.AddressType);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Address.GetHashCode() ^ (this.AddressType != null ? this.AddressType.GetHashCode() : 0);
        }
    }
}