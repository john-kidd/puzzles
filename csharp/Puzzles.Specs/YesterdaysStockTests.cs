using System;
using NUnit.Framework;

namespace Puzzles.Specs
{
	[TestFixture]
	public class YesterdaysStockTests
	{
		[Test]
		public void CalculateMaxReturn_ReturnsExpectedValue()
		{
			// arrange 
			var input = new[] { 10, 7, 5, 8, 11, 9 };

			// act
			var actual = YesterdaysStock.CalculateMaxReturn(input);

			// assert
			Assert.That(6 == actual);
		}	
	}
}
