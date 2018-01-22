using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.ConsoleApp
{
	/// <summary>
	/// blog: http://blog.csdn.net/Chen_Victor/article/details/76329336
	/// </summary>
	public interface ITimeProvider
	{
		DateTime CurrentTime { get; }
		string TimeType { get; }
	}
}
