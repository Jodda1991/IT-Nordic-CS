using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Reminder.Storage.Core;
using Reminder.Storage.SqlServer.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reminder.Storage.SqlServer.EF
{
    public class EntityFrameworkReminderStorage : IReminderStorage
    {
        public static readonly LoggerFactory MyConsoleLoggerFactory =
            new LoggerFactory(new[]
            {
                new ConsoleLoggerProvider(
                    (category,level)=>
                    category == DbLoggerCategory.Database.Command.Name
                    && level == LogLevel.Information, true)
            });

        private readonly DbContextOptionsBuilder<ReminderStorageContext> _builder;

        public EntityFrameworkReminderStorage(
            string connectionString,
            bool enableLogging = false)
        {
            _builder = new DbContextOptionsBuilder<ReminderStorageContext>()
                .UseSqlServer(connectionString);

            if(enableLogging)
            {
                _builder
                    .UseLoggerFactory(MyConsoleLoggerFactory)
                    .EnableSensitiveDataLogging(true);
            }
        }

        public int Count
        {
            get
            {
                using (var context = new ReminderStorageContext(_builder.Options))
                {
                    return context.ReminderItems.Count();
                }
            }
        }

        public Guid Add(ReminderItemRestricted reminder)
        {
            var dto = new ReminderItemDto(reminder);

            using (var context = new ReminderStorageContext(_builder.Options))
            {
                context.ReminderItems.Add(dto);
                context.SaveChanges();
                return dto.Id;
            }
        }

        public ReminderItem Get(Guid id)
        {
            using (var context = new ReminderStorageContext(_builder.Options))
            {
                return context.ReminderItems.FirstOrDefault(ri=>ri.Id==id)
                    ?.ToReminderItem();
                
            }
        }

        public List<ReminderItem> Get(int count = 0, int startPostion = 0)
        {
            throw new NotImplementedException();
        }

        public List<ReminderItem> Get(ReminderItemStatus status, int count, int startPostion)
        {
            throw new NotImplementedException();
        }

        public List<ReminderItem> Get(ReminderItemStatus status)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatus(IEnumerable<Guid> ids, ReminderItemStatus status)
        {   
            
            using (var context = new ReminderStorageContext(_builder.Options))
            {
                var dtos = context.ReminderItems
                    .Where(d => ids.Contains(d.Id))
                    .ToList();

                foreach (var dto in dtos)
                {
                    dto.Status = status;
                }

                context.SaveChanges();
            }
        }

        public void UpdateStatus(Guid id, ReminderItemStatus status)
        {
            using (var context = new ReminderStorageContext(_builder.Options))
            {
                var reminderItemUpdate = context.ReminderItems.Find(id);
                reminderItemUpdate.Status = status;
                context.SaveChanges();      
            }
        }
    }
}
