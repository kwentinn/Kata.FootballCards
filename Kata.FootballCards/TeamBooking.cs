namespace Kata.FootballCards
{
	public record TeamBooking
	{
		public int PlayerNumber { get; }
		public int YellowCards { get; private set; }
		public int RedCards { get; private set; }

		public bool IsSentOff => RedCards == 1 || YellowCards == 2;

		public TeamBooking(int playerNumber)
		{
			PlayerNumber = playerNumber;
		}

		public TeamBooking GiveCard(CardType cardType)
		{
			if (cardType == CardType.Yellow)
			{
				return this.GiveYellow();
			}
			if (cardType == CardType.Red)
			{
				return this.GiveRed();
			}
			return this;
		}

		private TeamBooking GiveYellow()
		{
			if (this.YellowCards < 2)
			{
				this.YellowCards++;
			}
			return this;
		}
		private TeamBooking GiveRed()
		{
			if (this.RedCards < 1)
			{
				this.RedCards++;
			}
			return this;
		}
	}
}
