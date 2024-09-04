namespace GameStarShips.GamePlayer.Test
{
	using GameStarShips.GamePlayer.Models.PlayerModel;
	using GameStarShips.GamePlayer.Test.Contracts;

	public class TestData : ITestData
	{
		public TestData(int currentEpizode, PlayerStatus playerStatus, bool isLoad)
		{
			this.CurrentEpizode = currentEpizode;
			this.PlayerStatus = playerStatus;
			this.IsLoad = isLoad;
		}

		public int CurrentEpizode { get; set; }

		public PlayerStatus PlayerStatus { get; set; }

		public bool IsLoad { get; private set; }
	}

}
