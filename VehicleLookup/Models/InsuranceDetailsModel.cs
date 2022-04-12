namespace VehicleLookup.Models
{
    public class Insurance
    {
        public string InsuranceProvider { get; set; }
        public string PolicyNumber { get; set; }
        public string PolicyType { get; set; }
        public string PolicyTerm { get; set; }
        public DateTime? RiskStartDate { get; set; }
        public DateTime? RiskEndDate { get; set; }
    }
}
