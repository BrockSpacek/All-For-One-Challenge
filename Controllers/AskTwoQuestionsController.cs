
using All_For_One_Challenge.services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_Challenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AskTwoQuestionsController : ControllerBase
    {
         private readonly AskTwoQuestionsServices _askTwoQuestionsServices;

        public AskTwoQuestionsController(AskTwoQuestionsServices askTwoQuestionsServices)
        {
            _askTwoQuestionsServices = askTwoQuestionsServices;
        }

        [HttpPost]
        [Route("AddTwoInputs/{yourName}/{timeYouWokeUp}")]

         public string AcceptsTwoInputs(string yourName, string timeYouWokeUp)
        {
            return _askTwoQuestionsServices.AcceptsTwoInputs(yourName, timeYouWokeUp
            );
        }
    }
}