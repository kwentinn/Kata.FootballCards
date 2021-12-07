namespace Kata.FootballCards
{
	public sealed record PlayerBooking
	{
		public int PlayerNumber { get; }

		private readonly BookingCountCollection bookingsCountCollection;

		public bool IsSentOff => bookingsCountCollection.SentOff;

		public PlayerBooking(int playerNumber)
		{
			PlayerNumber = playerNumber;

			this.bookingsCountCollection = new BookingCountCollection();
		}

		public void GiveCard(CardType cardType)
		{
			this.bookingsCountCollection.Get(cardType).IncreaseCount();
		}
	}
}
