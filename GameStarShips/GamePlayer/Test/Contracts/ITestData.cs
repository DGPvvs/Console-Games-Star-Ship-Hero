namespace GameStarShips.GamePlayer.Test.Contracts
{
	using GameStarShips.GamePlayer.Models.PlayerModel;

	public interface ITestData
	{
		public int CurrentEpizode { get; }

		public PlayerStatus playerStatus { get; }
	}
}
