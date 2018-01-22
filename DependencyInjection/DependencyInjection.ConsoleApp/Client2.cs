using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.ConsoleApp
{

	public class Client2<TITimeProvider> where TITimeProvider : class, ITimeProvider
	{
		private ITimeProvider timeProvider;
		public Client2()
		{
			timeProvider = Activator.CreateInstance<TITimeProvider>();
		}

		public ITimeProvider TimeProvider
		{
			get
			{
				return timeProvider;
			}
		}
	}
}
