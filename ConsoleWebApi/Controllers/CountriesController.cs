using ConsoleWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [BindProperties(SupportsGet = true)]
    public class CountriesController : ControllerBase
    {
       // public CountryModel Country { get; set; }

        //public string Name { get; set; }

        //public int Population { get; set; }

        //public int Area { get; set; }

        [HttpGet("{name}/{Population}/{Area}")]
        public IActionResult AddCountry([FromRoute] CountryModel model, [FromRoute] int id)
        {
            return Ok($"Name = {model.Name}");
        }

        [HttpGet("search")]
        public IActionResult searchCountries([ModelBinder(typeof(CustomBinder))]string[] countries) 
        {
            return Ok(countries);
        }

        [HttpGet("{id}")]
        public IActionResult CountryDetails([ModelBinder(Name = "Id")]CountryModel country)
        {
            return Ok(country);
        }

    }
}
