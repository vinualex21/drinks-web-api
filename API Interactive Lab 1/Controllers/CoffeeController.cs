using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private List<Coffee> Coffees = new List<Coffee>()
        {
            new Coffee(){Id = -1, Name ="latte"},
            new Coffee(){Id = 1, Name ="cappucino"},
            new Coffee(){Id = 2, Name ="espresso"},
            new Coffee(){Id = 3, Name ="americano"}
        };

        [HttpGet]
        public string GetCoffee()
        {
            return "We've got fresh brewing coffee!";

        }

        [HttpGet("{name}")]
        public ActionResult<Coffee> Get(string? name)
        {
            if(name == null)
                return Coffees.Where(coffee => coffee.Name == "latte").FirstOrDefault();

            var coffee = Coffees.Where(coffee => coffee.Name == name).FirstOrDefault();
            if(coffee != null)
                return coffee;
            return NotFound();

        }

        [HttpGet("lover")]
        public string Get()
        {
            return "I like coffee!";
        }

        
    }
}
