using CW_23WB1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW_23WB1.DataStore
{
	public interface ICitiesDataStore
	{
		List<CityGetModel> Cities { get; }
	}
}
