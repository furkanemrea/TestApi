using System;

namespace TestApi.Models
{
    public class Customer
    {
        public int Id { get; set; } = new Random().Next(0,1000000);
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public Addres Address { get; set; }
    }
    public class Addres
    {
        public string Street { get; set; }
        public string City { get; set; }
    }
}
