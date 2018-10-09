using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfPointOfIntererest{ get { return PointOfIntererest.Count(); } }

        public IEnumerable<PointsOfInterestDto> PointOfIntererest { get; set; }
        = new List<PointsOfInterestDto>();
    }
}
