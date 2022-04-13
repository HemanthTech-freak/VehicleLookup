using System;
using System.Collections.Generic;

namespace VehicleLookup.Models.Entity
{
    public partial class InsuranceDetail
    {
        public long Id { get; set; }
        public string RegistrationNumber { get; set; } = null!;
        public string? InsuranceProvider { get; set; }
        public string? PolicyNumber { get; set; }
        public string? PolicyType { get; set; }
        public decimal? PolicyTerm { get; set; }
        public DateTime? RiskStartDate { get; set; }
        public DateTime? RiskEndDate { get; set; }
    }
}
