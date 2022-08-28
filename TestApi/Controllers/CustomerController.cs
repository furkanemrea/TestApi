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
            return Ok("Furkan Emre Altıntaş");
        }

    }
}
