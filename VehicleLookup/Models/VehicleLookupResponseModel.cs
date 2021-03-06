namespace VehicleLookup.Models
{
    public class VehicleLookupResponseModel
    {
        public Vehicle? Vehicle { get; set; }
        public Customer? Customer { get; set; }
        public Insurance? Insurance { get; set; }

        public string? StatusMessage { get; set; }
        public string? ErrorMessage { get; set; }
    }

}
