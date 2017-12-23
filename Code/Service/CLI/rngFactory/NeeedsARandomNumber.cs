using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.rngFactory
{
	class NeeedsARandomNumber
	{
		IRandomNumerGenerator gen;

		public void setGenerator(int by)
		{
			switch(by)
			{
				case 1: gen = new ConcurrentRandomNumbers(); break;
				case 2: gen = new DateRandomNumber(); break;
			}
		}

		public int amethod()
		{
			return gen.GetNext();
		}
	}
}
