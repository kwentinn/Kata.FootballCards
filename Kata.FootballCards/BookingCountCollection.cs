namespace Kata.FootballCards
{
	internal sealed class BookingCountCollection
	{
		private readonly BookingCount[] bookingsCount;

		public bool SentOff => bookingsCount.Any(bc => bc.IsSentOff);

		public BookingCountCollection()
		{
			this.bookingsCount = new BookingCount[2]
			{
				new(CardType.Yellow),
				new(CardType.Red),
			};
		}

		public BookingCount Get(CardType cardType) => this.bookingsCount.First(bc => bc.CardType == cardType);
	}
}
