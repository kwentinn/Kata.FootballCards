namespace Kata.FootballCards
{
	internal sealed record BookingCount
	{
		public CardType CardType { get; }
		public int Count { get; private set; }

		public bool IsSentOff => this.CardType switch
		{
			CardType.Red => this.Count == 1,
			CardType.Yellow => this.Count == 2,
			_ => false
		};

		public BookingCount(CardType cardType)
		{
			CardType = cardType;
			Count = 0;
		}

		public void IncreaseCount()
		{
			switch (this.CardType)
			{
				case CardType.Yellow:
					Count = Math.Min(this.Count + 1, 2);
					break;

				case CardType.Red:
					Count = Math.Min(this.Count + 1, 1);

					break;

				default: break;
			}
		}
	}
}
