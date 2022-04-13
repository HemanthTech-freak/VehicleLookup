using System;
using System.Collections.Generic;

namespace VehicleLookup.Models.Entity
{
    public partial class VehicleDetail
    {
        public long Id { get; set; }
        public string RegistrationNumber { get; set; } = null!;
        public string? VehicleMake { get; set; }
        public string? VehicleModel { get; set; }
        public string? VehicleVariant { get; set; }
        public DateTime? RegistartionDate { get; set; }
        public decimal? ManufactureYear { get; set; }
        public decimal? RtoCode { get; set; }
        public string? RtoLocation { get; set; }
        public string? FuelType { get; set; }
        public string? EngineNo { get; set; }
        public string? ChasisNo { get; set; }
    }
}
