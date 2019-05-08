using CW_22WB1.DataStore;
using CW_22WB1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CW_22WB1.Controllers
{
	[Route("/api/cities")]
	public class CitiesController:Controller
	{
		[HttpGet()]
		public JsonResult GetCities()
		{
			var citiesDataStore = CitiesDataStore.GetInstance();
			var cities = citiesDataStore.Cities;
			return new JsonResult(cities);
			/*return new JsonResult(
				new List<City>
				{
					new City
					{
						Id=1,
						Name = "Moscow",
						Description = "The capital of Russia"
					},

					new City
					{
						Id=2,
						Name = "New York",
						Description = "The one of the biggest cities in the world"
					},
				});
				*/
		}
		[HttpGet("{id}",Name = "GetCity")]
		public IActionResult GetCity(int id)
		{
			var citiesDataStore = CitiesDataStore.GetInstance();
			var city = citiesDataStore.Cities
				.Where(x => x.Id == id)
				.FirstOrDefault();

			if (city == null)
			{
				return NotFound();
			}

			return Ok(city);
		}
		[HttpPost()]
		public IActionResult CreateCity([FromBody]CityCreateModel city)
		{
			if(city ==null)
			{
				BadRequest();
			}
			var citiesDataStore = CitiesDataStore.GetInstance();
			int newCityId = citiesDataStore.Cities.Max(c => c.Id) + 1;

			var newCity = new CityGetModel
			{
				Id = newCityId,
				Name = city.Name,
				Description = city.Description,
				NumberOfPointsOfInterest = city.NumberOfPointsOfInterest
			};
			citiesDataStore.Cities.Add(newCity);

			return CreatedAtRoute(
				"GetCity",new {id = newCityId },
				newCity);
		}
	}
}
