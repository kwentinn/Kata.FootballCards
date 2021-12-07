namespace Kata.FootballCards
{
	public sealed class Game
	{
		public (int, int) GetRemainingPlayers(string[] cardsInfo)
		{
			if (cardsInfo is null || cardsInfo.Length == 0)
			{
				return (11, 11);
			}

			IEnumerable<BookingInfo> bookings = BookingInfoBuilder.BuildBookings(cardsInfo);

			return GetRemainingPlayers(bookings);
		}

		private (int, int) GetRemainingPlayers(IEnumerable<BookingInfo> bookings)
		{
			MatchSheet matchSheet = new("A", "B");
			foreach (BookingInfo bookingInfo in bookings)
			{
				matchSheet.GiveCard(bookingInfo);
				if (matchSheet.IsGameStopped)
				{
					return matchSheet.ToTuple();
				}
			}
			return matchSheet.ToTuple();
		}
	}
}
