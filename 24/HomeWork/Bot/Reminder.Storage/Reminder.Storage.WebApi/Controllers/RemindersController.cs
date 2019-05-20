using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Reminder.Storage.Core;
using Reminder.Storage.WebApi.Core;

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
		public IActionResult CreateReminder([FromBody] ReminderItemCreateModel reminder )
		{
			if (reminder == null||!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var reminderItem = reminder.ToReminderItem();
			Guid id = _reminderStorage.Add(reminderItem);

			return CreatedAtRoute(
				"GetReminder",
				new { id },
				new ReminderItemGetModel(id,reminderItem));
		}

		[HttpGet]
		public IActionResult GetReminders([FromQuery(Name ="[filter]status")]ReminderItemStatus status)
		{
			var reminderItemGetModel = _reminderStorage
				.Get(status)
				.Select(x => new ReminderItemGetModel(x))
				.ToList();

			return Ok(reminderItemGetModel);
		}

		[HttpPatch]
		public IActionResult UpdateReminderStatus(Guid id,
			[FromBody] JsonPatchDocument<ReminderItemsUpdateModel> patchDocument)
		{
			

			var reminderItem = _reminderStorage.Get(id);

			if(reminderItem == null)
			{
				return BadRequest();
			}

			if (reminderItem == null || !ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var reminderItemModelToPatch = new ReminderItemUpdateModel
			{
				Status = reminderItem.Status
			};

			patchDocument.ApplyTo(reminderItemModelToPatch);

			_reminderStorage.UpdateStatus(
				id,
				reminderItemModelToPatch.PatchDocument);
		}
	}
}
