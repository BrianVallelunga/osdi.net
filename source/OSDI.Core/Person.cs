namespace OSDI
{
    using System.Collections.Generic;

    /// <summary>
    /// Defined genders.
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// The male gender.
        /// </summary>
        Male, 

        /// <summary>
        /// The female gender.
        /// </summary>
        Female, 

        /// <summary>
        /// A gender other than male or female.
        /// </summary>
        Other
    }

    /// <summary>
    /// Represents an OSDI person.
    /// </summary>
    public sealed class Person : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
            this.EmailAddresses = new HashSet<EmailAddress>();
            this.LanguagesSpoken = new HashSet<string>();
            this.PhoneNumbers = new HashSet<PhoneNumber>();
            this.PostalAddresses = new HashSet<PostalAddress>();
            this.Profiles = new HashSet<Profile>();
        }

        /// <summary>
        /// Gets or sets the additional name of the person; often, a middle name.
        /// </summary>
        public string AdditionalName { get; set; }

        /// <summary>
        /// Gets or sets the birthdate of the person.
        /// </summary>
        public Birthdate Birthdate { get; set; }

        /// <summary>
        /// Gets the email addresses of the person.
        /// </summary>
        public ICollection<EmailAddress> EmailAddresses { get; private set; }

        /// <summary>
        /// Gets or sets the employer of the person.
        /// </summary>
        public string Employer { get; set; }

        /// <summary>
        /// Gets or sets the ethnicity of the person.
        /// </summary>
        public string Ethnicity { get; set; }

        /// <summary>
        /// Gets or sets the family name of the person.
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// Gets or sets the gender of the person.
        /// </summary>
        public Gender? Gender { get; set; }

        /// <summary>
        /// Gets or sets the self-described gender with which a person identifies.
        /// </summary>
        /// <remarks>
        /// While this field is free-form, data should still follow standardized forms whenever possible (i.e. use
        /// "Female" and not "female" or "F"). If a person self-identifies as "Female", both gender and gender_identity fields
        /// should have a value of "Female". If a person self-identifies as "Transgender Female", gender should have a value of
        /// "Female" and gender_identity should have a value of "Transgender Female".
        /// </remarks>
        public string GenderIdentity { get; set; }

        /// <summary>
        /// Gets or sets the given name of the person.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets the prefix of the person.
        /// </summary>
        public string HonorificPrefix { get; set; }

        /// <summary>
        /// Gets or sets the honorific suffix of the person.
        /// </summary>
        public string HonorificSuffix { get; set; }

        /// <summary>
        /// Gets the unique set of languages spoken by the person as ISO 639 two-digit codes.
        /// </summary>
        public ICollection<string> LanguagesSpoken { get; private set; }

        /// <summary>
        /// Gets or sets the political party identification of the person.
        /// </summary>
        public PartyIdentification? PartyIdentification { get; set; }

        /// <summary>
        /// Gets the set of phone numbers of the person.
        /// </summary>
        public ICollection<PhoneNumber> PhoneNumbers { get; private set; }

        /// <summary>
        /// Gets the addresses of the person.
        /// </summary>
        public ICollection<PostalAddress> PostalAddresses { get; private set; }

        /// <summary>
        /// Gets the profiles of the person.
        /// </summary>
        public ICollection<Profile> Profiles { get; private set; }

        /// <summary>
        /// Gets or sets the occupation of the person.
        /// </summary>
        public string Occupation { get; set; }

        /// <summary>
        /// Gets or sets the source of where the person was acquired.
        /// </summary>
        public string Source { get; set; }
    }
}