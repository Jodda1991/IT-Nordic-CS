using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CW_23WB1.DataStore;
using CW_23WB1.Validation;

namespace CW_23WB1.Models
{
	public class CityReplaceModel
	{
		[Required]
		[MaxLength(100, ErrorMessage = "The name of the city shouldn't be longer than 100 characters")]
		public string Name { get; set; }

		[MaxLength(255, ErrorMessage = "Description should be not longer than 255 characters")]
		[DifferentValue(OtherProperty = "Name")]
		public string Description { get; set; }

		[Range(0, 100, ErrorMessage = "The number of points of interest should be between 0 and 100")]
		public int NumberOfPointsOfInterest { get; set; }

		public CityReplaceModel()
		{
		}

		public CityReplaceModel(CityData city)
		{
			Name = city.Name;
			Description = city.Description;
			NumberOfPointsOfInterest = city.NumberOfPointsOfInterest;
		}
	}
}
