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

        [HttpGet("{VehicleRegistrationNumber}")]

        public async Task<VehicleLookupResponseModel> VehicleLookupDetails(string VehicleRegistrationNumber)
        {
            try
            {
                VehicleLookupRequestModel request = new VehicleLookupRequestModel();
                    
                   request.VehicleRegistrationNumber =  VehicleRegistrationNumber;
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
