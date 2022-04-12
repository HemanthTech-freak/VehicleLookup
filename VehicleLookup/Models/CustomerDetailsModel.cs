namespace VehicleLookup.Models
{
    public class Customer
    {
        public string? IndividualOrOrganisation { get; set; }
        public Individual? Individual { get; set; }
        public Organisation? Organisation { get; set; }
        public string? PermanentAddress { get; set; }
        public string? CommunicationAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? NomineeName { get; set; }
        public string? NomineeAge { get; set; }
        public string? NomineeRelationship { get; set; }
    }

    public class Individual
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

    public class Organisation
    {
        public string? OrganisationName { get; set; }
    }
}
