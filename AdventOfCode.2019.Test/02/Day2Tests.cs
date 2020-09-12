using AdventOfCode._2019._02;
using FluentAssertions;
using Xunit;

namespace AdventOfCode._2019.Test._02
{
	public class Day2Tests
	{
		[Fact]
		public void GIVEN_Program_1_0_0_0_99_WHEN_ExecutingProgram_THEN_Position_0_HasValue_2()
		{
			// Arrange
			var day2 = new Day2();
			var program = new int[] { 1, 0, 0, 0, 99 };

			// Act
			var result = day2.ExecuteIntercodeProgram(program, 0, 0);

			// Assert
			result.Should().BeEquivalentTo(new int[] { 2, 0, 0, 0, 99 });
		}

		[Fact]
		public void GIVEN_Program_2_3_0_3_99_WHEN_ExecutingProgram_THEN_Position_3_HasValue_6()
		{
			// Arrange
			var day2 = new Day2();
			var program = new int[] { 2, 3, 0, 3, 99 };

			// Act
			var result = day2.ExecuteIntercodeProgram(program, 3, 0);

			// Assert
			result.Should().BeEquivalentTo(new int[] { 2, 3, 0, 6, 99 });
		}

		[Fact]
		public void GIVEN_Program_2_4_4_5_99_0_WHEN_ExecutingProgram_THEN_Position_5_HasValue_9801()
		{
			// Arrange
			var day2 = new Day2();
			var program = new int[] { 2, 4, 4, 5, 99, 0 };

			// Act
			var result = day2.ExecuteIntercodeProgram(program, 4, 4);

			// Assert
			result.Should().BeEquivalentTo(new int[] { 2, 4, 4, 5, 99, 9801 });
		}

		[Fact]
		public void GIVEN_Program_1_1_1_4_99_5_6_0_999_WHEN_ExecutingProgram_THEN_Position_0_HasValue_30()
		{
			// Arrange
			var day2 = new Day2();
			var program = new int[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 };

			// Act
			var result = day2.ExecuteIntercodeProgram(program, 1, 1);

			// Assert
			result.Should().BeEquivalentTo(new int[] { 30, 1, 1, 4, 2, 5, 6, 0, 99 });
		}
	}
}
