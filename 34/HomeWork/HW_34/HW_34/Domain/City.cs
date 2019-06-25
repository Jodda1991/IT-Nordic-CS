using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HW_34.Domain
{
	public class City
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(250)]
		public string Name { get; set; }
	}
}
