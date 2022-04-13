using Microsoft.EntityFrameworkCore;
using VehicleLookup.Core.VehicleLookup;
using VehicleLookup.Models;
using VehicleLookup.Models.Entity;

namespace VehicleLookup.Core.VehicleLookupService
{
    public class VehicleLookupService : IVehicleLookup
    {
        private readonly masterContext dbContext;
        public VehicleLookupService(masterContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<VehicleLookupResponseModel> VehicleLookupDetails(VehicleLookupRequestModel req)
        {
            try
            {
                if(req != null && !string.IsNullOrEmpty(req.VehicleRegistrationNumber))
                {

                    var vehicleDetailsResponse = await dbContext.VehicleDetails.Where(x => x.RegistrationNumber.Contains(req.VehicleRegistrationNumber)).FirstOrDefaultAsync();
                  if(vehicleDetailsResponse != null)
                    {
                        var customerDetails = await dbContext.CustomerDetails.Where(x => x.RegistrationNumber.Contains(req.VehicleRegistrationNumber)).FirstOrDefaultAsync();

                        if (customerDetails != null)
                        {
                            var insuranceDetails = await dbContext.InsuranceDetails.Where(x => x.RegistrationNumber.Contains(req.VehicleRegistrationNumber)).FirstOrDefaultAsync();

                            VehicleLookupResponseModel response = new VehicleLookupResponseModel();

                            response.Vehicle = new Vehicle();

                            response.Vehicle.RegistrationNumber = vehicleDetailsResponse?.RegistrationNumber;
                            response.Vehicle.ManufactureYear = vehicleDetailsResponse?.ManufactureYear;
                            response.Vehicle.ChasisNo = vehicleDetailsResponse?.ChasisNo;
                            response.Vehicle.EngineNo = vehicleDetailsResponse?.EngineNo;
                            response.Vehicle.FuelType = vehicleDetailsResponse?.FuelType;
                            response.Vehicle.RegistrationDate = vehicleDetailsResponse?.RegistartionDate;
                            response.Vehicle.RtoCode = vehicleDetailsResponse?.RtoCode;
                            response.Vehicle.RtoLocation = vehicleDetailsResponse?.RtoLocation;
                            response.Vehicle.VehicleMake = vehicleDetailsResponse?.VehicleMake;
                            response.Vehicle.VehicleModel = vehicleDetailsResponse?.VehicleModel;
                            response.Vehicle.VehicleVariant = vehicleDetailsResponse?.VehicleVariant;

                            response.Customer = new Customer();

                            response.Customer.EmailAddress = customerDetails?.EmailAddress;
                            response.Customer.CommunicationAddress = customerDetails?.CommunicationAddress;
                            response.Customer.DateOfBirth = customerDetails?.DateOfBirth;
                            response.Customer.NomineeAge = Convert.ToInt32(customerDetails?.NomineeAge);
                            response.Customer.NomineeName = customerDetails?.NomineeName;
                            response.Customer.NomineeRelationship = customerDetails?.NomineeRelationship;
                            response.Customer.PermanentAddress = customerDetails?.PermanentAddress;
                            response.Customer.PhoneNumber = Convert.ToInt64(customerDetails?.PhoneNumber);
                            if(!string.IsNullOrEmpty(customerDetails?.OrganisationName))
                            {
                                response.Customer.IndividualOrOrganisation = "Organisation";

                                response.Customer.Organisation = new Organisation();
                                response.Customer.Organisation.OrganisationName = customerDetails?.OrganisationName;
                            }
                            else
                            {
                                response.Customer.IndividualOrOrganisation = "Individual";

                                response.Customer.Individual = new Individual();
                                response.Customer.Individual.FirstName = customerDetails?.FirstName;
                                response.Customer.Individual.LastName = customerDetails?.LastName;
                            }

                            response.Insurance = new Insurance();

                            response.Insurance.InsuranceProvider = insuranceDetails?.InsuranceProvider;
                            response.Insurance.PolicyNumber = insuranceDetails?.PolicyNumber;
                            response.Insurance.PolicyTerm = Convert.ToInt32(insuranceDetails?.PolicyTerm);
                            response.Insurance.PolicyType = insuranceDetails?.PolicyType;
                            response.Insurance.RiskStartDate = insuranceDetails?.RiskStartDate;
                            response.Insurance.RiskEndDate = insuranceDetails?.RiskEndDate;

                            response.StatusMessage = "Success";


                            return response;

                        }
                    } 
                }

                VehicleLookupResponseModel failedResponse = new VehicleLookupResponseModel();

                failedResponse.StatusMessage = "Failed";

                return failedResponse;


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
