namespace Kata.FootballCards
{
	public class MatchSheet
	{
		private readonly RemainingTeamPlayers remainingTeamPlayersHome;
		private readonly RemainingTeamPlayers remainingTeamPlayersAway;

		public bool IsGameStopped { get; private set; }

		public MatchSheet(string homeTeamName, string awayTeamName)
		{
			remainingTeamPlayersHome = new(new(homeTeamName));
			remainingTeamPlayersAway = new(new(awayTeamName));
		}

		public void GiveCard(BookingInfo bookingInfo)
		{
			RemainingTeamPlayers remaining = bookingInfo.IsTeam(remainingTeamPlayersHome.Team.Name) ? remainingTeamPlayersHome : remainingTeamPlayersAway;
			
			remaining.GiveCard(bookingInfo);

			if (remaining.IsLessThanSevenPlayers)
			{
				IsGameStopped = true;
				return;
			}
		}

		public (int, int) ToTuple()
		{
			return (remainingTeamPlayersHome.RemainingPlayers, remainingTeamPlayersAway.RemainingPlayers);
		}
	}
}
