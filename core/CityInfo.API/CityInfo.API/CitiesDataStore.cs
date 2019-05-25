using CityInfo.API.Models;
using Microsoft.AspNetCore.Hosting;
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
        public static CitiesDataStore Current { get; } 
        public IEnumerable<CityDto> Cities { get; set; }
        private IHostingEnvironment _env;

        private IHostingEnvironment _hostingEnvironment;
        private string projectRootFolder;
        public CitiesDataStore(IHostingEnvironment env)
        {

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
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                Cities = JsonConvert.DeserializeObject<IEnumerable<CityDto>>(json);

            }

        }



    }
}
