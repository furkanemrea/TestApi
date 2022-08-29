using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestApi.Models;
using TestApi.Models.Base;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        public static List<Customer> customerList = new List<Customer>();

        [HttpGet]
        [Route("get-customer-list")]
        public IActionResult Get()
        {
            ResponseModel<List<Customer>> customerResponse = new();

            customerList.Add(new Customer()
            {
                Name="Furkan",
                Surname="Altıntaş",
                Age=26,
                Address =new()
                {
                    City="Zonguldak",
                    Street="Ereğli"
                },
                Phone="0553 497 09 01"
            });

            customerList.Add(new Customer()
            {
                Name="İbrahim",
                Surname="Altıntaş",
                Age=37,
                Address =new()
                {
                    City="Samsun",
                    Street="Canik"
                },
                Phone="0536 866 54 11"
            });

            customerList.Add(new Customer()
            {
                Name="Ayla",
                Surname="Altıntaş",
                Age=36,
                Address =new()
                {
                    City="Ankara",
                    Street=""
                },
                Phone="0536 866 54 11"
            });

            customerResponse.Status = 200;
            customerResponse.Message = "Successfull";
            customerResponse.Data = customerList;
            return Ok(customerResponse);
        }
        [HttpGet]
        [Route("first-test")]
        public IActionResult Test()
        {
            return Ok("Jenkins Test func");
        }

    }
}
