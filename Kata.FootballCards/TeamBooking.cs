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

		public void GiveCard(CardType cardType)
		{
			if (cardType == CardType.Yellow)
			{
				this.GiveYellow();
				return;
			}
			if (cardType == CardType.Red)
			{
				this.GiveRed();
				return;
			}
		}

		private void GiveYellow()
		{
			if (this.YellowCards < 2)
			{
				this.YellowCards++;
			}
		}
		private void GiveRed()
		{
			if (this.RedCards < 1)
			{
				this.RedCards++;
			}
		}
	}
}
