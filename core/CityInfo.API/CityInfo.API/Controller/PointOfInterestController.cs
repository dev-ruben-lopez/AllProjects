﻿using CityInfo.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controller
{
    [Route("api/cities")]
    public class PointOfInterestController : ControllerBase
    {
        [HttpGet("{cityId}/pointofinterest")]
        public IActionResult GetPointOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
                return NotFound();

            return Ok(city.PointOfIntererest);
        }

        [HttpGet("{cityId}/pointofinterest/{id}")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
                return NotFound("City");

            var point = city.PointOfIntererest.FirstOrDefault(c => c.Id == id);
            if (point == null)
                return NotFound("PointOfIntererest");

            return Ok(point);
        }

        [HttpPost("{cityId}/pointofinterest")]
        public IActionResult CreatePointOfInterest(int cityId, [FromBody] PointsOfInterestForCreationDto pointOfInterest)
        {
            if (pointOfInterest == null)
                return BadRequest(ModelState);

            var city = CitiesDataStore.Current.Cities.First(c => c.Id == cityId);
            if (city == null)
                return BadRequest();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            //mock thr response, as is in memory data

            var maxPointOfInterestId = CitiesDataStore.Current.Cities.SelectMany(
                c => c.PointOfIntererest).Max(p => p.Id);

            //create the resource
            PointsOfInterestDto newPointOfInterest = new PointsOfInterestDto() {
                Id = maxPointOfInterestId++,
                Description = pointOfInterest.Description,
                Name = pointOfInterest.Name
            };

            return CreatedAtRoute("GetPointOfInterest", new { cityId = cityId, pointOfInterest = newPointOfInterest });
        }

        [HttpPut("{cityId}/pointofinterest/{id}")]
        public IActionResult UpdatePointOfInterest(int cityId, int id, [FromBody] PointsOfInterestForCreationDto pointOfInterest)
        {

            if (pointOfInterest == null)
                return BadRequest(ModelState);

            var city = CitiesDataStore.Current.Cities.First(c => c.Id == cityId);
            if (city == null)
            {
                ModelState.AddModelError("", "City Id not found");
                return BadRequest(ModelState);
            }


            var currentPointOfInterest = CitiesDataStore.Current.Cities.SelectMany(c => c.PointOfIntererest).FirstOrDefault(p => p.Id == id);
            if (currentPointOfInterest == null)
            {
                ModelState.AddModelError("", "Point Id not found");
                return BadRequest(ModelState);
            }


            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            //update
            currentPointOfInterest.Name = pointOfInterest.Name;
            currentPointOfInterest.Description = pointOfInterest.Description;

            return NoContent();
        }


        [HttpPatch("{cityId}/pointofinterest/{id}")]
        public IActionResult PartialUpdatePointOfInterest(int cityId, int id,[FromBody] JsonPatchDocument<PointsOfInterestForCreationDto> patchDoc)
        {
            if (patchDoc == null)
                return BadRequest(ModelState);

            var city = CitiesDataStore.Current.Cities.First(c => c.Id == cityId);
            if (city == null)
            {
                ModelState.AddModelError("", "City Id not found");
                return BadRequest(ModelState);
            }


            var currentPointOfInterest = CitiesDataStore.Current.Cities.SelectMany(c => c.PointOfIntererest).FirstOrDefault(p => p.Id == id);
            if (currentPointOfInterest == null)
            {
                ModelState.AddModelError("", "Point Id not found");
                return BadRequest(ModelState);
            }



            var pointOfInterestToPatch = new PointsOfInterestForCreationDto() {
                Name = currentPointOfInterest.Name,
                Description = currentPointOfInterest.Description
            };



            patchDoc.ApplyTo(pointOfInterestToPatch, ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return NoContent();


        }


    }
}
