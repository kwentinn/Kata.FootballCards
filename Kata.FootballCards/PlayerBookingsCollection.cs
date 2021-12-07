namespace Kata.FootballCards
{
	public sealed class PlayerBookingsCollection
	{
		private readonly PlayerBooking[] playerBookings;
		public int RemainingPlayers => this.playerBookings.Count(tb => !tb.IsSentOff);

		public PlayerBookingsCollection()
		{
			this.playerBookings = new PlayerBooking[11];
			for (int i = 0; i < 11; i++)
			{
				this.playerBookings[i] = new PlayerBooking(i + 1);
			}
		}

		public PlayerBooking Get(int playerNumber)
		{
			return this.playerBookings[playerNumber - 1];
		}
	}
}
