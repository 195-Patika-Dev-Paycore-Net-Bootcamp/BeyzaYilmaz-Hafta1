using InterestCalculationProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace InterestCalculationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestCalculationController : ControllerBase
    {
        //Faiz getirisini hesaplayan metot
        [HttpGet("GetInterestCalculation")]
        public ActionResult<InterestResponseModel> GetInterestCalculation([FromQuery] InterestModel interestModel)
        {
            
            InterestResponseModel ınterestResponseModel = new InterestResponseModel();
            ınterestResponseModel.InterestRate = interestModel.InterestRate;
            ınterestResponseModel.TotalBalance = interestModel.Balance * Math.Pow((1 + (interestModel.InterestRate / 100)), interestModel.Maturity);
            return ınterestResponseModel;
        }
    }

}

