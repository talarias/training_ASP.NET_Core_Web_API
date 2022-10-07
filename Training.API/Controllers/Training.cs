using Microsoft.AspNetCore.Mvc;

namespace Training.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainingController : ControllerBase
    {
        [HttpGet]
        public String getContent()
        {
            return "Training";
        }
    }
}