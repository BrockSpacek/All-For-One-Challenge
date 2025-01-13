
using All_For_One_Challenge.services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_Challenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {

        private readonly GuessItServices _guessItServices;

        public GuessItController(GuessItServices guessItServices){
            _guessItServices = guessItServices;
        }

        
        [HttpPost]
        [Route("GuessitEasy/{guessNumberEasy}")]
        public string GuessItEasy(string guessNumberEasy){
            return _guessItServices.GuessItEasy(guessNumberEasy);
        }


        [HttpPost]
        [Route("GuessitMedium/{guessNumberMedium}")]
        public string GuessItMedium(string guessNumberMedium){
            return _guessItServices.GuessItMedium(guessNumberMedium);
        }


        [HttpPost]
        [Route("GuessitHard/{guessNumberHard}")]
        public string GuessItHard(string guessNumberHard){
            return _guessItServices.GuessItHard(guessNumberHard);
        }
    }
}