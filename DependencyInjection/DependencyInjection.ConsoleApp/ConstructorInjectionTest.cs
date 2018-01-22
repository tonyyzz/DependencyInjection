using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.ConsoleApp
{
	public class ConstructorInjectionTest
	{
		public static void Test()
		{
			ITimeProvider timeProvider = (new Assembler()).Create("UtcNowTimeProvider");
			var client = new Client(timeProvider);   // 在构造函数中注入
			var client2 = new Client2<SystemTimeProvider>();
			DateTime time = client.TimeProvider.CurrentTime;

		}
	}
}
