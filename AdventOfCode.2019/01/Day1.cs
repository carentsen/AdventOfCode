using System;
using System.IO;

namespace AdventOfCode._2019._01
{
	public class Day1
	{
		public int CalculateFuel(int mass)
		{
			return (mass / 3) - 2;
		}

		public int CalculateTotalFuel(int mass)
		{
			var initalFuel = CalculateFuel(mass);
			var totalFuel = initalFuel;

			while (initalFuel > 0)
			{
				var fuel = CalculateFuel(initalFuel);
				if (fuel > 0)
				{
					totalFuel += fuel;
				}
				initalFuel = fuel;
			}

			return totalFuel;
		}

		public int SolvePuzzle()
		{
			var fuelSum = 0;
			using (var sr = File.OpenText("Inputs/Day01.txt"))
			{
				string s = String.Empty;
				while ((s = sr.ReadLine()) != null)
				{
					fuelSum += CalculateTotalFuel(int.Parse(s));
				}
			}

			return fuelSum;
		}
	}
}
