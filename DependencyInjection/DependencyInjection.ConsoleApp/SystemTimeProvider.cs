using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.ConsoleApp
{
	public class SystemTimeProvider : ITimeProvider
	{
		public DateTime CurrentTime => DateTime.Now;

		public string TimeType => "Now";
	}
}
