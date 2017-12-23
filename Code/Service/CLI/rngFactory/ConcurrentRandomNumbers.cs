using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.rngFactory
{
	class ConcurrentRandomNumbers : IRandomNumerGenerator
	{
		private static int ID = 0;
		public int GetNext()
		{
			return ++ID;
		}
	}
}
