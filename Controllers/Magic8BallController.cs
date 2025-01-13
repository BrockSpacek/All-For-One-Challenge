
using All_For_One_Challenge.services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_Challenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Magic8BallController : ControllerBase
    {

        private readonly Magic8BallServices _magic8BallServices;

        public Magic8BallController(Magic8BallServices magic8BallServices){
            _magic8BallServices = magic8BallServices;
        }
        [HttpPost]
        [Route("MagicEightBall/{yesOrNoQuestion}")]

        public string EightBallGame(string yesOrNoQuestion)
        {
            return _magic8BallServices.MagicEightBall(yesOrNoQuestion);
        }
    }
}