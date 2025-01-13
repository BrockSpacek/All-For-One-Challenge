
using All_For_One_Challenge.services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_Challenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {

        private readonly SayHelloServices _sayHelloServices;

        public SayHelloController(SayHelloServices sayHelloServices){
            _sayHelloServices = sayHelloServices;
        }

        [HttpPost]
        [Route("Greeting/{name}")]
        public string UserGreeting(string name)
        {
            return _sayHelloServices.UserGreeting(name);
        }
    }

}