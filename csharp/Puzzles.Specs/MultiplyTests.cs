using System;
using NUnit.Framework;
using static Puzzles.Puzzles;

namespace Puzzles.Specs
{
	[TestFixture]
	public class MultiplyTests
	{
		[TestCase(3,5,15)]
		[TestCase(1000,5, 5000)]
		[TestCase(-5,-5,25)]
		public void Multiply_AB_ReturnsExpectedValue(int a, int b, int expected)
		{
			// act
			var actual = Multiply(a, b);

			// assert
			Assert.AreEqual(expected, actual);
		}
	}
}
