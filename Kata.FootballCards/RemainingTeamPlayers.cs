namespace Kata.FootballCards
{
	public record RemainingTeamPlayers
	{
		public Team Team { get; }
		public int RemainingPlayers => Team.RemainingPlayers;
		public bool IsLessThanSevenPlayers => RemainingPlayers < 7;

		public RemainingTeamPlayers(Team team)
		{
			Team = team;
		}

		internal void GiveCard(BookingInfo bookingInfo)
		{
			this.Team.GiveCard(bookingInfo);
		}
	}
}
