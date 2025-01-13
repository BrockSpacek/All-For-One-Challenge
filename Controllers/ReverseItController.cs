
using All_For_One_Challenge.services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_Challenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItController : ControllerBase
    {
        private readonly ReverseItServices _reverseItServices;

        public ReverseItController(ReverseItServices reverseItServices){
            _reverseItServices = reverseItServices;
        }

        [HttpPost]
        [Route("reverseNumber/{inputNumber}")]
        public string reverseNumber(string inputNumber){
            return _reverseItServices.reverseNumber(inputNumber);
        }

        [HttpPost]
        [Route("reverseString/{password}")]
        public string reverseString(string password){
            return _reverseItServices.reverseString(password);
        }
    }
}