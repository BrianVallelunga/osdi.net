namespace OSDI
{
    /// <summary>
    /// Represents an issuer-specific identity.
    /// </summary>
    public class Identifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Identifier"/> class.
        /// </summary>
        /// <param name="issuer"></param>
        /// <param name="id"></param>
        public Identifier(string issuer, string id)
        {
            this.Issuer = issuer;
            this.Id = id;
        }

        /// <summary>
        /// Gets the issuer.
        /// </summary>
        public string Issuer { get; private set; }

        /// <summary>
        /// Gets the Id.
        /// </summary>
        public string Id { get; private set; }
    }
}