using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reminder.Storage.Core;
using Reminder.Storage.WebApi.Models;

namespace Reminder.Storage.WebApi.Controllers
{
	[Route("api/reminders")]
	[ApiController]
	public class RemindersController : ControllerBase
	{
		private IReminderStorage _reminderStorage;

		public RemindersController(IReminderStorage reminderStorage)
		{
			_reminderStorage = reminderStorage;
		}

		[HttpGet("{id}",Name ="GetReminder")]
		public IActionResult Get(Guid id)
		{
			var reminderItem = _reminderStorage.Get(id);

			if (reminderItem==null)
			{
				return NotFound();
			}

			return Ok(new ReminderItemGetModel(reminderItem));
		}

	
		[HttpPost]
		public IActionResult CreateReminder([FromBody] ReminderItemGetModel reminder )
		{
			if (reminder == null||!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var reminderItem = reminder.ToReminderItem();
			_reminderStorage.Add(reminderItem);

			return CreatedAtRoute(
				"GetReminder",
				new { id = reminderItem.Id },
				new ReminderItemGetModel(reminderItem));
		}

	}
}
