namespace Kata.FootballCards
{
	public class Team
	{
		private readonly PlayerBookingsCollection playerBookingsColl;
		public string Name { get; }

		public int RemainingPlayers => playerBookingsColl.RemainingPlayers;

		public Team(string name)
		{
			Name = name;
			this.playerBookingsColl = new PlayerBookingsCollection();
		}

		internal void GiveCard(BookingInfo bookingInfo)
		{
			this.playerBookingsColl.Get(bookingInfo.PlayerNumber).GiveCard(bookingInfo.CardType);
		}
	}
}
