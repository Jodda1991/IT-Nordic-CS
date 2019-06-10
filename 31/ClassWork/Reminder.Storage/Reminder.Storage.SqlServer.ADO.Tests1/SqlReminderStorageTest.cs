using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.SqlServer.ADO.Tests1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Storage.SqlServer.ADO.Tests
{
    

    [TestClass]
    public class SqlReminderStorageTest
    {
        private const string _connectionString =
            @"Data Source = localhost\SQLEXPRESS;Initial Catalog = ReminderTests;Integrated Security=True";

        [TestInitialize]
        public void TestInitialize()
        {
            (new SqlReminderStorageInit(_connectionString)).InitializeDatabase();
        }

        [TestMethod]
        public void Method_Add_Returns_Not_Empty_Guid()
        {
            var storage = new SqlServerReminderStorage(_connectionString);
            Guid actual = storage.Add(new Core.ReminderItemRestricted
            {
                ContactId = "TestContact",
                Date = DateTimeOffset.Now.AddHours(1),
                Message = "test",
                Status =Core.ReminderItemStatus.Awaiting
            });
            Assert.AreNotEqual(Guid.Empty, actual);
        }
    }
}
