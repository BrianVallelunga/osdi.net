namespace OSDI
{
    using System.Collections.Generic;

    /// <summary>
    /// The address status.
    /// </summary>
    public enum PostalAddressStatus
    {
        /// <summary>
        /// The potential.
        /// </summary>
        Potential,

        /// <summary>
        /// The verified.
        /// </summary>
        Verified,

        /// <summary>
        /// The bad.
        /// </summary>
        Bad
    }

    /// <summary>
    /// The address type.
    /// </summary>
    public enum PostalAddressType
    {
        /// <summary>
        /// A home address.
        /// </summary>
        Home,

        /// <summary>
        /// A mailing address.
        /// </summary>
        Mailing,

        /// <summary>
        /// A work address.
        /// </summary>
        Work
    }

    /// <summary>
    /// An OSDI postal address.
    /// </summary>
    public sealed class PostalAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostalAddress"/> class.
        /// </summary>
        public PostalAddress()
        {
            this.AddressLines = new List<string>();
        }

        /// <summary>
        /// Gets the address lines.
        /// </summary>
        public ICollection<string> AddressLines { get; private set; }

        /// <summary>
        /// Gets or sets the address status.
        /// </summary>
        public PostalAddressStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        public string Locality { get; set; }

        /// <summary>
        /// Gets or sets the geocoded location of the address.
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether primary.
        /// </summary>
        public bool Primary { get; set; }

        /// <summary>
        /// Gets or sets the region or state.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the address type.
        /// </summary>
        public PostalAddressType? PostalAddressType { get; set; }
    }
}