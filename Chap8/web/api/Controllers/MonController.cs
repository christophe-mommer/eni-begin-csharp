using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApi.Controllers
{
    [ApiController]
    [Route("moncontroleur")]
    public class MonControleur : ControllerBase
    {
        private static string Data = "";

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Data);
        }

        [HttpPost]
        public IActionResult Post(string value)
        {
            Data = value;
            return Ok();
        }
    }
}
