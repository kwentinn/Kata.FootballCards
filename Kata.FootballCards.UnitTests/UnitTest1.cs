using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.FootballCards.UnitTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void StandardCase()
		{
			(int, int) expectedResult = (11, 11);

			string[] cards = { };

			(int, int) actualResult = new Game().GetRemainingPlayers(cards);

			actualResult.Should().Be(expectedResult);
		}
		
		[TestMethod]
		public void GivenOneCardOnBothTeamsThereShouldBe11PlayersRemainingOnEachTeam()
		{
			(int, int) expectedResult = (11, 11);

			string[] cards = { "B7Y", "A8Y" };

			(int, int) actualResult = new Game().GetRemainingPlayers(cards);

			actualResult.Should().Be(expectedResult);
		}
		
		[TestMethod]
		public void GivenOneRedCardOnTeamAThereShouldBe10PlayersRemainingOnTeamA()
		{
			(int, int) expectedResult = (10, 11);

			string[] cards = { "A7R" };

			(int, int) actualResult = new Game().GetRemainingPlayers(cards);

			actualResult.Should().Be(expectedResult);
		}
		
		[TestMethod]
		public void TeamAGets4PlayersSentOff()
		{
			(int, int) expectedResult = (7, 11);

			string[] cards = { "A1R", "A2R", "A3R", "A4R" };

			(int, int) actualResult = new Game().GetRemainingPlayers(cards);

			actualResult.Should().Be(expectedResult);
		}
		
		[TestMethod]
		public void TeamAGets5PlayersSentOff()
		{
			(int, int) expectedResult = (6, 11);

			string[] cards = { "A1R", "A2R", "A3R", "A4R", "A5R" };

			(int, int) actualResult = new Game().GetRemainingPlayers(cards);

			actualResult.Should().Be(expectedResult);
		}
		
		[TestMethod]
		public void TeamAGets6PlayersSentOff()
		{
			(int, int) expectedResult = (6, 11);

			string[] cards = {
				"A1R", "A2R", "A3R", "A4R" , "A5R" , "A6R"
			};

			(int, int) actualResult = new Game().GetRemainingPlayers(cards);

			actualResult.Should().Be(expectedResult);
		}

		[TestMethod]
		public void BothTeamsGet3PlayersSentOff()
		{
			(int, int) expectedResult = (8, 8);

			string[] cards = 
			{
				"A1R", "A2R", "A3R",
				"B1R", "B2Y", "B2Y", "B2Y", "B3R",
			};

			(int, int) actualResult = new Game().GetRemainingPlayers(cards);

			actualResult.Should().Be(expectedResult);
		}
	}
}