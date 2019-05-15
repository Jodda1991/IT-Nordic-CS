using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CW_23WB1.DataStore;

namespace CW_23WB1.Models
{
	public class CityGetModel
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public int NumberOfPointsOfInterest { get; set; }

		public CityGetModel()
		{

		}

		public CityGetModel(CityData city)
		{
			Id = city.Id;
			Name = city.Name;
			Description = city.Description;
			NumberOfPointsOfInterest = city.NumberOfPointsOfInterest;
		}
	}
}
