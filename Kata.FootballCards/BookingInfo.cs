namespace Kata.FootballCards
{
	public sealed record BookingInfo(string TeamName, int PlayerNumber, CardType CardType)
	{
		public bool IsTeam(string teamName) => this.TeamName.Equals(teamName, StringComparison.InvariantCultureIgnoreCase);
	}
}
