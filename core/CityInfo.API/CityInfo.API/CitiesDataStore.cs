using CityInfo.API.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public IEnumerable<CityDto> Cities { get; set; }
        public CitiesDataStore()
        {

<<<<<<< HEAD
<<<<<<< HEAD
            _env = env;

            string filepath = Path.Combine(_env.ContentRootPath,  "Data\\CitiesFakeData.json");

            if (!File.Exists(filepath))
                throw new FileNotFoundException(filepath); 

=======

            //TODO: get the dynamic directory
            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Split("bin")[0], "Data\\CitiesFakeData.json");
            //string result = string.Empty;
>>>>>>> dxc-api-001
=======

            //TODO: get the dynamic directory
            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Split("bin")[0], "Data\\CitiesFakeData.json");
            //string result = string.Empty;
>>>>>>> 32ac13fa944b07ee3a6a9821359d6962234e2d70
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                //var jobj = JObject.Parse(json);
                Cities = JsonConvert.DeserializeObject<IEnumerable<CityDto>>(json);

            }
              /*  Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "The one that Americans think is the capital of the world.",
                },
                new CityDto()
                {
                    Id =2,
                    Name="Paris",
                    Description = "City of lights"
                }
            };*/

        }



    }
}
