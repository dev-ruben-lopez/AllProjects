using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public static class CityDbContextExtension
    {

        public static void EnsureSeedDataCreatedForContextDB(this CityDbContext context)
        {
            if(context.Cities.Any())
            { return; }


            int[] cityIds = { 1, 2, 3, 4, 5 };

            foreach (int cid in cityIds)
            {
                var testCitiesDto = new Faker<City>()
                    .RuleFor(c => c.Id, f => f.IndexFaker)
                    .RuleFor(c => c.Name, f => f.Name.FirstName())
                    .RuleFor(c => c.Description, f => f.Lorem.Paragraph(1));

                var cityFaked = testCitiesDto.Generate(1);
                var cityId = cityFaked.Select(i => i.Id).FirstOrDefault();

                var testPointsOfInterest = new Faker<PointOfInterest>()
                .RuleFor(p => p.Id, f => f.IndexFaker)
                .RuleFor(p => p.Name, f => f.Lorem.Word())
                .RuleFor(p => p.Description, f => f.Lorem.Paragraph(1))
                .RuleFor(p => p.CityId, f=> cityId);
                

                
                var pointsFaked = testPointsOfInterest.Generate(5);

                context.AddRange(cityFaked);
                context.AddRange(pointsFaked);
                context.SaveChanges();

            }



        }
    }
}
