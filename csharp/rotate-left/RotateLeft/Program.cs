using System;
using System.Linq;

namespace RotateLeft
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string[] tokens_n = Console.ReadLine().Split(' ');
			int n = Convert.ToInt32(tokens_n[0]);
			int k = Convert.ToInt32(tokens_n[1]);
			string[] a_temp = Console.ReadLine().Split(' ');
			int[] a = Array.ConvertAll(a_temp, Int32.Parse);
			Console.WriteLine(RotateLeft(a, k));

		}

		private static string RotateLeft(int[] input, int n)
		{
			var output = input.ToList().ConvertAll(x => x);
			for (var i = 0; i < n; i++)
			{
				var temp = output.First();
				output.Remove(temp);
				output.Insert(output.Count, temp);

			}

			return string.Join(" ", output.ToArray());
		}
	}
}
