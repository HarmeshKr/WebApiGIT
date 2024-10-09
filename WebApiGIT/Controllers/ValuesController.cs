using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiGIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("today")]
        public IActionResult Get() 
        {
            return Ok(DateTime.Now);
        }
        [HttpGet]
        [Route("time")]
        public IActionResult GetResult()
        {
            var str = "Hello world";
            return Ok(DateTime.Now.ToLongTimeString());
        }

        [HttpGet]
        [Route("days")]
        public IActionResult Days()
        {
            string[] days = { "sunday", "monday", "tuesday" };
            return Ok(days);
        }
        
    }
}
