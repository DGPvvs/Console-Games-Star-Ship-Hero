namespace GameStarShips.GamePlayer.Test.Contracts
{
	using GameStarShips.GamePlayer.Models.PlayerModel;

	public interface ITestData
	{
		public int CurrentEpizode { get; }

		public PlayerStatus PlayerStatus { get; }

		public bool IsLoad { get; }

		public bool IsTest {  get; }

		public int TestRandomChois {  get; }
	}
}
