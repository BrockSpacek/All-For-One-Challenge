
using All_For_One_Challenge.services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_Challenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestarauntPickerController : ControllerBase
    {

        private readonly RestarauntPickerServices _restarauntPickerServices;

        public RestarauntPickerController(RestarauntPickerServices restarauntPickerServices){
            _restarauntPickerServices = restarauntPickerServices;
        }
         [HttpPost]
        [Route("RestarauntPicker/{restarauntCategory}")]

        public string RestarauntPicker(string restarauntCategory){
            return _restarauntPickerServices.RestarauntPicker(restarauntCategory);
        }
    }
}