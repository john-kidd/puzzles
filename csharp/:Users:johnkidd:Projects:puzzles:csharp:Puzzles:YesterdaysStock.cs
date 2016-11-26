using System;
namespace Puzzles
{
	public static class YesterdaysStock
	{
		public static int CalculateMaxReturn(int[] stockPricesYesterday)
		{
			var min = 0;
			var max = 0;

			foreach (var stockPrice in stockPricesYesterday)
			{
				if (stockPrice > max)
					max = stockPrice;

				if (min == 0 || stockPrice < min)
					min = stockPrice;

			}

			return max - min;
		}
	}
}
