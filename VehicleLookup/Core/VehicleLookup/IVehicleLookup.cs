using VehicleLookup.Models;

namespace VehicleLookup.Core.VehicleLookup
{
    public interface IVehicleLookup
    {
        Task<VehicleLookupResponseModel> VehicleLookupDetails(VehicleLookupRequestModel req);
    }
}
