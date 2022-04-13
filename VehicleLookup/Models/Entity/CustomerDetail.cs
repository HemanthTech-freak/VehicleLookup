using System;
using System.Collections.Generic;

namespace VehicleLookup.Models.Entity
{
    public partial class CustomerDetail
    {
        public long Id { get; set; }
        public string RegistrationNumber { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? OrganisationName { get; set; }
        public string? PermanentAddress { get; set; }
        public string? CommunicationAddress { get; set; }
        public decimal? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? NomineeName { get; set; }
        public decimal? NomineeAge { get; set; }
        public string? NomineeRelationship { get; set; }
    }
}
