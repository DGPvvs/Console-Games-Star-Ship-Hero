namespace TestGameStarShips.TestData
{
	using GameStarShips.GamePlayer.Models.PlayerModel;
	using GameStarShips.GamePlayer.Test.Contracts;

	internal class TestData : ITestData
	{
		int currentEpizode;
		PlayerStatus playerStatus;

		public TestData(int currentEpizode, PlayerStatus playerStatus, bool isTest = false, int testRandomChois = 1)
		{
			this.PlayerStatus = playerStatus;
			this.CurrentEpizode = currentEpizode;
			this.IsTest = isTest;
			this.TestRandomChois = testRandomChois;
		}		

		public bool IsLoad => false;

		public int CurrentEpizode
		{
			get => currentEpizode;
			set => currentEpizode = value;
		}

		public PlayerStatus PlayerStatus
		{
			get => playerStatus;
			set => playerStatus = value;
		}

		public bool IsTest { get; private set; }

		public int TestRandomChois {  get; private set; } 
	}
}
