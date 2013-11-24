namespace OSDI
{
    using System;

    /// <summary>
    /// Describes a person's online service profile.
    /// </summary>
    public sealed class Profile
    {
        public Profile(string provider)
        {
            if (string.IsNullOrWhiteSpace(provider))
            {
                throw new ArgumentException("A provider is required.", "provider");
            }

            this.Provider = provider;
        }

        /// <summary>
        /// Gets or sets the handle.
        /// </summary>
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets the provider.
        /// </summary>
        public string Provider { get; private set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public Uri Url { get; set; }
    }
}