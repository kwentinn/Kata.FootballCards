namespace Kata.FootballCards
{
	public class Team
	{
		private readonly TeamBooking[] playerBookings;
		public string Name { get; }

		public int RemainingPlayers => playerBookings.Count(tb => !tb.IsSentOff);

		public Team(string name)
		{
			this.playerBookings = new TeamBooking[11];

			for (int i = 0; i < 11; i++)
			{
				this.playerBookings[i] = new TeamBooking(i + 1);
			}
			Name = name;
		}

		internal TeamBooking GiveCard(BookingInfo bookingInfo)
		{
			return this.playerBookings[bookingInfo.PlayerNumber - 1].GiveCard(bookingInfo.CardType);
		}
	}
}
