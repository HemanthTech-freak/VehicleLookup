namespace VehicleLookup.Models
{
    public class Vehicle
    {
        public string? RegistrationNumber { get; set; }
        public string? VehicleMake { get; set; }
        public string? VehicleModel { get; set; }
        public string? VehicleVariant { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public decimal? ManufactureYear { get; set; }
        public decimal? RtoCode { get; set; }
        public string? RtoLocation { get; set; }
        public string? FuelType { get; set; }
        public string? EngineNo { get; set; }
        public string? ChasisNo { get; set; }
    }
}
