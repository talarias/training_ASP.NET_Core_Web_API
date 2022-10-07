using Microsoft.AspNetCore.Mvc;

namespace Training.API.Controllers
{
    [Route("/")]
    public class IndexController : ControllerBase
    {
        [HttpGet]
        public ContentResult GetContent()
        {
            var fileContent = System.IO.File.ReadAllText(@"./templates/Index.html");
            return base.Content(fileContent, "text/html");
        }
    }
}