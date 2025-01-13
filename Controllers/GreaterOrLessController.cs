
using All_For_One_Challenge.services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_Challenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterOrLessController : ControllerBase
    {
       
       private readonly GreaterOrLessServices _greaterOrLessServices;

       public GreaterOrLessController(GreaterOrLessServices greaterOrLessServices){
        _greaterOrLessServices = greaterOrLessServices;
       }

        [HttpPost]
        [Route("GreaterOrLessThan/{numberOne}/{numberTwo}")]

        public string acceptsTwoNumbers(string numberOne, string numberTwo)
        {
            return _greaterOrLessServices.acceptsTwoNumbers(numberOne, numberTwo);
        }
    }
}