using CW_23WB1.DataStore;
using CW_23WB1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace CW_23WB1.Controllers
{
	[Route("/api/cities")]
	public class CitiesController:Controller
	{
		ILogger<CitiesController> _logger;
		ICitiesDataStore _citiesDataStore;

		public CitiesController(ILogger<CitiesController> logger,ICitiesDataStore citiesDataStore)
		{
			_logger = logger;
			_citiesDataStore = citiesDataStore;
		}

		[HttpGet()]
		public IActionResult GetCities()
		{
			_logger.LogInformation($"{nameof(GetCities)} called");

			var cities = _citiesDataStore.Cities;
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

			var city = _citiesDataStore.Cities
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

			if(!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
		
			int newCityId = _citiesDataStore.Cities.Max(c => c.Id) + 1;

			var newCity = new CityGetModel
			{
				Id = newCityId,
				Name = city.Name,
				Description = city.Description,
				NumberOfPointsOfInterest = city.NumberOfPointsOfInterest
			};
			_citiesDataStore.Cities.Add(newCity);

			return CreatedAtRoute(
				"GetCity",new {id = newCityId },
				newCity);
		}

		[HttpPut("{id}")]
		public  IActionResult UpdateCity(int id, [FromBody] CityCreateModel city)
		{
			if (city == null)
			{
				BadRequest();
			}

			var updatedCity = _citiesDataStore.Cities
					.Where(x => x.Id == id)
					.FirstOrDefault();
			if(updatedCity==null)
			{
				NotFound();
			}

			updatedCity.Name = updatedCity.Name;
			updatedCity.Description = updatedCity.Description;
			updatedCity.NumberOfPointsOfInterest = updatedCity.NumberOfPointsOfInterest;

			return NoContent();

		}

		[HttpDelete("{id}")]
		public IActionResult RemoveCity(int id)
		{


			var removedCity = _citiesDataStore.Cities
					.Where(x => x.Id == id)
					.FirstOrDefault();

			if (removedCity == null)
			{
				NotFound();
			}

			_citiesDataStore.Cities.Remove(removedCity);

			return NoContent();

		}

	}
}
