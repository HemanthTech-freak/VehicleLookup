namespace VehicleLookup.Models
{
    public class Insurance
    {
        public string? InsuranceProvider { get; set; }
        public string? PolicyNumber { get; set; }
        public string? PolicyType { get; set; }
        public int? PolicyTerm { get; set; }
        public DateTime? RiskStartDate { get; set; }
        public DateTime? RiskEndDate { get; set; }
    }
}
