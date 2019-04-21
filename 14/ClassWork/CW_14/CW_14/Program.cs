using System;

namespace CW_14
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var errorList = new ErrorList("Program errors"))
			{
				errorList.Errors.Add("unknown error");
				errorList.Errors.Add("absolutely unknown error");

			}
		}
	}
}
