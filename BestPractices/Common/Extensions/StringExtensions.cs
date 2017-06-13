using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedram.BestPractices.Extensions
{
	public static class StringExtensions
	{
		public static bool IsNumber(this string stringNumber)
		{
			long number;
			return long.TryParse(stringNumber, out number);
		}

		public static bool IsTime(this string stringTime)
		{
			throw new NotImplementedException();
		}
		
		public static bool IsDate(this string stringDate)
		{
			throw new NotImplementedException();
		}
	}
}
