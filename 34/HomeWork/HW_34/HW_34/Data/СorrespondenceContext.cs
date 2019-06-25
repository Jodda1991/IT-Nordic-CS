using System;
using System.Collections.Generic;
using System.Text;
using HW_34.Domain;
using Microsoft.EntityFrameworkCore;

namespace HW_34.Data
{
	class СorrespondenceContext : DbContext
	{
		private string _connectionString;

		public DbSet<Address> Adresses { get; set; }

		public DbSet<City> Cities { get; set; }

		public DbSet<Contractor> Contractors { get; set; }

		public DbSet<Position> Positions { get; set; }

		public DbSet<PostalItem> PostalItems { get; set; }

		public DbSet<Status> Statuses { get; set; }

		public DbSet<SendingStatus> SendingStatuses { get; set; }

		public СorrespondenceContext()
		{
			_connectionString = @"Data Source=DESKTOP-M9B7A2P\SQLEXPRESS;"
				+ "Initial Catalog = CorrespondenceEF;"
				+ "Integrated Security = true";
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{


		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_connectionString);
		}
	}
}
