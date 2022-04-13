using Microsoft.AspNetCore.Mvc;
using VehicleLookup.Core.VehicleLookup;
using VehicleLookup.Core.VehicleLookupService;
using VehicleLookup.Models;
using VehicleLookup.Models.Entity;

namespace VehicleLookup.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleLookupController : ControllerBase
    {
        private readonly IVehicleLookup vehicleLookup;

        public VehicleLookupController(IVehicleLookup vehicleLookup)
        {
         this.vehicleLookup = vehicleLookup;

        }

        [HttpPost]
        [Route("GetDetails")]
        public async Task<VehicleLookupResponseModel> VehicleLookup(VehicleLookupRequestModel request)
        {
            try
            {
                VehicleLookupResponseModel response = new VehicleLookupResponseModel();

                response = await vehicleLookup.VehicleLookupDetails(request);

                return response;

            }
            catch (Exception ex)
            {

                VehicleLookupResponseModel failedResponse = new VehicleLookupResponseModel();

                failedResponse.StatusMessage = "Failed";
                failedResponse.ErrorMessage = ex.Message;

                return failedResponse;
            }

           
        }
    }
}
