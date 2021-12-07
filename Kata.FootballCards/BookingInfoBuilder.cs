namespace Kata.FootballCards
{
	public static class BookingInfoBuilder
	{
		public static IEnumerable<BookingInfo> BuildBookings(string[] cardsInfo)
		{
			foreach (string cardInfo in cardsInfo)
			{
				yield return BuildBookingInfo(cardInfo);
			}
		}
		private static BookingInfo BuildBookingInfo(string cardInfo)
		{
			return new BookingInfo
			(
				cardInfo[0].ToString(),
				int.Parse(cardInfo[1].ToString()),
				cardInfo[2].Equals('Y') ? CardType.Yellow : CardType.Red
			);
		}
	}
}
