
using All_For_One_Challenge.services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_Challenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddNumbersController : ControllerBase
    {
        private readonly AddNumbersServices _addNumbersServices;

        public AddNumbersController(AddNumbersServices addNumbersServices)
        {
          _addNumbersServices = addNumbersServices;
        }
        
         [HttpPost]
         [Route("Adding/{num1}/{num2}")]
         public string addTwoNumbers(string num1, string num2)
        {
            return _addNumbersServices.addTwoNumbers(num1, num2);
        }
    }
}