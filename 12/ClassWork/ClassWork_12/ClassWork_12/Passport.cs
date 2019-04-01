using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_12
{
	class Passport:BaseDocument
	{
		public string DocName { get; set; }

		public string DocNumber { get; set; }

		public string Country { get; set; }

		public string PersonName { get; set; }

		public DateTimeOffset IssueDate { get; set; }

		public override string  PropertiesString
		{
			get { return $"{DocName} ,{DocNumber}, {IssueDate} , {Country},{PersonName}"; }
		}

		public Passport (string docNumber, DateTimeOffset issueDate, string country,string personName):base("Passport",docNumber,issueDate)
		{ }

		public DateTimeOffset ChangeIssueDate (DateTimeOffset newIssueDate)
		{
			IssueDate=newIssueDate;
		}

		/*public void WriteToConsole()
		{
			
			Console.WriteLine(PropertiesString);
		}*/
	}
}
