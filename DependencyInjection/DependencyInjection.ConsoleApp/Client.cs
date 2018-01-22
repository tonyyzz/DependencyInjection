using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.ConsoleApp
{
	/// <summary>
	/// 在构造函数中注入
	/// </summary>
	public class Client
	{
		private ITimeProvider timeProvider;
		public Client(ITimeProvider timeProvider)
		{
			this.timeProvider = timeProvider;
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
