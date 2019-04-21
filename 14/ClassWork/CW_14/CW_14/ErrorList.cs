using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CW_14
{

	class ErrorList : IDisposable,IEnumerable<string>
	{
		public string Category { get; private set; }

		private List<string> _errors { get; set; }

		public ErrorList(string category)
		{
			Category = category;
			_errors = new List<string>();
		}

		public void Dispose()
		{											
			if(_errors != null)
			{
				_errors.Clear();
				_errors = null;
			}
		}

		public void Add(string message)
		{
			
		}

		public IEnumerator<string> GetEnumerator()
		{
			
			
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)GetEnumerator();
		}



	}
}	

