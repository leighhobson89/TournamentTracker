namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents team member's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents team member's surname.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents team member's email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents team member's mobile number.
        /// </summary>
        public string MobilePhoneNumber { get; set; }
    }
}
