namespace OSDI
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Represents a phone number.
    /// </summary>
    public sealed class PhoneNumber
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber"/> class.
        /// </summary>
        /// <param name="number">
        /// The number of the new phone number. It must contain only digits.
        /// </param>
        public PhoneNumber(string number)
        {
            if (string.IsNullOrWhiteSpace(number) || Regex.IsMatch(number, @"[^\d]"))
            {
                throw new ArgumentException("Invalid phone number. Number must contain only digits.", "number");
            }

            this.Number = number;
        }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating if the phone number is on the US FCC Do Not Call Registry. 
        /// </summary>
        public bool? DoNotCall { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Gets the number.
        /// </summary>
        public string Number { get; private set; }

        /// <summary>
        /// Gets or sets the operator.
        /// </summary>
        /// <example>"Verizon", "Sprint", "etc"</example>
        public string Operator { get; set; }

        /// <summary>
        /// Gets or sets the phone type.
        /// </summary>
        public PhoneNumberType NumberType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is the primary phone number.
        /// </summary>
        public bool Primary { get; set; }

        /// <summary>
        /// Gets or sets a value indicating if the phone number can accept SMS text messages.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sms", Justification = "Sms is correct")]
        public bool? SmsCapable { get; set; }
    }
}