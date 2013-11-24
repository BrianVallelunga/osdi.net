namespace OSDI
{
    using System;

    /// <summary>
    /// A birthdate that contains at least one component of year, month, and day.
    /// </summary>
    public sealed class Birthdate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Birthdate"/> class. At least one date component must be specified.
        /// </summary>
        /// <param name="year">
        /// The year of the
        /// </param>
        /// <param name="month">
        /// The month.
        /// </param>
        /// <param name="day">
        /// The day.
        /// </param>
        /// <exception cref="ArgumentException">
        /// ArgumentException if no parameters are passed.
        /// </exception>
        public Birthdate(int? year = null, int? month = null, int? day = null)
        {
            if (year == null && month == null && day == null)
            {
                throw new ArgumentException("At least one birthdate component must be specified");
            }

            this.Year = year;
            this.Month = month;
            this.Day = day;
        }

        /// <summary>
        /// Gets the day.
        /// </summary>
        public int? Day { get; private set; }

        /// <summary>
        /// Gets the month.
        /// </summary>
        public int? Month { get; private set; }

        /// <summary>
        /// Gets the year.
        /// </summary>
        public int? Year { get; private set; }
    }
}