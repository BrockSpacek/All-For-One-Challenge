
using All_For_One_Challenge.services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_Challenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {

        private readonly OddOrEvenServices _oddOrEvenServices;

        public OddOrEvenController(OddOrEvenServices oddOrEvenServices){
            _oddOrEvenServices = oddOrEvenServices;
        }
        [HttpPost]
        [Route("oddOrEven/{enterNumber}")]

        public string oddOrEven(string enterNumber)
        {
            return _oddOrEvenServices.oddOrEven(enterNumber);
        }
    }
}