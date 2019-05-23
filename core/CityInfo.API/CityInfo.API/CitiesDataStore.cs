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

            
            string filepath = @"D:\src\git\AllProjects\core\CityInfo.API\CityInfo.API\Data\CitiesFakeData.json";
            string result = string.Empty;
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
