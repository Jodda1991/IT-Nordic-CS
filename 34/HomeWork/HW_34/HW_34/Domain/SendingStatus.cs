using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HW_34.Domain
{
	public class SendingStatus
	{
		public PostalItem PostalItem { get; set; }
		[Key]
		public DateTimeOffset UpdateStatusDateTime { get; set; }

		public Status Status { get; set; }

		public Contractor SendingContractor { get; set; }

		public Address SendingAddress { get; set; }

		public Contractor ReceivingContractor { get; set; }

		public Address ReceivingAddress { get; set; }

	}
}
