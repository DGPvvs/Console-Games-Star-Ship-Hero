namespace GameStarShips.GamePlayer.Test
{
	using GameStarShips.GamePlayer.Models.PlayerModel;
	using GameStarShips.GamePlayer.Test.Contracts;

	public class TestData : ITestData
	{
		public TestData(int currentEpizode, PlayerStatus playerStatus)
		{
			this.CurrentEpizode = currentEpizode;
			this.playerStatus = playerStatus;
		}

		public int CurrentEpizode { get; set; }

		public PlayerStatus playerStatus { get; set; }

	}

}
