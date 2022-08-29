using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TestApi.Models;
using TestApi.Models.Base;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("_apiCorsPolicy")]
    public class CustomerController : ControllerBase
    {
        public static List<Customer> customerList = new List<Customer>();

        [HttpGet]
        [Route("get-customer-list")]
        public IActionResult Get()
        {
            ResponseModel<List<Customer>> customerResponse = new();
            if (customerList.Count == 0)
            {
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

                customerList.Add(new Customer()
                {
                    Name="Mahmut",
                    Surname="Alabey",
                    Age=32,
                    Address =new()
                    {
                        City="Bolu",
                        Street="Korkmazlar"
                    },
                    Phone="0536 983 92 01"
                });

                customerList.Add(new Customer()
                {
                    Name="Tuncay",
                    Surname="Akan",
                    Age=44,
                    Address =new()
                    {
                        City="Denizli",
                        Street="Madenler"
                    },
                    Phone=""
                });
                customerList.Add(new Customer()
                {
                    Name="Ekin",
                    Surname="Tarla",
                    Age=21,
                    Address =new()
                    {
                        City="",
                        Street=""
                    },
                    Phone="0539 828 01 92"
                });
                customerList.Add(new Customer()
                {
                    Name="Emine",
                    Surname="Altıntaş",
                    Age=58,
                    Address =new()
                    {
                        City="Trabzon",
                        Street="Sürmene"
                    },
                    Phone="0553 364 32 56"
                });
                customerList.Add(new Customer()
                {
                    Name="Emine",
                    Surname="Altıntaş",
                    Age=58,
                    Address =new()
                    {
                        City="Trabzon",
                        Street="Sürmene"
                    },
                    Phone="0553 364 32 56"
                });
                customerList.Add(new Customer()
                {
                    Name="Cüneyt",
                    Surname="Akıncı",
                    Age=47,
                    Address =new()
                    {
                        City="Samsun",
                        Street="Çarşamba"
                    },
                    Phone=""
                });

                customerList.Add(new Customer()
                {
                    Name="Ekim",
                    Surname="Turunç",
                    Age=32,
                    Address =new()
                    {
                        City="",
                        Street=""
                    },
                    Phone=""
                });
            }

            customerResponse.Status = 200;
            customerResponse.Message = "Successfull";
            customerResponse.Data = customerList;
            return Ok(customerResponse);
        }


        [HttpGet]
        [Route("customer-list-filter")]
        public IActionResult GetListByFilter(string keyword)
        {
            ResponseModel<List<Customer>> customerResponse = new();
            customerResponse.Status = 200;
            customerResponse.Data = customerList.Where(x => x.Name.ToLower().Contains(keyword.ToLower()) ||x.Surname.ToLower().Contains(keyword.ToLower())).ToList();
            customerResponse.Message = "Successfull";
            return Ok(customerResponse);
        }

        [HttpPost]
        [Route("customer-delete")]
        public IActionResult Delete(int id)
        {
            ResponseModel<Customer> customerResponse = new();
            Customer customer =  customerList.Where(x => x.Id == id).FirstOrDefault();
            if(customer != null)
            {
                customerList.Remove(customer);
                customerResponse.Data=customer;
                customerResponse.Status=200;
            }
            else
            {
                customerResponse.Status=400;
            }
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
