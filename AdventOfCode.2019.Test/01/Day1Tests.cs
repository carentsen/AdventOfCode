using AdventOfCode._2019._01;
using FluentAssertions;
using Xunit;

namespace AdventOfCode._2019.Test._01
{
	public class Day1Tests
	{
		#region Fuel

		[Fact]
		public void GIVEN_MassOf_12_WHEN_CalculatingFuel_THEN_Returns_2()
		{
			// Arrange
			var day1 = new Day1();
			var mass = 12;

			// Act
			var fuel = day1.CalculateFuel(mass);

			// Assert
			fuel.Should().Be(2);
		}

		[Fact]
		public void GIVEN_MassOf_14_WHEN_CalculatingFuel_THEN_Returns_2()
		{
			// Arrange
			var day1 = new Day1();
			var mass = 14;

			// Act
			var fuel = day1.CalculateFuel(mass);

			// Assert
			fuel.Should().Be(2);
		}

		[Fact]
		public void GIVEN_MassOf_1969_WHEN_CalculatingFuel_THEN_Returns_654()
		{
			// Arrange
			var day1 = new Day1();
			var mass = 1969;

			// Act
			var fuel = day1.CalculateFuel(mass);

			// Assert
			fuel.Should().Be(654);
		}

		[Fact]
		public void GIVEN_MassOf_100756_WHEN_CalculatingFuel_THEN_Returns_33583()
		{
			// Arrange
			var day1 = new Day1();
			var mass = 100756;

			// Act
			var fuel = day1.CalculateFuel(mass);

			// Assert
			fuel.Should().Be(33583);
		}
		
		#endregion
		#region Total Fuel

		[Fact]
		public void GIVEN_MassOf_14_WHEN_CalculatingTotalFuel_THEN_Returns_2()
		{
			// Arrange
			var day1 = new Day1();
			var mass = 14;

			// Act
			var fuel = day1.CalculateTotalFuel(mass);

			// Assert
			fuel.Should().Be(2);
		}

		[Fact]
		public void GIVEN_MassOf_1969_WHEN_CalculatingTotalFuel_THEN_Returns_966()
		{
			// Arrange
			var day1 = new Day1();
			var mass = 1969;

			// Act
			var fuel = day1.CalculateTotalFuel(mass);

			// Assert
			fuel.Should().Be(966);
		}

		[Fact]
		public void GIVEN_MassOf_100756_WHEN_CalculatingTotalFuel_THEN_Returns_50346()
		{
			// Arrange
			var day1 = new Day1();
			var mass = 100756;

			// Act
			var fuel = day1.CalculateTotalFuel(mass);

			// Assert
			fuel.Should().Be(50346);
		}

		#endregion
	}
}
