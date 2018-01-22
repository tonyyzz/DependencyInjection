﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.ConsoleApp
{
	public class UtcNowTimeProvider : ITimeProvider
	{
		public DateTime CurrentTime => DateTime.UtcNow;

		public string TimeType => "UtcNow";
	}
}
