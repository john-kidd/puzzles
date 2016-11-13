using System;
using NUnit.Framework;
using static Puzzles.Puzzles;

namespace Puzzles.Specs
{
	[TestFixture]
	public class RotateLeftTests
	{
		[TestCase(new[] { 1, 2, 3, 4, 5 }, 2)]
		public void RotateLeft_ReturnsExpectedValue(int[] input, int n)
		{
			// arrange
			var expected = new[] { 3, 4, 5, 1, 2 };

			// act
			var actual = RotateLeft(input, n);

			// assert
			Assert.AreEqual(expected, actual);
		}
	}
}
