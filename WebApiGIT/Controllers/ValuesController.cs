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
            return Ok(DateTime.Now.ToLongTimeString());
        }
    }
}
