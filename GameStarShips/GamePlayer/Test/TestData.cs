namespace GameStarShips.GamePlayer.Test
{
	using GameStarShips.GamePlayer.Models.PlayerModel;
	using GameStarShips.GamePlayer.Test.Contracts;

	public class TestData : ITestData
	{
		public TestData(int currentEpizode, PlayerStatus playerStatus, bool isLoad, bool isTest = false, int testRandomChois = 1)
		{
			this.CurrentEpizode = currentEpizode;
			this.PlayerStatus = playerStatus;
			this.IsLoad = isLoad;
			this.IsTest = isTest;
			this.TestRandomChois = testRandomChois;
		}

		public int CurrentEpizode { get; set; }

		public PlayerStatus PlayerStatus { get; set; }

		public bool IsLoad { get; private set; }

		public bool IsTest { get; private set; }

		public int TestRandomChois { get; private set; }
	}

}
