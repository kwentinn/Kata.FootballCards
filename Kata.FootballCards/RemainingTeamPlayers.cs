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
			TeamBooking booking = this.Team.GiveCard(bookingInfo);
			//if (booking.IsSentOff)
			//{
			//	NumberOfPlayers--;
			//}
		}
	}
}
