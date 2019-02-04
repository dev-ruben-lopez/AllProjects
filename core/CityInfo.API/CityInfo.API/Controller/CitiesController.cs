using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace CityInfo.API.Controller
{
    //[Route("api/[controller]")] This would not allow later to refactor the controllers.
    [Route("api/cities")] //as all the methods in this controller are going to use this prefix route 
    public class CitiesController : ControllerBase
    {
        private IHostingEnvironment _env;

        private CitiesDataStore cities;

        public CitiesController(IHostingEnvironment env)
        {
            _env = env;
            cities = new CitiesDataStore(_env);
        }

        [HttpGet()]
        public IActionResult GetCities()
        {
            return Ok(new JsonResult( cities.Cities));
        }

        [HttpGet("{id}")]
        public IActionResult GetCities(int id)
        {
            var city = new JsonResult(cities.Cities.First(c => c.Id.Equals(id)));
            return Ok(city);
        }
            

    }
}
