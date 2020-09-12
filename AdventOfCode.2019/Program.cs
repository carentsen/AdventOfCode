using AdventOfCode._2019._01;
using AdventOfCode._2019._02;
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

			var day02 = new Day2();
			var day02Result = day02.SolvePuzzle();
			Console.WriteLine($"Day 02: Value at index 0: {day02Result}");
			var day02Part2Result = day02.SolvePuzzlePart2();
			Console.WriteLine($"Day 02 Part 2: 100 * noun + verb = {day02Part2Result}");

			Console.ReadLine();
		}
	}
}
