
using All_For_One_Challenge.services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_Challenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;

        public MadLibController(MadLibServices madLibServices)
        {
          _madLibServices = madLibServices;
        }

        [HttpPost]
         [Route("Madlibs/{enterName}/{enterNumberOne}/{enterNameTwo}/{enterNumberTwo}/{city}/{animal}/{hobby}/{job}/{car}/{carTwo}/{yesOrNo}")]
         public string madLibs(string enterName, string enterNumberOne, string enterNameTwo, string enterNumberTwo, string city, string animal, string hobby, string job, string car, string carTwo, string yesOrNo)
        {
            return _madLibServices.madLibs(enterName, enterNumberOne, enterNameTwo, enterNumberTwo, city, animal, hobby, job, car, carTwo, yesOrNo);
        }
    }
}