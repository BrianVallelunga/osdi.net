namespace OSDI
{
    /// <summary>
    /// The location accuracy.
    /// </summary>
    public enum LocationAccuracy
    {
        /// <summary>
        /// An approximate location.
        /// </summary>
        Approximate,

        /// <summary>
        /// A precise location accurate to a street address rooftop.
        /// </summary>
        Rooftop
    }

    /// <summary>
    ///     The address's geocoded location.
    /// </summary>
    public sealed class Location
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        /// <param name="longitude">
        /// The longitude.
        /// </param>
        /// <param name="latitude">
        /// The latitude.
        /// </param>
        public Location(double longitude, double latitude)
        {
            this.Longitude = longitude;
            this.Latitude = latitude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        /// <param name="longitude">
        /// The longitude.
        /// </param>
        /// <param name="latitude">
        /// The latitude.
        /// </param>
        /// <param name="accuracy">
        /// The accuracy.
        /// </param>
        public Location(double longitude, double latitude, LocationAccuracy? accuracy)
        {
            this.Accuracy = accuracy;
            this.Longitude = longitude;
            this.Latitude = latitude;
        }

        /// <summary>
        /// Gets the accuracy of the geocoded coordinates.
        /// </summary>
        public LocationAccuracy? Accuracy { get; private set; }

        /// <summary>
        /// Gets the latitude of the geocoded location.
        /// </summary>
        public double Latitude { get; private set; }

        /// <summary>
        /// Gets the longitude of the geocoded location.
        /// </summary>
        public double Longitude { get; private set; }
    }
}