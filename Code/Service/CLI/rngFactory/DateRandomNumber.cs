using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.rngFactory
{
	class DateRandomNumber : IRandomNumerGenerator
	{
		public int GetNext()
		{
			return DateTime.Now.GetHashCode();
		}
	}
}
