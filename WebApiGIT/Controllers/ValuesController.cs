using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiGIT.Controllers
{
   // [Route("api/[controller]")]
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
        [Route("colors")]
        public IActionResult Colors()
        {
            string[] colors = { "red", "green", "blue" };
            return Ok(colors);
        }

        [HttpGet]
        [Route("days")]
        public IActionResult Days()
        {
            string[] days = { "sunday", "monday", "tuesday" };
            return Ok(days);
        }
        [HttpGet]
        [Route("seasons")]
        public IActionResult Seasons()
        {
            string[] days = { "Summer","Winter","Rainy","Autumn","Spring" };
            return Ok(days);
        }

        [HttpGet]
        [Route("months")]
        public IActionResult Months()
        {
            string[] days = { "January","February","March" };
            return Ok(days);
        }

        [HttpGet]
        [Route("food")]
        public IActionResult Food()
        {
            string[] days = { "Bread", "Biryani", "Burger","Samosa","Sandwich" };
            return Ok(days);
        }
    }
}
