using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Reminder.Storage.Core;
using Reminder.Storage.InMemory;

namespace Reminder.Storage.WebApi
{
	public class Startup
	{
		//id = "00000000-0000-0000-0000-000000000000"
		//date = "2019-05-15T20:28:00+03:00",
		//contactId = "TestContactID"
		//message = "Test Message",
		//Status = 0
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

			//services.AddSingleton<IReminderStorage>(new InMemoryReminderStorage());

			
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			//else
			//{
			// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
			//app.UseHsts();
			//}

			//app.UseHttpsRedirection();
			app.UseMvc();
		}
	}
}
