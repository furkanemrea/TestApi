using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        [Route("first-test")]
        public IActionResult Test()
        {
            return Ok("Test");
        }
        [HttpGet]
        [Route("second-test")]
        public IActionResult Test2()
        {
            return Ok("Jenkins Executed"); 
        }
    }
}
