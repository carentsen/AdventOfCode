using System;
using System.IO;
using System.Linq;

namespace AdventOfCode._2019._02
{
	public class Day2
	{
		// 1 adds, 2 multiplies and 99 terminates.
		// Start at 0 and read elements at a time.

		public int[] ExecuteIntercodeProgram(int[] program, int noun, int verb)
		{
			var state = program.Clone() as int[];
			var pointer = 0;
			state[1] = noun;
			state[2] = verb;

			while (state[pointer] != 99)
			{
				if (state[pointer] == 1)
				{
					state[state[pointer + 3]] = state[state[pointer + 1]] + state[state[pointer + 2]];
				}
				else if (state[pointer] == 2)
				{
					state[state[pointer + 3]] = state[state[pointer + 1]] * state[state[pointer + 2]];
				}
				else
				{
					throw new Exception($"Does not compute!!! Invalid input: {state[pointer]}");
				}
				
				pointer += 4;
			}

			return state;
		}

		public int SolvePuzzle()
		{
			using (var sr = File.OpenText("Inputs/Day02.txt"))
			{
				string s = sr.ReadLine();
				var input = s.Split(',').Select(x => int.Parse(x)).ToArray();
				var result = ExecuteIntercodeProgram(input, 12, 2);
				return result[0];
			}
		}

		public int SolvePuzzlePart2()
		{
			using (var sr = File.OpenText("Inputs/Day02.txt"))
			{
				string s = sr.ReadLine();
				var input = s.Split(',').Select(x => int.Parse(x)).ToArray();

				for (var i = 0; i < 100; i++)
				{
					for (var j = 0; j < 100; j++){

						var result = ExecuteIntercodeProgram(input, i, j);
						if (result[0] == 19690720)
						{
							return 100 * i + j;
						}
					}
				}

				return 0;
			}
		}
	}
}
