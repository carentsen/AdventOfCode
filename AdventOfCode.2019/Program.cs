using AdventOfCode._2019._01;
using System;

namespace AdventOfCode._2019
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var day01 = new Day1();
			var day01Result = day01.SolvePuzzle();
			Console.WriteLine($"Day 01: Sum of mass: {day01Result}");

			Console.ReadLine();
		}
	}
}
