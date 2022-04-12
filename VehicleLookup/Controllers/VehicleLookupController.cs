using Microsoft.AspNetCore.Mvc;
using VehicleLookup.Models;

namespace VehicleLookup.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleLookupController : ControllerBase
    {
        public VehicleLookupController()
        {

        }

        [HttpGet]
        public async Task<VehicleLookupResponseModel> VehicleLookup(VehicleLookupRequestModel request)
        {

            VehicleLookupResponseModel response = new VehicleLookupResponseModel();

           return response;
        }
    }
}
