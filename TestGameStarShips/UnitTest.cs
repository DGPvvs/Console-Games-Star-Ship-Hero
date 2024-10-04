namespace TestGameStarShips
{
	using GameStarShips;
	using GameStarShips.GamePlayer.Models.PlayerModel;
	using GameStarShips.GamePlayer.Test.Contracts;
	using TestGameStarShips.IO;

	public class Tests
	{
		private Reader read;
		private Writer write;
		private PlayerStatus playerStatus;

		private PlayerStatus SetPlayerStatus()
		{
			PlayerStatus result = new PlayerStatus();
			result.Checksums[1] = 20;
			result.Checksums[2] = 10;
			result.Checksums[3] = 4;
			result.Checksums[4] = 20;
			result.Checksums[5] = 10;
			result.Checksums[6] = 10;
			result.Checksums[7] = 10;
			result.Checksums[8] = 10;
			result.Checksums[9] = 30;

			return result;
		}

		[SetUp]
		public void Setup()
		{
			this.read = new Reader();
			this.write = new Writer();

			this.playerStatus = this.SetPlayerStatus();
		}

		[Test]
		public void TestEpizode1Chois1()
		{
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(1, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = "1";
			game.GameAction();

			string expectedDescription = "������ �� �� �������� � ����� ���������, � �� �� ������� ��������� �� �������� �� ���������� ������. ������������ ������ �� �� ��������, ��������� � �������� ��-�����, �� �� �������� ������ �� �� ��������.\r\n����� �� ��������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode1Chois2()
		{
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(1, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = "2";
			game.GameAction();

			string expectedDescription = "������ �������� � ��� ���� � ���� �� ��������� ����������, ������� ����� ������-����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode1Chois3()
		{
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(1, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = "3";
			game.GameAction();

			string expectedDescription = "��������� �� ���������� � � ����� ������� �������� ��������� �������. ������� ������� �� ����� � ������� ��������� �� ������ ������� �� ���. �������� ����� ���������� ������������� �� �������� � ���� ������� �� ������ ����, ����� ��������� ���������. � ���� ������ ������� ����� �� �� ����� � ����� ����� �� �����������:\r\n� ����������, ���������. ��������� �� �������! ����� �� ��� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode2Chois1()
		{
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(2, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = "1";
			game.GameAction();

			string expectedDescription = "� ��������� ��������� � �������� �� ����� ������� ������� ������� ��������� ����� ���� ����� �������� ����� �����. ��� ���������� �� �� �������� � ��������� ������ � ����, ������ �� ��������� �� �������������� ������ ��� ���������, ��������� ��������� �� ����� ���������� �� �������. ��� �������� ����������� � ��������� ��������, ��������� �� ������ ������� �� ��������� ������� �� ���������. ��� �������� �� ������, ���� ��� ���� �������� �� ��������� � ����������� � ������ ������ �� �� ������ �� ����������� � �������� ���������.\r\n���� ������ ��������� � �������� �� ��������� �������� �������� �������� �� ��������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode3Chois1()
		{
			int currEpizodeId = 3;
			string currentChois = 1.ToString();
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������������� ����� ������������ �� ���������� ������� ������ �� ����� � ���� �� ����� �� ����������� ���������� ������� �� ��������� �������. �� ��������� � ������� ���� �������� �����:\r\n������ � ���������� ������� � ��������� �������. �������: 8/9 �� �������. ������ �� �������: 22 ����. ������ ������ �� ���������� ��. ���� ���������� ��������.\r\n��������� ����� � ������ ������. ���� �� ����������� ��������� � �� 2/5 �� ���������. ������������� �� � ����� ����������� ������ � ��������� �� ���������� �������. �������� � ���������� ����������� ��������������� �������. ���������: ����� 200 000, ����� ��������� � ��������� �������, �������� �� ���������� �� ������������.\r\n���� � ������������ �����, ������ ���� �� �� ��������� ���������� �������-����.\r\n��������� ��������� � ����� ������������ �� �����������. �������� � ���������� �������. ����������� � ��� �������� �� �����������.�\r\n������ ������������ �� ���������� �� ���������� � ��������������� ��������� ������������ �� ���� ������ �������� � ����������.\r\n������: �� �� ������� ������ �� ����� � ��������� ������ � �� �� �������� ������������ �� ������. �� ���������� �� �� �������� �������� � �� �� ������ �������� ������������. �������� ��������� � ��������������. ��������� �� ���� ���������� ������.\r\n����������: ����� �� �����, ��������� �� ����������� �����. �������� �� ������������ �� ��������������� �������� � ��������������� �������������� �� ��� ������ �� ������ ������.\r\n������ � ��������� �� ���������.\r\n������ �� ���������� �����: �������� �� �������: ��������� �� ����� ��������ѓ � ���� �� ��, ��������. ����� �����:        ���� ������� � ����� ���������.\r\n���������� �����: ����� ������; ���� ���������� �� ����������� � �����������; ���� ���������� �� ���������� ����������� � �����������.\r\n���������� ����������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode4Chois1()
		{
			int currEpizodeId = 4;
			string currentChois = 1.ToString();
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ������ ������� ����������! � ��������� ���������. � ������ �� �������� �����!\r\n���� �� ������� ������� ����� ����� ���������� �� ����� ��������. � ������� �� ���������� ��������� ����� �� ��������������, ������� � ���������������� �� �����������, ���� �� ������ � ������, �������������� � ���� �� ��������� �������.\r\n� ��������� ������� ������������ ��������� � ������� ����������. � ����������� ������ �� �����. �������� ���������.\r\n� �������� �� � ������ �� ���������� ��. ���������� �������!\r\n� �������� ������� ������������ ���������. ������� � �����������.\r\n� ��������� ���! ���������, � ����� �������. �������� ������. ���� ���� �������� �������!\r\n� ��������� ������ �� �������� ��?\r\n� ���� ����� �� ���� �� ��������. ��������� �����������.\r\n� ����������� ������� ������������ ���������. ����������� ���������.\r\n� �������� ������� ������! ���������� ������! ����!\r\n����������� ������ ������ �� ������� ���� ������ ��. ������� �� �������� �������� � ��� �����, �� ��������� ����� �������.\r\n� ����� � ��������, ���������! � �������� ���� ����������� �������� ������������, ���� ������� �� �������� �������.\r\n� ���� �� �������������� ��������� � �������� ����������. � �������� ��������. �����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode4Chois2()
		{
			int currEpizodeId = 4;
			string currentChois = 2.ToString();
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ��������� ����������. ������������ �������� ������� � �� �� �������� ������� � ��������� � ��� �� �������� ��� ���� �� ��������.\r\n� ������ �� ��� ���������. ������ ���������� �������� ������� � � ���� ���������� �������� ������ �� ������, ����������: � ������ �� �� �� ������ � ����� �����!\r\n� �������� ������� �� ���������� ���������. �������� � �����������. ��������� � ������� �� ��������. �������� �������� �������.\r\n�������� �� ������ � �������� ���. ���� � ����� �� �������. ���� ���� �� �� ��������� ��� ����������.\r\n� ���� �� �������������� ��������� � ��������� ����������. � �������� ��������. �����!\r\n����� ������ �� �������� ��� �������� � �� ����������� ���� ����� �� �� ������ ����� ������. ���� ���� ����� ����� ����������� �� �������� �� ����������� �� ������. ������ ���������� ���� ������� ����, ��� ��� ��������� � � ����� ���� � ����� ������� ������������ �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(factResult, expectedResult);
		}

		[Test]
		public void TestEpizode4Chois3()
		{
			int currEpizodeId = 4;
			string currentChois = 3.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 0;
			playerStatus.Checksums[6] = 0;
			playerStatus.Checksums[7] = 0;
			playerStatus.Checksums[8] = 0;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� �����������! � ������� ������� ��. � ��������� ���������� �������� � ������ �� ���������.\r\n� ����������� �� ���� � �������� ������� ����������. � �������������� ��������� � ��������. ����� ���������� �� ���������!\r\n� ������ ��������� ������ � �������������� ����! � �������� �� ������ ����� �����, ����� �������� ��-������ � �������� � ��-����.\r\n� ���� �� �� �� ������, ������ �������� ��� ���? � ���� ��� �������� � ����� ������������.\r\n� � ���� ������? � ��������� ��. � �������� ��, � � ��� �� �������� ��������.\r\n� ������������ �� �������� �������� � �������� ����������. � �������� ���������. �������� ������� �� ������.\r\n������ �� ������� ����� � ������ ������ � �������� ���. ���� �� �� ���� �������� �������!\r\n� ���� �� �����������. �������� ���������� ��������.\r\n� ���� �������� �� �������� ���� ������� ����� ����� �������� ����. ��������� �� ������ ��������, ������ ������������ ��������� ��� ��������� � ��������� �������� ��������. � ������ ��� ��������� �� ������ � �����������, ����� ����� ����� � �������� ��������� �� ������� � ��������� ������� ����������� �� ��������. ���� ������� ������� ������� �� ����������� � ������������� ���� �� �������� �������:\r\n� ������� ��������� � �����������. ������ ������� ������� ��������. ��������� ���������� ������. ���������� � ����� �� ���������� �����. ���� ���������� �� �����.\r\n� ������ ������� � ������������ ������� �� ����� �������! � �������� ������� �� ��������.\r\n� �������� �� ������� ��! � ������ �����, ������ ����������� ��� ����� ��. � � ��-����! � �������� � �� ��� ��������� ���������.\r\n���� � �������� ���� �������, ��������� �� ������ ����� ��� ��������� ������ �� ��������� � ���� ���� � ������ ����� �� ����� ����������, ���� �� ��� ��������� �� ����.\r\n���� ����� �������� ������ ��� �� ������������. ��������� � ������� �������� �� ����� �������� �� ����������� ������ ����. ��������� �������� � ��������� ������������ �� ������ ����� � ���� ������ �� �� ������� ���� ��������, ��������� ������ ����. �������� ����� �������� ���� ������, �������� �� ����� �����. ����� ������� � �������, ����� �� �������� �� ���������� � ����� ���������� ��������. ������ � ������ � ����� ��������� � ��������� ������� ����� �����. ��� ��������� ���� ��� ������, ���� ����� �� ������ ������ �����. ���������� ���� ������� �������� ����, �������� �� ����������� ������ �� ������ ����.\r\n� ����, ������� ���� �� �������� � ��������� �������. �������� �� �� ����������� � ���� ���� 15 ��� �� ���������� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 10;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode4Chois4()
		{
			int currEpizodeId = 4;
			string currentChois = 4.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 0;
			playerStatus.Checksums[6] = 0;
			playerStatus.Checksums[7] = 0;
			playerStatus.Checksums[8] = 0;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ������� �� ���������� ���������. ����������� ���������. ��������� � ������� �� ��������. �������� �������� ������� � ������� ����������.\r\n� ���������, ��� ��� �� ����� ������! ��� �� �� ����� ����� � ������! � ����� ����� ������� �����.\r\n� ���� �� ���������� ���������! �������� �����������! � ����� ����� � ����� ������� �� ������� ����. � ������� �� ����� ����������! ������� ����������!\r\n� �������������� ������ �������� � ����������� �������� ����������. � ��������� �����������.\r\n� ������ ����������� � ������� �����! �� �������� �� ����������� ������ � � ������� �������� ��� ����� ��, �����: � ���������� ����� �� ������ � ���������� ������!\r\n� �������� ����������� �� ����������� �� ���� ������ � �������� �� �������� � ��� �� ��������� ������, ������ � ������ � �������. ���� �� ������� ���������� �� ����� ����������, �� �� ���������� ��� �� �� �������.\r\n� ����������� �� � ���������� � ������ � ������� �� ������� �����.\r\n� ��� � ���� ���� �� ������, �� �������.\r\n� ������ ���! � ���� ���������, ���� �� ����� �� �� ������.\r\n����� ����� �� ��������? ��� �� ������� �� ������. ���� �� ������, �� �� �� ��� ����, ����� ������ �� ������� �� � ����� ������� �� ����������� �� ���� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode5Chois1()
		{
			int currEpizodeId = 5;
			string currentChois = 1.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 0;
			playerStatus.Checksums[6] = 0;
			playerStatus.Checksums[7] = 0;
			playerStatus.Checksums[8] = 0;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� � ������ ���������! � ������ ���������, ���� �� ������� �� �� �� �������.\r\n������������ � ������ �� �� ������ �� �������� ��� ���������� ������ ��� ������ �����, ����������� ������� ��� � ���� �� ������ � ����������������, � �������� � ����� �����, ������� ��������� ������ �������. ��������� ����� ������� � �� ���������� ������ � ����� ��������� ������� �� �������� � ������� ������ �������, ����������� �� ������ ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode5Chois2()
		{
			int currEpizodeId = 5;
			string currentChois = 2.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 0;
			playerStatus.Checksums[6] = 0;
			playerStatus.Checksums[7] = 0;
			playerStatus.Checksums[8] = 0;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� � ������� ��������� � ������ ���������, ���� �� ������� �� �� �� �������.\r\n������������ � ������ �� �� ������ �� �������� ��� ���������� ������ ��� ������ �����, ����������� ������� ��� � ���� �� ������ � ����������������, � �������� � ����� �����, ������� ��������� ������ �������. ��������� ����� ������� � �� ���������� ������ � ����� ��������� ������� �� �������� � ������� ������ �������, ����������� �� ������ ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode5Chois3()
		{
			int currEpizodeId = 5;
			string currentChois = 3.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 0;
			playerStatus.Checksums[6] = 0;
			playerStatus.Checksums[7] = 0;
			playerStatus.Checksums[8] = 0;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� � �������� ��� �� ������ �������� ������� � ���� �������� ���� �������� ����� ����� � �������� �����, ������ ����� � ������������������ �� ������, �� ����� ��� ��� ������� ����� �� ������. �������, ��� �� ����� ������ �������, ����������� ��������, ���������� � ���� ����������� �� �������� ���������� �����.\r\n���������� � ��������, ��������� �� �������� ��������� ���� � ���� ���� ���� ������ �����. �������� �������� ����� � ���� �� ������ �� ����� ������� �� ����������� ��� �������������, ������ �� ������� ������ ������ ������� ���������� � ���� �� ������ ���� �����, ����� ������� ����� ����� �� � ������ �������, ��� ����� �� ������.\r\n���������� �� ������ �� ����� �������, �� �� ����� ����� �� �� ��������� � ���, � ������ �� �������� ��� �� �� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode5Chois4()
		{
			int currEpizodeId = 5;
			string currentChois = 4.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 0;
			playerStatus.Checksums[6] = 0;
			playerStatus.Checksums[7] = 0;
			playerStatus.Checksums[8] = 0;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� �� ������� ������ ������� ������� � ������� ������ ������. ��������� � �� ������, �������� ������, ������ �������������� � ������ � ������� ������� ������. ������� ��� ����� ��� ������, �� ��� �� �������� ������� ������� �������������� �������.\r\n�������� �������, �� ����� ��������� �� �������� �� ������, ������������ �� ����� ���������� �� ����������� �� ���������. ���� �� �������� ������� ��������� �� ������� �� ���������� � ���������, ������� ��������� �� �������������.\r\n���� � ���� ��� � �� ������ �� ������� � ����� �� �� ������ �� ������ ��������. � ����� ���� ����� ������ �� ���������, �� ����� ��� ���������� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode6Chois1()
		{
			int currEpizodeId = 6;
			string currentChois = 1.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode7Chois1()
		{
			int currEpizodeId = 7;
			string currentChois = 1.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1] + 20;
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);			

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode8Chois1()
		{
			int currEpizodeId = 8;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = int.Parse(currentChois);

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ��� ������� ������ �� ��������� ��������� ���������� ������, �� ���� ������� �� ������� � ���� ������ ������� ����, �� �������� �� ������� �� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode8Chois2()
		{
			int currEpizodeId = 8;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ��� ������� ������ �� ��������� ��������� ���������� �� ������ � ������� ������ ������� �� ��������� ������� �� �������. ������ ������� ������ ������� � ����� �����������, �� ����������� ��� �� ������� � ����� � �������� � ��������, ������� �� ��������� �� ������� �� ��������. ��-������� ������ �� ������� � ���������� �������. ��������� ������� �� ������� ����������� � ���� ������� �������, ��������� ���������� �� ���������� �� ���������.\r\n� ����������� ������ ���! � �������� ����� ���� �� ��������. � �������� ���� ��������. ����, �������� ���!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode8Chois3()
		{
			int currEpizodeId = 8;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ��� ������� ������ �� ��������� ��������� ���������� �� ������ � ������� �� ������ ����� ��������� ������� �� �������. ������ ������� ������ ������� � ����� ������� � ���������� �, �� ���������� ���� ������������ ������� � ����� �� �������. ���� ���� � ���������� ������������ � ��������� � ��������.\r\n� � ���� ����� ��� ���\r\n� ���������, ������� ������ ��� � ����� ������� � ������ �� ������� �� ��������. � ������� ��, ��� �� �������� ���� ������.\r\n� �������� ����������! � ��������� ��. � �� ������� �� ��������� ������� �� ����������? � ������������ �� ���.\r\n�� ������������ ���������� �� �������� ��������� �������� ����� �������� � ������� �� �� ������� �������� ��������� �� ������� � ������ ������� �� ����������.\r\n� ��� ������� ������� �������, ������� �� �� ������� � ������� ����������� ��, ����� ������������. � �� ����� ������, ��� ��������� ���������� �������, ����� �� �� ������� ������� ����������.\r\n������ �� ������ �� ������ �������. ������������� �� ��������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode9Chois1()
		{
			int currEpizodeId = 9;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ����, ��������� �� �� ���� ��, � �������� �������� �����, ����� �������� ���������� � ���� �������� ������� �� �� ���������. ����� ��� �� �������, ���� �������� ������� �� �������� � ������ ������� �����, �� ��� �� ��������� ���������� ������� �� ���������. ����������� ��� �������� ��������� � ���� ������ ������� ���� �������� �������:\r\n� ��������� ����� ������� �� �����������! ������� � ��������� �������! ������ ����� ����� � ���������� ���� �� �� ������� ��� ������ �� �������! ��������� � ���������� �������! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� ���, ��������� ��� ����� �� �����! � ���������� �������. ������� ������� ������� �� ��������� �� �������, �������� � ������� ���������� � ������������, ����� �� ���� ���������� �� ��������� ������ �� �����. �� ����� �����";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois1()
		{
			int currEpizodeId = 10;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ������� � ���������� ��������������:\r\n���������� ������� � ��� �����, ������������ �� �������� �� ����� �������� ����� �� ������� �� ����� ���. �� ������������ ����������� ������ � �������� ������������ �� �� ������ ���������� � �� ������ � ������������� ������ ��� ������-�������.\r\n�������� � �� �������� ����� ����� �� �������� ������, ��������� �� ����� ��������� � ������������ ��������� �� �������� ������. �������� � ������� � ������� ��������� �� ���, ����� �� ����� � �������� ����� � ����� ������ ���������������, ���� �� ������ ����������.\r\n������������ � �����, ���� ��� ������� �������. ������� �������� ���������� ������ � ��������� ������� �������� ��� ������ �������.\r\n�������� � ��� ������� �� ���������� � ������� �����������. ��� �������������� �� 10 ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois2()
		{
			int currEpizodeId = 10;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������������ � ���������� ��������������:\r\n���� ����������� ������������, ����������� �� �� �������, ��-����� ���� �� ���� ������������ ���� ��� ������� ����. ���������������� �� � �� �������� � �������� ��� ����� ����� ����� �� 12 ������.\r\n������������� �� �������� � ����� �����������. ������ � ������� �� ���� ���������, ���������� ������ � ������ ��������� ����, ����� �� ���������� �� �� ����� ������� ����� ����� �� ��� ����� ��� ���, ���� � �� ����� ��������� ��������.\r\n�������� � ��������� �� 10 �� ����� �� ��������� ��������������� �����, �������� ��� � ����� ���������, ������� ������ �� �������� � �������� ��������� � ������ �������. ���� ������� ����������: 100.\r\n�������� � � ����������� �������, ���������: ������� �������, �������� �������� ������� ������� � ���������� ��������������� ����������. ������������ � ������� � �������� ���������� ������, ����� � ������ �����, ����� � � ����� ������� �� ���������� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois3()
		{
			int currEpizodeId = 10;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������������� � ���������� ��������������:\r\n���������������� � ������, ����� �� ����� ������� ��������� �� �������������. �� ������� �� ���, ��� ������� � �������� �� �����, � ���� �� �������� ���������, ������� �� ��������� ������ ������. ������� ������� � ������� ���������� �� ��������� �������������� ��� ����������� �� ��������� � ����������� ������� ������� �� ������������� �����.\r\n���������� �� ������, ���������������� �� ������ ���������� �������� ����� �� �����������, ���� � �� ����� ����. ����� ����� �� ����� ���� �� �������� ������� �������������� � �������� ������.\r\n�������������� �� �� ���������� ��������� � ����� ����������� �������� � ����� �� ��������� �������� ������, �������� � ����� ������� � �������������� �� 500 ���������.\r\n���� ��������� ���������� � ������.\r\n�������� �� ������: �� 100 �����, � ���������� ������� 65 ��/���.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois4()
		{
			int currEpizodeId = 10;
			string currentChois = 4.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� �������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois5()
		{
			int currEpizodeId = 10;
			string currentChois = 5.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� ���������� ����������.\r\n�������� � ����������� ���������� ���������� � ������������� �� ����������� � ��������� �� ������� ����� � ���� �� �� ���� ����� ������� ����� �� �������� �� ������������� ����������, ���� � �� ����� �� ������ �����.\r\n����������� ���������� ���������� �������: ������� �� ���������� �����������, ������������� ��������������� ����������, ��������� �� ���� �� ������� �������� � ������ ���������, ��������� �� ������� ��������� ����������, ����� � ����� �������� ������� �� ������������ ��. ������ ����� �� ��������� � 145 ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois6()
		{
			int currEpizodeId = 10;
			string currentChois = 6.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ � ��������������:\r\n������� ������������ � ������, ��������� �� ������ �� ������ �������������� �� ��������� ����������������� �������. ��� ������� ���������� ���, �� � � ������ ������������ � ������ �����. ������ �� ������ ���.\r\n�������� ����� � �����������, ������������ ����� � �������� ������. ������������ �� ����������� ������� �� ���� �� ������ � ��������� �� ����������. ���� ������ ������ ������ �� � ����� ����������. ����� ���������� � ����� � ��������� ��� ������ ���������� �����.\r\n�������� �� ����������� ������� � ������� ����� ��� �� �������� ����������� �������. �������� �� ���� ���� ����������� ������� �� ������. ����� ���������� � �������� �� �������� ���������.\r\n���������� ������� � ������� �������� ��������� ����� � �������� � ������������ ������. ����������, ������, �� ����������� ����� � � ����� ������������� ������. ��������� ����, ������������� ���������� �� ���������.\r\n����������� ������ � ��������������� ���������� � ������ ������������ �� ������������, ����������� ���������� � ������������, � ������ ���������� � ��������� ���. ��������, ����� �� ���������� � ������������� �������. ����� �� �� ������������ ��������� ��������.\r\n������ � ���������� ��� ������������� ��, �������� ����� ������������, � ��������� ������������ ������, ������� � ����������. �� ���������� ��� ������ ����� � �� ������������� �� ����������� �� ����.\r\n����� ������� � ������ � ������� ���������� ����. ��������� ����� ������, ��� �� ���������� �������� �����������, �� � ������ � ���� �� ���-������� ����� ��������. ���������� �� �� �������� �� ������������� �� ���������� �� �������� ����� ������ � ��������� ������� � �����. ����� ������������ �����������. ��������� � ���� �� ������� ����������.\r\n \r\n������� ���������� �� ��������:\r\n��������� ������������� � ���� � ������������ ����������, �� ����� �������� ������� 95% �� ������������ �� ����.\r\n���������� ���� � �������� ����������� �������� �� ������ �� ��������. ���������� �� ������� ��� ����������� �������� �� ������� ����, ����� ���� �� ���� ������ �� ����������, ����� �� ����������� �������������.\r\n��������� ������� � �������������� �� ��������, ��������� ������������ �� �� ��������� ���������� � ��������� ���� ��������. ���� � ����� ��������� � �� ���� ������� � ���� ������:\r\n����� ��� � ���������, ����� ������� ������. ������� ������� �� �� ����, ���� ��� �� ������ �����������, ������ ������� �� ����������� ������ � ������� �� ������� ������� �� �� ������ � ���������, ���� �� �� � ����� �����������.\r\n����� � ������������ � ����� �� �������� � ���������, ������ � ���������� �� ��������� ��� �������. ������ �� ���� ������ �� ���� �� 45 �� ��� ����� � 15 �� �� ����� �� ��������.\r\n \r\n�������� �� ������:\r\n����� ��������� � ������� �� ����������� � ���������� �� ������ �� ������������� ������. ������� �� ������ �� ��������� �� ���������� ��������. �� ���������� �� ���������� ��������.\r\n����� ����� � ������� �� ����������� � ����������� �� ���������� ������. ������������� �� ������ �� ��������� �� ���������� � ��������� �� ���������� �� ������. ���� �� ���� ���������� ����� �� ����� ��� � ����� �������. �������� ����� �� ���������� �� ��������� �� �� �������� �� ������������ ������.\r\n������� ������� � ��������� � �� ��������� ��������������� �����. ���� �� ����� ���� ����������� ��������� ��������. �� ��������� � ����� � ��������. ���� �� �������� ������ ���� ������� � �����.\r\n \r\n������� ����������:\r\n������� ���������� � ������������ �� ������� ������� � ���������� ���������� ����.\r\n����� �� ��������� � ����� � ��������� �� ��������� �������� � ���������� �� ��������, ��� �� ���.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois7()
		{
			int currEpizodeId = 10;
			string currentChois = 7.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���������� �� ���������� ����� �� �� ��� � ���� �� �������� � ������� �� �� ������������. � ��������: ���������� �� ���������� ����� �� �� ��� � ���� �� ��������.\r\n� ������ ������ � ���� ������� �� ����� �� ��������, ���� �������� ����� ����������� ��������� � �����.\r\n� ���������� �� ���������� ����� �� �� ��� � ���� �� �������� � ������� ������ �������������. � ��������: ���������� �� ���������� ����� �� �� ��� � ���� �� ��������! �������!\r\n�� ���� �������� � ���������� ���� �� ���� � ���� ���������� �� �������� � ���� �� ������������.\r\n� ����� � �� ���������, ��������� � ����� ������� ��� ������ ����������. � ��� �� � ���������� ����������. ���� 45 ������ ��������� �� ��������� �����. ��������� �� ������ ����� ��� � �� �� ������ �� �������, �������������� ������ ����� ���������, � ������ �� ���������. ����� 15 ��� �� ���������� �� ����������. ������ ������ �� ��� �� ����������, ����� �� �������� ��-�����. ��� �� �� ����� �� ������������ �����, �� ������� ���������� ������� �� �����. �� �� �� ���������� ������� ������ � ��������. ��������� ��? ��� ������� ������������� ���� �� �� ������!\r\n���� �� �������, �������� ���������� �������� ��������� ��� � ���� �����:\r\n� ��������� �� �����, ���������! ������ �� ���� �����! ������ �� � �������. � �� ������������ �������� �� ��������! ��� � ���� ���� � ��� ����� ����� ����. �������� �� � � �������� �� �����������; ��� � � ��-����� ���, �� �������� �� ���������� �� ��.\r\n� ��� �� ��������� � ������� �� ������ � ���������� �� � �����������. � ��� �� ������ ���������� ���������� � �������. ��� �� �������� ���� ������������, ���������� �� ��������� �� �� ������� � ������ ��� ��������.\r\n� ����������, ���������! � ����� �������� ������ ���������. � ����� 30 ������ �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode11Chois1()
		{
			int currEpizodeId = 11;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ���� �� � ����������� ������ ����� ������� � ��������� ���� ��. ��������� �� ������������ �� �������, �� �� ������� �� ���� ��� � � ��������� �� ���� ������. �� ������� �� ���, ����� ��������ѓ �� ����� ���������� �� ���� ���� � � ���-�������� ��������.\r\n������������ �� � ���������� �������, ������ �� ��������� �� ��������� ����� �� �� �������� ����� ������ ����, ����� �� ������ � ��������� �� ������. ������ �������� � ������� �������������� ������������ �� �������� � ���������� �� �������� �� ��������.\r\n������ ������ ������ ����� �������� �� ����������, �� � ���� �� �������� � ���� �� ������������ �� ���������� �� �����, �� �������� �������. ������ � ���������� � �������� ����������� �� ������� ������. ���������� � ������� ������� � �� ������� �� ������� ��������� ����� �� � ����� � ������� ������, ���� ���������� ����������� �� �����.\r\n� ����� �� �� ������ �����! � ������ ������� �� ������������� �� ���������. �� ���� ������ ����� �� � ��������� �������� ��� �����������. ���� �� ������ ���� �� ������� ���������� ���� � �� �� ��������. �������� �� ��-������� ���� �� �������� ��, �������� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode11Chois2()
		{
			int currEpizodeId = 11;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� ����� �������, �������� ��� ���� �� ��������������� ������, �� � �������� ������, ����� ��������� ����� ������, ����� �� ������� � ���� ������� ��� �� ������������. ����������� �������� �� ������� �� �� �������� ���� � ����� �����.\r\n������������ ���� �� ����� � �� ������ ���������, �������� �� ����� ������������� �������, ����, ������������ � ����� ��������. ��� ��������� �� ���� � �������� ����� ����� �� �� ������� ���� ������� ������������ ��� ������� ��������� �����. ��� �� �� ��� ����, ��������� �� �������, ������ ������� ���� � ������������ �� �������� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode12Chois1()
		{
			int currEpizodeId = 12;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2] - 2;
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� �� �������, �� �� �� ��������� ���-����� � ��������������, ������ �� �� ������ ����. ��� �� ������ ��� �������� ������ � ���������� �� ������������. �������� �� �� ������� ����� ������������, ���������� ��������� ������� ����� � ����� ����������� �� ����������, �� ���������� ���� ���������. ����������� � ���� �������� ���� � ���� ����� ������� � ������ � ������� � �����, �� ������� ����� �������� ����������� ����� �� ��� ����.\r\n���������� ���������� �� ���� �������� ��������� � ���� ������ ������ �����������, ����� ������ �� �����. �� ���������, ������ �� �� ������� ������ � �������� �� ���� �� ���. � �������, ������ ��� ������� ��������� ����� ��������� �� ������ ������, � ������ �� ������� ������� ������, ��������� �� ������ ������ ��������������, ������ �� ������� ������� ������. ������ �� ������� ��� ������, �� ��� �� �������� ������� �������������� �������.\r\n���������� ����� �� ������� �� �� �������� � ���� � ���������� ����� �� ��������� �� �� ���������, ���� �� ����� ������� � ���������. ����� ���������� ������� � ����������� �� �������� ������ ������� �����, � ����� ������������ � �� ������� ������ ����� �� ������������ ����� �� ������, � �������� �� ������� ������ � �������. ��� ��� � ���������� ������� ����� �� ������ �� � ������������ ����� �� ���������� � ������ ����� �� ��������� �������.\r\n���� ���� ���������� �������� �� ������� ������� � ����� ������ �� ����� �� ������� �� ����������� �� ������� �������� ��������� ��� ���.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode12Chois2()
		{
			int currEpizodeId = 12;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2] - 2;
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� �� �������� ������ �������� � �������� �������, ������� �� �������� ������ ���� ����� ��������������� ������ �� �������. ���� � �� ������� �� ����� ������������ �������������. ��������� �� �� ����� �� �����, ������ ����.\r\n������ �� �������� �� �����������, �������� �� ����������, ���� ��-����� ���������� ������, ����� ���� ���� ������� �������� ������ �� �� ������ � ������� ��. � ����� ��������ѓ ����� �� ����� ��������, ������� ��� �� ���� �������� � ��������� � ��������� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode13Chois1()
		{
			int currEpizodeId = 13;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� ���������� �� ������� � ����������� �������� ����, �� ����������� �� �������� ������ ��� �����. �������� �� ������ ����� � ������������ �������� � ���� ������� ������� ���� �� ���������, ������:\r\n� ��� �����, ����������� � �������� �� ��� �������! � � ���� �� ���������� ��� ���, �������: � ������ �� �������� ����� ������. ������ � �����, �� ������!\r\n� ���� ��� � ���� � �������� ��� �������. � �� ������� ������, ��� ����� �����!\r\n��� � ���� ����������. �� �� �������� �� � ������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode13Chois2()
		{
			int currEpizodeId = 13;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� �� ��, �� �� �� ������ ����? � ����� ��� �������� ������� �����.\r\n� �� �������! ����� ������? � ���� ���.\r\n������� �� ������� �� ������� � �����������, ���� ������� ������ �� ������� ����� � �������� �� ��������� � ������������ ��������.\r\n� �� ����� �� �������� �� �� ��������? � ����� �����������.\r\n� ���� ������� � �������� ��� � ������� �� �� ������� �� ������. � ���� ������ ���� �������.\r\n���� ������� �������� ������� ������� ���� ����� ����������� ������ � ���� �������� ����, ����� ����. ��������� �� ������ � ����������, ������� �������� �� ������� � ������ �� ����� ������� ��� ������ � ������ �� ����������:\r\n� �������� �� ������ �� ���������� � ��������! �������� �������� � ��������� �������! ����� ����� ������� �� �� ���������!\r\n� ����� ����� ����? � ������� ���� ��������� �� ��� ����������.\r\n���� ���� ������� �������� �� ������� ���������, ������� ������ �������� � ����� ����.\r\n� ���������� �� �� ������ �� ���������������! � ���������� ������ ���������. � ��������� ������� �� �� �������!\r\n���� ����� ������� ����� ������ �����, ������� ����� �������� ����� �������� � ����� ��� �������� ��������� ������� � ���������.\r\n� ������ �������! ��������� �������! � ���� ���������, �� ������ �� ������, �� ������ ���� ����� ������������� �� ������.\r\n� � �� ��� �� ����! � � �������� ��������� ���������� � ���� �� ������� �� ������.\r\n������� ���� ����� � ��� ��������������� ��������� �� ��������� ��������� �� ���������������. ������ � �������� � ����� ������� �����, ����� ����� �� ������� �� ������ ��. ������������ �������� �� ����������� � ���� ���������, �� ������ ���� ���������� ���������. ������ ������������ � ���� �� �������� ��������� �� �������� � �������, �� ����� ���� ���������� �� ������ �������. ������� �� �������� ������ � ������ �� ���� ���, ��������� �� ������������ �� ��������� � �������� ��������. �� ����� ���� ��������� ����� �� ������ ��� ���������� �����, ��� �������� �������� �������; �� ��� �� ������� ������ �������� ����. �� ����������� �� ���� ����������� ������, �������� � ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode14Chois1()
		{
			int currEpizodeId = 14;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ��������� ���������� � ������ �� ������ ���� ������� ���������. � ���� ���� ��� �������. ����� �� ���������� ���������. ����� �� ����� ��������� ��� �������.\r\n����� ������, ��������� ��� ������ �������, �� �������� ��� ��������. ������� ��� ��� � ��������� � ���������� �� ���������. ����� ��� �� ������� �������� �� ���������� �� �������, ������ ���� ����� ������ ����� ����� ���� �� �� ������ ����� � ��������� �� ����������� ���� �������.\r\n� ������ � ����� � ����� � ����� ������ �� �������� ��������. � �������� � �����������\r\n�� ���������� ���� �� ��������� ������ ����� ������ �����, ����� �� ������� � ��������� ���� ������ ��� ����� �����. ������ �������� � ������� ����������� �� ������� � ����������� ���� � ���������� �� �������� ������ �� ��������.\r\n�������� �� ��������� � ����� �� ����� �� �� ������� ���� �� � ����� �� � �������. �������� �� ����� � ���� �� ������ �� ����� �� ������ ����, ������� �� ������ ��������� �� ������ ��.\r\n�� ������� ������ �� �������, ������� �� ���� ����� ��������� � ������������. ��������� � ������� �� �������� �� ����� ���������� � ����������� ����������. ������ �������� �� ������; ���������� ��, ����� �������� ���� �� ��������� � ���� ���������� ��� � ��������� � ������ � �����. ��������� �� ��������� �� ����������� �� ������ ����, � ��������� ����� ��� �������� ���� ���� ������������� ����� ������.\r\n��� ������� ����� �� ��������� ���� ���������� ������, �� ���������� ���������. ������ ��� ��������� �� ������� � �� ������ �� �� ������������ ��� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode15Chois1()
		{
			int currEpizodeId = 15;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������ �������� ��� �����������. ����!\r\n���� �������� ������� ������ �� �������� ��. ������ ����� �� ����������� �� ����� �� ����������� � ����� ���������� ��������� ��������.\r\n� �������� � ����� � �������� ������������. � ��� ������� �� ��������� �� ���������.\r\n� ���������� � ������. �������� � �������������� �����. ��������� ���� ����� �������.\r\n�� ������ �� ������� ��������� �������� � ����������� ������ � �� ������ �� ����� ��� �� �� ���������. ����� �� �������� ���� �� ������ � ����������, �� �� ������� �� ������ �� �������� �� �������� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode15Chois2()
		{
			int currEpizodeId = 15;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������, �� �� ������ �����������! �������! � ����� ��������� ���������. ����� ���� �� �� �������, �� �� ������, ���� ������� ����������� �� ������.\r\n���� �������� ������� ������ �� �������� ��. ������ ����� �� ����������� �� ����� �� ����������� � ����� ���������� ��������� ��������.\r\n� �������� � ����� � �������� ������������. � ����������� � ���������.\r\n������ �������� �� �� ����������, ������, �� ���� � �������� ����. ���� ���������� ������ � ���� � ����� ����� �����. ����� ���� ����� �� ��������� � �������� � ����� ����� ���, ���������� �� ������ ������ �� �����������. ����������� ������ ���� ������� ���� ���� ������� �� ���������. ������� �� ��������� ���� ���, �� ������� �� ������ ��� ����� ������ �� ����������� �� ��.\r\n� ����� �������� ������� ������ � ������������� ���� �� ��������� �� ����� ��� ����������������. � ���� ���� ��� �������.\r\n� ���� ��� �� �� ������ � ������� �� ������ ������������. � ���� �� �� �������!\r\n� ���� � ������������? � ����� �����.\r\n� ��������� �� ��� �����������. ������� � ������ ��� ���. ��� �������, ���������!\r\n����� ������ �� ������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode15Chois3()
		{
			int currEpizodeId = 15;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������ �������� ��� ���������. ����!\r\n���� �������� ������� ������ �� �������� ��. ������ ����� �� ����������� �� ����� �� ����������� � ����� ���������� ��������� ��������.\r\n� �������� � ����� � �������� ������������. � ������������ � ��� ��� � ����� ������� �� �����.\r\n� ���������� � ������, �������� � �������������� �����. ��������� ���� ��� ������� � ������ �� ��� ����������.\r\n� ������ ������� �� ��������� ������! ������� �� ����������! �������� �� �� �������� ��������� �� ���������! � �������� ���������� ��������� � ������� ��� ������, ���������� ���������� ���������. ����� �����!\r\n����������� ������ �� ������ � ���� ���� ��� ��������� � ���������� �� ������� ������ �����. �������� �� �������� ��� �������� � ����� �� ��� �������.\r\n� �������� � ����� � ��������� ������������ ���� �� ���������. � ��������� ����� � �������� ���������. �������\r\n��������� ���� ��������� ����� �� ��������. ������� ����� � ����� �� ������� ����, ����� �� �������� � ������ �� ������. ��� ��� ���� ������ �� ����������� � ���������� �� �������� ����� ����� ������ ����� �� ���������� ������. �������� ����� ���� ��� �� ������ � ���� �� ������ �� ������ �������, �������� ������������ ������, ����� �� ������� �� ����������� ������ � �� �������� �� �������� ���������.\r\n�� � ������ �������� ����� ��� ���������. ������� �� ������ �����������. �, ������ �� � ����� ��������ѓ �� �� ��������, ������� ��� ���������� � ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode16Chois1()
		{
			int currEpizodeId = 16;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode16Chois2()
		{
			int currEpizodeId = 16;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode16Chois3()
		{
			int currEpizodeId = 16;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������, ��������� � �������� ��-��������, ������� ������ ��������� � ������, �� �������� �� ������� ��� ��-�����. ��������� ����� �� ������� �� ���������� ���������. ���� ���� ���, �� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode17Chois1()
		{
			int currEpizodeId = 17;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� �� � ����� � ���������� ����� ������� ������� �� �������� ��������� �������� � �� ������������ ������� �� � ���� �� ��������. ������ ���������� �� ��������� ������� ����� ��� ��-�����, �� �� ���� �� �������� �� ������ ���� � ������� ����� �������� ��������. ��������� �� ���� � ������ � ���� �� ������ � ������ ����������� �� ������������ ������, �� ����� ��������.\r\n� �����, ���������, ���������� �������! � ����� ����� �� �����������. � ����� �� ��� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode18Chois1()
		{
			int currEpizodeId = 18;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 20;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode19Chois1()
		{
			int currEpizodeId = 19;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ��� �������� ������ �� ����� �� ������� �������, �� ������� ������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode19Chois2()
		{
			int currEpizodeId = 19;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ��� �������� ������ �� ����� �� ������� �������, �� ������� ������:\r\n�������� �����. ������ ����������.\r\n��������: ����� ��� �� ����� ����, ����� ��������� ������� ���������� �� ������.\r\n�������� ����� �� ��������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode19Chois3()
		{
			int currEpizodeId = 19;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� �����! ������ ����������.\r\n�������� 1: ����� ��� �� ����� ����, ����� ��������� ������� ���������� �� ������. �������� ����� �� ��������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode20Chois1()
		{
			int currEpizodeId = 20;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������, �� ������������ ��������� � ��-����� �� ����������� ����������� � ��� ��������� �������� ����� �����������.\r\n� ��������� �������� ���� �������� ������. �������� ���������. ������� ����� � � ������� �� ����������!\r\n� � ����, ��������� � ������� �� ����� ��-����� ��� ������������� �� ����������. � ���������� ����� ������ ��� ������ � �� ������ ���������� �� �������������� ����. �������� �� ��� ��������� �����������. �� ��������� �� �����, ������ ����������. �������� � �� �������� ��������� �� ������ �� ������� � �� �������� �������� ������������. ����� ����� �� ������� � ������� �� �������������. �������� ������ �� �������� ���������!\r\n�������� ����� ������� ���������� ������� �������� �� ����������� ��� �������� ������������ ���������� �� �������. �� ��� ���� � ������� ����� �������� � �� ����� ���������; �� ���� ������ ������ �� ������ �������� � �� ������ ��������, �� �� ������ ��� ���� ��� ������� ����. �� ���, �������������� � ������� �� ������� � �������� �� ��������� ���. �������� �� �������� � ��������� � ���� �� ������� �� ���� � ����������������� ������. ������ ������� � �������� � ���������.\r\n� ������ � �����, ���! � ���������� �� �� ��� ���������.\r\n� ������� ����� � ������ �� �������������� ������.\r\n� �������, �� ������ ����� ���������. �� ���� �� ����� ����� �� �������, ���� �� �������� ������ �� �������� ��������� �� ���������.\r\n� ��� � �������� ������� �� ���������� ��������� � �������� ���������� �� ������. � ������ � ����������������� ������� ��� � ����� ������� �� ���������� ���������. �������� �����������.\r\n������� �������� ������ �������; ������ �������� ����� � �� ������ �� �� �������� � �������� � �� �������� ����������� ������.\r\n� ��� ������� �� ���������� ��������� � ���������� �������� ���������. � ����������� � � ������� �����.\r\n�������� ��� � ���� �� ��������, ����� ������������ �� ������.\r\n� ���������� ������� �� ���������� ���������. ����������� � � ������� �����.\r\n���� �������� �������� ������ � � �������� ������� ������� ������ �� ����������� ���������.\r\n� ���� �� �� ��������, ���������? � ���� ������� �����.\r\n� ����� ������������!\r\n���, �� ������� �������� ��� �������. ������ � ������������ �� ������� �� ��������, �� ��� �� ��������� �� ����� � ������ �� ����� ���� �� �������.\r\n� ��������� ������� �� ���������� ���������. ����������� ������ � ��������� �������� ����������. � �������� ���������.\r\n����� �� ������, ��� ���� ���� ������ �� ���������� �� ���������, � ������ �� ������ ���������� �� ������ �������� �������. ���� ����� �� ���� ����������, ������ ������ �� �� ��������� � ���� ��������� � �� �������� �� ����� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode20Chois2()
		{
			int currEpizodeId = 20;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� ����������� ������� � ������������ ���������� �� ����������� ��������� �� ������������ �� ������������� ���� �������. ���� � ���������, ����� ��� ���, �� ������ ������� ������������� �������� �� ���� �� ���-�������� ������������. ����������� �� ��������� ��� ������ �� �������� �������. ����� ����� �� ���� �� �� ������ ���� �����. ����� � ������ ��������� ������� ������� ������������, ����� ���������� � ������������� ��������� ������� ���������� ��������� �� ������������ ������� � ������� ������ ����� �� ������ � ���� ������������.\r\n��� ��� ��������� �� �� �� �������� ������������. ������ �� ���� �� ����� � �������� �� ��������� �������, ���� ���� �� ��������� ����������� �� � ����� ��� ������� �� ��������� � �� �������� �� ���������. ����� ������� ������ ��������� ������� �����������, �� ������ �������� �������� � ������, �� �� ������ �� �� ���������� � ��������. ����� ������, ��������� ��� ��� �� ���� �� ����� �������. ����� � ��� ���, ��������� ������� �� ������� �� ������ ���������. �������� ���� ���-�������� �� ����� � ������ �� �������� �����������. ���� ������������ �� �� ���� �� ����� ������� ��� �� �� �������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode21Chois1()
		{
			int currEpizodeId = 21;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode22Chois1()
		{
			int currEpizodeId = 22;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = 5;
			//expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = 1;
			//expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode23Chois1()
		{
			int currEpizodeId = 23;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ �������� � ��� ���� � ���� �� ��������� ����������, ������� ����� ������-����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode23Chois2()
		{
			int currEpizodeId = 23;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode24Chois1()
		{
			int currEpizodeId = 24;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ����������! � ��������� ������. � �������� �� �� �������� ����������!\r\n� ������������ � ��� ���������. ��������� ������� �� ���� �� �����. �������. ����������� �� ���������� � ���������� � ����������� ������� ����������.\r\n� ������ ��! ������ ��! � ����� ����� ������������. � ������ ��! � � ������� ����: � ����� �����?� �������, ������� � ����������!\r\n� ������� �� ����������: ���� � ������� ���������. � ����������� �������� ��������� �� ���������.\r\n������� ��������� �� �������������� �������� �� ������ � ������� �� ��������� � �������� �� �� �����. ��� ������� ���� ������� �� ������ �� ������� ���������� ����� � �� �� �������, ������ ��������� ������� � ���������� ��������� �� �������� � ������������ ����� ������, ����� �� �������� ����� ����� ���������.\r\n����� ����� ����� ������ ����� ������. ������� ��������� ����� �� ������ ������ � �� ������ � ������� �������� ����.\r\n��������� �� ��������� ���������� �� ���� ����� ������ �����, ����� �������� ���������� �������. ������ ������ ����� �� ������ ��� ������� ��, �� ����� �� �������� ��� ������, �� �� ������� ���������� ������.\r\n�������� �� �������� � ������ �� ���� � �� ������� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode24Chois2()
		{
			int currEpizodeId = 24;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������! ������ �� �� �������� � ���������! � ����� �� �������� �����. � ��-�����!\r\n� ���������� ��� ���, ��������� ������� �� ���� �� �����. ����������.\r\n� �������� �� �� �������� ������!\r\n� ���������, ������� ��! � ���� �������� �������. � ������� �� �!\r\n�������� �� ���������� ��������� ���� ������, ������\r\n� ������ �����, ����� �� ���� �� �����. ���� ���� ����� ������� � ��������� �� ������ �� �������� ��������. ������������ �� �� � ���������, � ������ � ��������� ������ � ����� �������, �������� �� ���������� ��������� ����.\r\n� ������ ������� �� ��������� ������! �����, ���� ���?\r\n� ��� ���������, �� ����� ��� ��������� �� ���������. ��������.\r\n� ������ �����, �� ���� �� �����. ����� �������. ���� ���� ����� �������.\r\n� ����������, ��������� ����! ������ �� �� �������!\r\n� ���������, �� ���� �� �� ����! ��������� �����!\r\n����� ����� ���� ����, ���������� ������� �������:\r\n� ������� �� ���������� ����. ������ �����, �� ���� �� �����. ���� ���� ��� �������.\r\n� ������� �� ����������! ��������! ��������� �������� ��������� �� ���������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode25Chois1()
		{
			int currEpizodeId = 25;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ������ �� �� ��������, ������ �������� � � ���� ������ ��� ������ ���� �� ���������.\r\n� ����� �� �� �������! � ������� ������ �� ������ ��. � ���� ������ �� �� ���������� � ���� ����� ��������������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode25Chois2()
		{
			int currEpizodeId = 25;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���� ������� ��������� �� �� �� ������ � ���� ������� ���������� �������� ��, ������ ���������:\r\n� ��� ��� ��������! ������ � ���! � � ����� ���� ������� �� ������ ��: � ������� ��������, �� ������ ������! � ������� �� �������� �� �������� ��-����� �����, � �� ������ ��.\r\n� �� �� �������! �� �� �����! � � ������ ��������� ���� �� �������. � �������� ��������, �� ��� ������ �� ������ ����������� ���� �� ���������. ���� �������� � ����� ���������� ������ �� �������� ��� ���. ����� �� ������������ �� ��� ������ ��������� �������� �� �� ������ ������� ������, �� �� �������� � ���� �������� � ����, ����� �� ������� ����.\r\n� �� ��� �� ����� � ���� ������� �� ����� ��. � �� ��� �������! ��� ��� � � ���� �������� � ���� ��������, ����� �� ������ �� �� �������� ������.\r\n������ ���� ���� ��������� ����� �� ������� ������� � �� ���� ���������� �������.\r\n� ��� ���? � ���� ���� ��-���������� ������� ��. � ��� ����� ������ � ������� ���. ���� �����?\r\n� ����� � ��������? � �����, ���� �� ������� �� �������� ����� ��.\r\n� ���� � ������ � ������� ������� ��������� �������. � ���� �������? ����� ����? ��? ��� �� ���� ���� ������! � ������ ������ ���.\r\n� �� �� ������ ������ ���� � ��������� �� ���� ��������. � ������ �� ����� �� ���� ����� � ���� ���� ���.\r\n� �� ���� ��� �����! � ����� ��� ���������. � ����?\r\n� �� �� �� �������! � ���� �������� �� �� ������� � ��. � ��� �� ������, ��� �� ����� ������ �� � ������ �� �������� ������������ ����.\r\n� �� ����� �� ����� � ������� ���� ������ ��������� �������� �����. � ��� ���� ��� � ���� ���������� ���������� � ������� ��� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode26Chois1()
		{
			int currEpizodeId = 26;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode27Chois1()
		{
			int currEpizodeId = 27;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode28Chois1()
		{
			int currEpizodeId = 28;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� ���� ����� ������ � ������ � ������ �� �� �������� �� ������ ������� ����� ������� ������ ���� ���������. ����� �������� ���������� ���� �� �� ��� ��� �����. �������� �� �� ������ ��� ���� ������ ������� � ��� �� ��������.\r\n�������������� ���� ���� �� ���� �� �������, �� ����������������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode29Chois1()
		{
			int currEpizodeId = 29;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������ ������� �� �������� � �� ������ ����������������. ����������� �� ��� ������ ������������ ����������, ���� �� ����� ������� ����������� ����������, ����� �� �� ����� �� ����������� � ��� �� ������ � �� ���.\r\n� ����, ��������� ����� � ����������� ������ ���� ��������� �� �����. ��� ���� ������� ������� ���� �� ��������, �� ���� �� ������� �� �� ���������� �� ����� ��� �������� ������������� ����. ����� ���������� ������� � ������� ��������, ������ �� ���� � ���� ����������� ������� �����, ����� ����������� ������ � ��������� ������ ���������� �� ���� ����� ���� �� ���������� �� ���������.\r\n��� ��� ������ � ������������ �� ������� �� ����������� ����������� � � ���� �� ������ ��� ���������� ���� �� ������� ��������� �� ����������� ���. ��������� � � ����� ��������� �����������. ������ ��, �� ���������������� �� � � ��������� �� �� ����� ������� � ���. �������� ���, ������ ���� �� �� �������� �����, �������� � �������� �� �������� ����� ���������� ������.\r\n���� �� ��������� � �������� ������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode29Chois2()
		{
			int currEpizodeId = 29;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� ��������� �� ���������� � ������� �� ��������� ���� �� ������������ �� �������.\r\n����� �� ������ �� ���� �� ������� ���� ��������� 35 ��.\r\n������� �� �������� �� ���� �������� � 12 ��, ��� �� ������ ��������� �������ғ, � 6 �� �� ������������� �������ғ.\r\n����� �� ������� �� � ������� � ������������ ����� ��������, �������� ���� � ���������������, ����� ������������� ����� �� 10 ���, ����� �������, ����� � ������������ ���������� � ������� � ������ � ���� ����� 10 ��.\r\n����� �� ������� ��������, ����� �� ������������ �� ����������� �� ������ ��.\r\n� ����, ����������� ���� ��� ������������ �����������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode30Chois1()
		{
			int currEpizodeId = 30;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �� � ��� ���� � ��������� ��� � ���������� �������� �����, �� �� ���������� ������. ��������� ����� �� ������� �� ���������� ���������. ������� � ���� �����, ������� ������ ���������, �������� �� �� ���� � ���� �������� ��-������� � ������. ������� �� ���� � ��, �������� ������ �� ������� ��������� � �� �� �������� �� ����������� �� ���.\r\n� ���� ����� � ���������, ��������� � ����� ����� �� �����������. � ����� �� ��� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode30Chois2()
		{
			int currEpizodeId = 30;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� � ��� ���� � ����� � ���������� ������ �����, �� �� ���������� ������. ������� ��� ���������, �� �������� �� ���� ������� ��������, ��������� �������, ����� �����, �� �� ������. ������ �� �������� � ������ �� �������� �� ������, ����� ����� �� ����������� �� �������������� ������.\r\n� ���� ����� � ���������, ���������. ����� �� ��� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode30Chois3()
		{
			int currEpizodeId = 30;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �� � ��� ���� � ��������� ��� � ���������� �������� �����, �� �� ���������� ������. ��������� ����� �� ������� �� ���������� ���������. ������� � ���� �����, ������� ������ ���������, �������� �� � � ������� �� ������� ���������. ��������� �������� ���� ����� �� ����� � �������, ��� �� ������� �� ������. ���������� �� ������� � �������� �� ���� ������� ��������, ��������� �������, ����� �����, �� �� ������. ������ �� �������� � ������ �� �������� �� ������, ����� ����� �� ����������� �� �������������� ������.\r\n� ���� ����� � ���������, ���������. ���� �� ������������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode31Chois1()
		{
			int currEpizodeId = 31;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ������ ������� ����������! � ��������� ���������. � ������ �� �������� �����!\r\n���� �� ������� ������� ����� ����� ���������� �� ����� ��������. � ������� �� ���������� ��������� ����� �� ��������������, ������� � ���������������� �� �����������, ���� �� ������ � ������, �������������� � ���� �� ��������� �������.\r\n� ��������� ������� ������������ ��������� � ������� ����������. � ����������� ������ �� �����. �������� ���������.\r\n� �������� �� � ������ �� ���������� ��. ���������� �������!\r\n� �������� ������� ������������ ���������. ������� � �����������.\r\n� ��������� ���! ���������, � ����� �������. �������� ������. ���� ���� �������� �������!\r\n� ��������� ������ �� �������� ��?\r\n� ���� ����� �� ���� �� ��������. ��������� �����������.\r\n� ����������� ������� ������������ ���������. ����������� ���������.\r\n� �������� ������� ������! ���������� ������! ����!\r\n����������� ������ ������ �� ������� ���� ������ ��. ������� �� �������� �������� � ��� �����, �� ��������� ����� �������.\r\n� ����� � ��������, ���������! � �������� ���� ����������� �������� ������������, ���� ������� �� �������� �������.\r\n� ���� �� �������������� ��������� � �������� ����������. � �������� ��������. �����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode31Chois2()
		{
			int currEpizodeId = 31;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ��������� ����������. ������������ �������� ������� � �� �� �������� ������� � ��������� � ��� �� �������� ��� ���� �� ��������.\r\n� ������ �� ��� ���������. ������ ���������� �������� ������� � � ���� ���������� �������� ������ �� ������, ����������: � ������ �� �� �� ������ � ����� �����!\r\n� �������� ������� �� ���������� ���������. �������� � �����������. ��������� � ������� �� ��������. �������� �������� �������.\r\n�������� �� ������ � �������� ���. ���� � ����� �� �������. ���� ���� �� �� ��������� ��� ����������.\r\n� ���� �� �������������� ��������� � ��������� ����������. � �������� ��������. �����!\r\n����� ������ �� �������� ��� �������� � �� ����������� ���� ����� �� �� ������ ����� ������. ���� ���� ����� ����� ����������� �� �������� �� ����������� �� ������. ������ ���������� ���� ������� ����, ��� ��� ��������� � � ����� ���� � ����� ������� ������������ �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode31Chois3()
		{
			int currEpizodeId = 31;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� �����������! � ������� ������� ��. � ��������� ���������� �������� � ������ �� ���������.\r\n� ����������� �� ���� � �������� ������� ����������. � �������������� ��������� � ��������. ����� ���������� �� ���������!\r\n� ������ ��������� ������ � �������������� ����! � �������� �� ������ ����� �����, ����� �������� ��-������ � �������� � ��-����.\r\n� ���� �� �� �� ������, ������ �������� ��� ���? � ���� ��� �������� � ����� ������������.\r\n� � ���� ������? � ��������� ��. � �������� ��, � � ��� �� �������� ��������.\r\n� ������������ �� �������� �������� � �������� ����������. � �������� ���������. �������� ������� �� ������.\r\n������ �� ������� ����� � ������ ������ � �������� ���. ���� �� �� ���� �������� �������!\r\n� ���� �� �����������. �������� ���������� ��������.\r\n� ���� �������� �� �������� ���� ������� ����� ����� �������� ����. ��������� �� ������ ��������, ������ ������������ ��������� ��� ��������� � ��������� �������� ��������. � ������ ��� ��������� �� ������ � �����������, ����� ����� ����� � �������� ��������� �� ������� � ��������� ������� ����������� �� ��������. ���� ������� ������� ������� �� ����������� � ������������� ���� �� �������� �������:\r\n� ������� ��������� � �����������. ������ ������� ������� ��������. ��������� ���������� ������. ���������� � ����� �� ���������� �����. ���� ���������� �� �����.\r\n� ������ ������� � ������������ ������� �� ����� �������! � �������� ������� �� ��������.\r\n� �������� �� ������� ��! � ������ �����, ������ ����������� ��� ����� ��. � � ��-����! � �������� � �� ��� ��������� ���������.\r\n���� � �������� ���� �������, ��������� �� ������ ����� ��� ��������� ������ �� ��������� � ���� ���� � ������ ����� �� ����� ����������, ���� �� ��� ��������� �� ����.\r\n���� ����� �������� ������ ��� �� ������������. ��������� � ������� �������� �� ����� �������� �� ����������� ������ ����. ��������� �������� � ��������� ������������ �� ������ ����� � ���� ������ �� �� ������� ���� ��������, ��������� ������ ����. �������� ����� �������� ���� ������, �������� �� ����� �����. ����� ������� � �������, ����� �� �������� �� ���������� � ����� ���������� ��������. ������ � ������ � ����� ��������� � ��������� ������� ����� �����. ��� ��������� ���� ��� ������, ���� ����� �� ������ ������ �����. ���������� ���� ������� �������� ����, �������� �� ����������� ������ �� ������ ����.\r\n� ����, ������� ���� �� �������� � ��������� �������. �������� �� �� ����������� � ���� ���� 15 ��� �� ���������� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode32Chois1()
		{
			int currEpizodeId = 32;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ��, ��������� ���� � ��������� ��� � ���������� �������� �����, �� �� ���������� ������. ��������� ����� �� ������� �� ���������� ���������. ������� � ���� �����, ������� ������ ���������, �������� �� �� ���� � ������� � ��� ���� ���� ������������ ������� ��������.\r\n� ����� ������ �� �������� �� ����� ���, �������� ��������� �� �����������. ��������� �� ���� � ������ � ���� �� ������ � ������ ����������� �� ������������ ������, �� ����� ��������. ������ �� �������� ��, ����������� � ����������� �������� �������.\r\n� ���� �� ���� �����, ��������� � ����� ����� �� �����������. � ����� �� ��� �����������. ����� ����� �� ����� �� ������ �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode32Chois2()
		{
			int currEpizodeId = 32;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ��, ��������� ���� � ��������� ��� � ���������� �������� �����, �� �� ���������� ������. ��������� ����� �� ������� �� ���������� ���������. ������� � ���� �����, ������� ������ ���������, �������� �� �� ���� � ������� � ��� ���� ���� ������������ ������� ��������. ��������� �� ���� � ������ � ���� �� ������ � ������ ����������� �� ������������ ������, �� ����� ��������. �������� �� ������������� �� ���������� � ����������� �������� �������.\r\n� ���� �� ���� �����, ��������� � ����� ����� �� �����������. � ����� �� ��� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode32Chois3()
		{
			int currEpizodeId = 32;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ��, ��������� ���� � ��������� ��� � ���������� �������� �����, �� �� ���������� ������. ��������� ����� �� ������� �� ���������� ���������. ������� � ���� �����, ������� ������ ���������, �������� �� �� ���� � ���� �������� ��-������� � ������. ������� �� ���� � ��, �������� ������ �� ������� ��������� � �� �� �������� �� ����������� �� ���.\r\n� ���� ����� � ���������, ��������� � ����� ����� �� �����������. � ����� �� ��� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode33Chois1()
		{
			int currEpizodeId = 33;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������ �������� ��� ���������! ����! � ������ ��.\r\n����������� ������ �� ������ � ���� ���� ��� ��������� � ���������� �� ����� ������ �����. �������� �� �������� ��� �������� � ����� �� ��� �������.\r\n� �������� � ����� � ��������� ������������ ���� �� ���������. � ��������� ����� � �������� ���������. �������\r\n��������� ���� ��������� ����� �� ���������. ������� ����� � ����� �� ������� ����, ����� �� �������� � ������ �� ������. ��� ��� ���� ������ �� ����������� � ���������� �� �������� ����� ����� ������ ����� �� ���������� ������. �������� ����� ���� ��� �� ������ � ���� �� ������ �� ������ �������, �������� ������������ ������, ����� �� ������� �� ����������� ������ � �� �������� �� �������� ���������.\r\n�� � ������ �������� ����� ��� ���������. ������� �� ������ �����������.\r\n�, ������ �� � ����� ��������ѓ �� �� ��������, ������� ��� ���������� � ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode33Chois2()
		{
			int currEpizodeId = 33;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ��������, ���� �� ��������! � �����, ���� �� ������� �� ������� �����������. � � ����� ������\r\n� �������� ������� � ����� � ���� ������������ � ������� ���������, ����� ���������� ������ ��������, �� ��������� ������ �� ���������.\r\n� ������� ��������, ���������! � ������� ����� ������� �����.\r\n� ������� ����������� � ������� ��� �������! ��������, ������ �� �������� ��������� �� ���������! �����, ������ �� ��� ������!\r\n� �������� � ������� � ������ �� ����������. � ���������� �� ����� � ����� �������. ���� ���� ����� �������.\r\n� ��������� �� � ��� ������ �� ���������! ��������, ����!\r\n� �� �����, ��������� � ����� ���� ������� ���������� ������� ������������. � �������� � � ������������� ������. ���� ���� �� � ������ ����.\r\n� ������ ������� �� ��������� ������! �����, ���� ���?\r\n� ��� ���������, �� ����� ��� ��������� �� ���������. ��������.\r\n� ������ �����, �� ���� �� �����. ����� �������. ���� ���� ����� �������.\r\n� ���������, �� ���� �� � �������� ������! ��������� �����!\r\n����� ����� ���� ����, ���������� ������� �������:\r\n� ������� �� ����������: ����. ������ �����, �� ���� �� �����. ���� ���� ��� �������.\r\n� ������� �� ����������! ��������! ��������� �������� ��������� �� ���������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode34Chois1()
		{
			int currEpizodeId = 34;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���������� �� �������� ��� ������������ �� �������, ��� ������ ������ �������� � �� ������ � ���������� ������. �� �������� �������� ���� �� � �� ���� ������.\r\n��� ������ ������ ��������, �� ����������� �� ������� ������ �� ������� ����� ��������� ���������� � ���� ������ �����������, ������ � ������������ ������ ����� �� ������� �������, ����������� � � ���� ������� �����. �������, ��� �� ����� �������, ����������� �������� � ���� �� ������ ������ ����������� � ���, ������� �����������, �� ��������� ������ � ����� ��������� �� ������� �� �������.\r\n�� ��������, ����� ����������� ������ � ���� �� �����������. �� ���-����� � �������� �� �������� �� ����� ������ � ����������� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode34Chois2()
		{
			int currEpizodeId = 34;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���������� �� �������� ��� ������������ �� �������, ������� ������ �������� � �� ������� � ���������� ������. �� ��������, �������� ���� �� � �� ���� ������.\r\n��� ������ ������� ��������, �� ����������� �� ������� ������ �� ������� ����� ��������� ����������. ���� ������ �����������, ������ � ������������ �� ������ ����� �� ������� �������, ����� �� ��������� � ���� ������� ����� � ����� ������ ���� �� ������� ��. ��� ����� ���� ������ �������� ���� �� �����������, �� ���� �������, ���� � ������ ���� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode35Chois1()
		{
			int currEpizodeId = 35;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode36Chois1()
		{
			int currEpizodeId = 36;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� �� ���������� �� ������������ �� �������� � � ���� ���� ������� �� ������� �� ������. � ������� ��� �������� �� �������� ������, ����� ��� ���� ��������� �� ����������, ����� �� �� ���������.\r\n� ��������� ���, ���! � ���� ����������� ������� �������. � �� �� ������, �� ����������� �� ������ �������.\r\n� ��������, �������� ������! � ��������� ������ � �� ��������, ���� ��� �� �� �����. � ��������� ��� ��� ������� ����������������� � ��� ����� ������ �� �������� �� ������ � ������� ��������� �� ���������������� �� ��������! ����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode36Chois2()
		{
			int currEpizodeId = 36;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���� ������� ��������� �� �� �� ����� � ���� ������� ���������� ��������, �� ������ ���������:\r\n� ��� ��� ��������! ������ � ���! � � ����� ���� ������� �� ������ ��: � ������� ��������, �� ������ ������! � ������� �� �������� �� �������� ��-����� �����, � �� ������ ��.\r\n� �� �� �������! �� �� �����! � � ������ ��������� �������. � �������� ��������, �� ��� ������ �� ������ ����������� ���� �� ���������. ���� �������� � ����������� �� ������ � ������� ��� ���. ����� �� ����������� �� ��� ������ �������� �������� �� �� ������ ������� ������, �� �� �������� � ���� �������� � ����, ����� �� ������� ����.\r\n� �� ��� �� ����� � ���� ������� �� ����� ��. � �� ��� �������! ��� ��� � � ���� �������� � ���� ��������, ����� �� ������ �� �� �������� ������.\r\n������ ���� ���� ��������� ����� �� ������� ������� � �� ���� ���������� ��-�����. ����� �� �������� ����������� �� ����� ������ �����. ���� ����� ��������� � ������� ������� �� ������� ������� �� �� �������� � �� �� ������� � ������ ��. ���� ������������� ����������� �� ��������� ���-����� ������ �� �������� �� �������� ��� ����������� ������ �� ������������, ����� ���� ����� ��������� � ������� ��.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode37Chois1()
		{
			int currEpizodeId = 37;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� �����!\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode37Chois2()
		{
			int currEpizodeId = 37;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� 2: ������� �� �����������. ������� ������ �� ������: ���� �� ��?� ������� ��� �� ������ �� ����� �� ���� ��������. ������ ������� �� ������: ���� ����, �� � ��������.�\r\n�������: ���������� ������ ����, � ���������� ����� ��������.\r\n���������� �� � ����, �� �� �� �����������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode37Chois3()
		{
			int currEpizodeId = 37;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� 2: ������� �� ���������� ��������� ��������� ��� ������ �� �����, ����� �������� � ����� ��.\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode38Chois1()
		{
			int currEpizodeId = 38;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� ���� ����� ������ � ������ � ������ �� �� �������� �� ������ ������� ����� ������� ������ ���� ���������. ����� �������� ���������� ���� �� �� ��� ��� �����. �������� �� �� ������ ��� ���� ������ ������� � ��� �� ��������.\r\n�������������� ���� ���� �� ���� �� �������, �� ����������������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode39Chois1()
		{
			int currEpizodeId = 39;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������������� ������ ���� ����������, �������� �� ����� ����������� ���� ������� �� ���� ������� ���������� ������� �� �� ��������� � ��������� ������������� ��. �������� ��� �� ������ �� �������� � ����� ����������� �� ������������ ����� ��������� ��������� �������. ������ �� �� ������ � �����, � �����, ��������� ��������� �����. ������� �� �� �����, � ����� ������ ������� � �������� � ���� ������. ���������, ������ ������ �� ��� ��-������� �� ���� ���� �� �������� �������� � ��-����� ����. ���-������� ��������� ����� ������� ��, ������������ � ��� ����� �������� ����� ��� � ��� ������ ��������� ���, ����������� ����, �� ����� �� ������ ����� �� ������ ������, ��� �� �� �������. ������ �� � �����, �������� �����. ����� � ����� �����������, ������ �� ����� �������� � ��� ���� �����, ��������� �� � ����. ����� �� ������, ����� � ����� ��������. ������ �������� �������� �� �������, ��������� ��������� ����, �� ����� �� ������, ������� ������������ �� ��������� �� ����, ������ � ����� � ��������� �������.\r\n��, ������� ��, �� ����� �� � ����, ����� �������� ���������� ��; ����������� � ����� � � ����� ��-������� ��������. ���-����� �� ������� �� �������� ��. �� ���� ������ �������� �� ���������� ���������� ��������, �� ������ � ��������� ��� �������� �� ���������� �� ������ �� ����� ��������������� ���������. ������ ������ �� ���� � ������, � �������� � ��� ����� ������������� �������. �������� ���� �� �������� � ����������� �����, �� � ������������ ����������� �� �������������� ������ �� ��������� ��� ������ ���, ������ ������� ������� ���� � ��� �������� ������ ������� ���� � ��������� � ������ ������ ������ �������.\r\n���-������������ ����� �, �� ������� ������ �����, �������� � ������ ����������, �� ������ ���� �������� ������� �� ������� �� ���������. ������� ������ ��� �� ������ �� �� ������� �������� ������� ����. �����, �� ��-����� ��������� ������������� � ��� ������� �� ������� ������� �� �������� � ������� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode40Chois1()
		{
			int currEpizodeId = 40;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode41Chois1()
		{
			int currEpizodeId = 41;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode42Chois1()
		{
			int currEpizodeId = 42;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ��, ����� �� � �����������, ��������� �� ������ �� ���� � ������ ��. �������� �� �� ������� ����� ������������, ���������� ��������� ������� ����� � ����� ����������� �� ����������, �� ���������� ���� ���������. ����������� � ���� �������� ���� � ���� ����� ������� � ������ � ������� � �����, �� ������� ����� �������� ����������� ����� �� ��� ����. � �������� ��������� � ����������� ���� �������� ������ �� �������� �������� ���������� �� �������.\r\n��������� �� �������, ����� ��������� �� ���, � ������ �� ������� � ����������� ����� �� ������������ ��������� � ����� ����� ���������� � ������ ����, � ���� ���� � ����� ��� ��-������� ��������� � �������� �� ������. ���� ������� ��������� ������� � �������� � ��������� ������. ��������� �� ������� �� ��������� � �� ���������� � ������� �������, ������� �� ������ ���������� ���� �� �����. ��������� ����� �� ������ �� ������� �� �������, ����� �������� �� �������, ���� ���� ������������ �������� ��������� �� �� ����������� � �� �� �� ���������� � �������� �� ����������� �������������, ���������������� � ������ ��-����� ���������.\r\n������ �� ���� ����� ���� � ���������� ����� � ����������� ������������, ����� ������ ������� ���� � ���������. ������� �� ������ �������� ��������� � ������ �������� ����� � �����������, ������������� �� ������� ������ ����, � ���������� � ����� �������� ���������� ��������������� � �������� ������.\r\n����� ������� ������ �� ��������� ��������� ��������� � ����������� � ���� �������������� � ���������� ��������������� ��������, �������� ��� �� ������ ������, ����� ����������� �� ������� ���� ����.\r\n��������� � ����� � �����, �� ���� ��������� ��� �������� ��, ���� �� ��������, ������������ �� ��������� ������� �� ������� � ��������� ����� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode43Chois1()
		{
			int currEpizodeId = 43;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� ���������� �� ����������� ���������� ������� � � ���� ������ �� ���� �� ��������� ��������� ������ ������ �� ������� �������. �������������� ������� �� ����������� ������� � ���������� �� ������� �������. ���� ������ ��������� ���������� �� ������������� ������ �� �� ��������� � ������� �� �� ��������� ������� ����� ������ �� ��������������� ���.\r\n���������� �������� �������� ������� � ��� ������������ ������ � ����� ������� �� �������� ��� �������� ��. ����� ������� ������� ��� ���������� ��������� � ��� �� �������, �� ��������� �� �������� ��� ��������� ��� ���������.\r\n�� ���������, ������� �� ������ �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode43Chois2()
		{
			int currEpizodeId = 43;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� ���������� �� ����������� ���������� ������� � �� ������ �� ���� �� ��������� ��������� ������ ������ �� ������� �������. �������������� ������� ����� �� ����������� ������� � ���������� �� ������� �������. �� ��� ������, � ����� ������ ������������ � �������� ������� �� �� ������ � ������� �� �������. ����� �� ������ �������� �� ������� ������ � ���� ���������� ������� �� ����, ������������� �� ���������.\r\n���� ������ ���������� �� ������� �� ������� ����������. ���� ���� ������� ��� ������� ����, ����������� �� ������ � �� ������� � ������ ��.\r\n�������������� ����� �� �������� �� ������� � ���� ���������� �� ������� ���������� �������� ��, ������ �� ��������� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode43Chois3()
		{
			int currEpizodeId = 43;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� ���������� �� ����������� ���������� ������� � � ���� ������ �� ���� �� ��������� ��������� ������ ������ �� ������� �������. �������������� ������� �� ����������� ������� � ���������� �� ������� �������. ���� ������ �������� ���������� �� ������������� ������ �� �� ��������� � ������� �� �� ��������� ������� ����� ������ �� ��������������� ���.\r\n���������� �������� �������� ������� � ��� ������������ ������ � ����� ������� �� �������� ��� �������� ��. ����� ������� ������� ��� ���������� ��������� � ���� ������ � �� ���� ������, ������ � ����� ������� ����� �� �����. �� ���������� �� ����������� ����������� �� �� �������� ���� �� ���� �� ������� ����.\r\n� ����� � ����? � ������� �������� �� ���� �� ���������.\r\n� ������� ������� � ��� ��������� ������ ����������.\r\n� ����� �� �� ��������� ���. �����, ���� � �� ��������� ��� ��!\r\n���� ������ ���������� �� ������� �� ������� ����������. ���� ���� ������� ��� ������� ����, ����������� �� ������ � �� ������� � ������ ��.\r\n� � ���� �����\r\n� ���������, ������ ��! � ��������� �� ���� �� �����������. � ���� ����� �����.\r\n� ���� ����, ��� ���� ����������� � ������ �������� ��. � ��� �� �� �� ���, ����� �� ������� �� ����.\r\n�������������� ����� �� �������� �� ������� � ���� ���������� �� ������� ���������� �������� ��, ������ �� ��������� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode44Chois1()
		{
			int currEpizodeId = 44;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode45Chois1()
		{
			int currEpizodeId = 45;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode46Chois1()
		{
			int currEpizodeId = 46;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode47Chois1()
		{
			int currEpizodeId = 47;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 20;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode48Chois1()
		{
			int currEpizodeId = 48;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� �����!\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode48Chois2()
		{
			int currEpizodeId = 48;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� 2: ������� �� �����������. ������� ������ �� ������: ���� �� ��?� ������� ��� �� ������ �� ����� �� ���� ��������. ������ ������� �� ������: ���� ����, �� � ��������.�\r\n�������: ���������� ������ ����, � ���������� ����� ��������.\r\n���������� �� � ����, �� �� �� �����������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode48Chois3()
		{
			int currEpizodeId = 48;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� 2: ������� �� ���������� ��������� ��������� ��� ������ �� �����, ����� �������� � ����� ��.\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode49Chois1()
		{
			int currEpizodeId = 49;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode50Chois1()
		{
			int currEpizodeId = 50;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ��� ������� �� �������� � �� ������ ��� ������������, ����� ���� ��������, ������ �������� ������ ��� ��������� � � ���������� ������� �� ���������� ������. ������ � �� �� ���� �� ������������� ��������� �����.\r\n�������� ������ ��� ������� ��������� � ������� ������������ �� ����������� �� ����� �������� � �������� �������������� � ���� �� ���� � ������ � �����, ����� ������������ ��������� ������������ ��.\r\n������ ������� �������� �� ������ ������� �������� � ������� ����������� ����� ������� �� �� ����� ������, �� ������ �� ������ ����� �������. ���� ����� ������������ ���������� � ������� � �� � � ��������� �� ��������� �����������.\r\n������ �� ������� ����� ��� �����������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode50Chois2()
		{
			int currEpizodeId = 50;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� ��������� �� ���������� � ������� �� ��������� ���� �� ������������ �� �������.\r\n����� �� ������ �� ���� �� ������� ���� ��������� 35 ��.\r\n������� �� �������� �� ���� �������� � 12 ��, ��� �� ������ ��������� �������ғ, � 6 �� �� ������������� �������ғ.\r\n����� �� ������� �� � ������� � ������������ ����� ��������, �������� ���� � ���������������, ����� ������������� ����� �� 10 ���, ����� �������, ����� � ������������ ���������� � ������� � ������ � ���� ����� 10 ��.\r\n����� �� ������� ��������, ����� �� ������������ �� ����������� �� ������ ��.\r\n� ����, ����������� ���� ��� ������������ �����������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode51Chois1()
		{
			int currEpizodeId = 51;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ��� �� ��������� �, ���� ������, ������� � ����� ����������� �� ������������ ����� ��������� ��������� �������. ������ �� �� ������ � �����, � ����� ��������� ��������� �����. ������� �� �����, � ����� ������ ������� � �������� � ���� ������. ���������, ������ ������ �� ��� ��-������� �� ���� ���� �� �������� �������� � ��-����� ����. ���-������� ��������� ����� ������� ��, ������������ � ��� ����� �������� ����� ��� � ��� ������ ��������� ���, ����������� ����, �� ����� �� ������ ����� �� ������ ������, ��� �� �� �������. ������ �� � ����� �������� �����, ����� � ����� �����������, ������ �� ����� �������� � ��� ���� �����, ��������� �� � ����, ����� �� ������, ����� � ����� ��������. ������ �������� �������� �� �������, ��������� ��������� ����, �� ����� �� ������, ������� ������������ �� ��������� �� ����, ������ � ����� � ��������� �������.\r\n������ ����������� �������� ��, �� ������ � ����������� ����������� �� ��������. ������� �� ���������� ��������, �� �� ������� ��������� ��������������, ����������� ��� ����� �������� ���� �������� � ������ ����������� � ������������ ����� ���������. �������������� ����� �� ������ ������� �����, �� ���� ���� ��������� �� ����� ���� �� �� ����� �����������. �� ������ �� ������� ���� �� � ���������. ���������� ������������ ���� �� ������������ � ������� ������, �� ��������� �� ���������� �� �� ��������� � �� ������� ��������.\r\n� ������������ � ������ ���� ������� ������. � ����� ���� �� ����� �� ����� ������. � ���������� ���������� �� ������!\r\n������ ���������� ����, �� ����������� �� ��������� ��������� ��� ������, ������� � ������� ����, ����� �� ������� ����� � ���������� ����� ��� ���������. ������������ �� ������� � � ������ �������� � ������� ������ ������. ����� ������� �� ����������� ����� ������� �� ������ � ������� ��������� � ������� ������. � ������� ����� ��� �� �������� ����� ���������� ����� � ������� ��������� ������ �������� ��������� �� ���������. ��� ��� � ��� ������ ������� ����������� �� ���������� � ���������� ��������� ��� � ���� ������� ����� �����, �������� �� ��������. ���� ��� � �� �� ������� ����� �� ������ ��.\r\n����������� ��� ������� �������� ��������, ������ ����� ���� �� ������� ������ ������, ���������� ����� ���, ����� �� � ������������ �����. �� ����� ����� �� ���� ���������� ����, ���� �� �� ������ �� ������ ���� ����� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode52Chois1()
		{
			int currEpizodeId = 52;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ �� ������� ����������� ������ �� ���� �� ������� ����� �� ������� � ����� ������� �� ���� � �����. ������ � ������� ������ � � ������������� ������������ �������, ����������� �� � ������ ����� ����� �������� ��������� ������ �����. ����� � � �� ������� � ������� ��������� �� �������. ��, ������ � ���� ��-����� ����� �������, �������� �� ��������, �� �� ��������� �����������, �� ������ �� �������� �� �����������. ��� �� �� ������� �� ��������� �������� ������ ������� ��� �����. � ������, ���������� �����, ������������ � ���� �� ������ �� ������� �� ���������� �� ��������� ���� ��������.\r\n���� ����� �� ������� ������ ������� ������� � ������� ������ ������. ��������� � �� ������, �������� ������, ������ �������������� � ������ � ������� ������� ������. ������� ��� ����� ��� ������, �� ��� �� �������� ������� ������� �������������� �������. � �������� ������ � ������ ������� �� �������� �� �������� �� ��������� � ����� ������ ����� ��������. ������� �� ��������� �������� ��������� �� ���������� �������� � �������, ����� ����� � ������, �� �������� � ���������� ��, ���� ����� �� ���� ����� � ���� �� ����������� �� ��������.\r\n����� �� ������ �������� �� �� �������� ����� ����� �� ��������� ���������, ������ ���������. ������ �� ������� ��� ���, ����� ����������� ������ � �������� �� ������, �� �� �� �������. ���� ����� �� � ��������, ������ � �������� ������ �� ������ ������� ����� �������, ����������� �� ������� � ���������� ���������. �� ���� �� �������� ���� �� �� ����, �� ������� ������� ������������ � � ���� �� ������ ������������� ����������, �� ������ �� �� �������. ������� � ������� ������ ����� �� ���� �� ���� ������ ������� ����� � �� � ���� ���� �� ��������� ���� ��������� ���. ������� �������� � ������������ ������� � ������. ����� � ���������� ������ � ������� � ����������. �������� �� ������� � �������, �� ����� �� ����������� ����.\r\n� ��������� ���������� �� �� ����������� �� ������� �� �������� � �� ������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode52Chois2()
		{
			int currEpizodeId = 52;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[5] = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� �� ������� ������ ������� ������� � ������� ������ ������. ��������� � �� ������, �������� ������, ������ �������������� � ������ � ������� ������� ������. ������� ��� ����� ��� ������, �� ��� �� �������� ������� ������� �������������� �������.\r\n�������� �������, �� ����� ��������� �� �������� �� ������, ������������ �� ����� ���������� �� ����������� �� ���������. ���� �� �������� ������� ��������� �� ������� �� ���������� � ���������, ������� ��������� �� �������������.\r\n���� � ���� ��� � �� ������ �� ������� � ����� �� �� ������ �� ������ ��������. � ����� ���� ����� ������ �� ���������, �� ����� ��� ���������� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode52PsevdoChois3()
		{
			int currEpizodeId = 52;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[5] = -5;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� ������ ������������� �� ������� ������� �� �������� ����������� � �� �� ������ ������ � ���. ������� � ������ �� ��������� ��������� �� ����� �������, ����� ������� ������ ��. ���� ������� ��������� ���� ��������� ����� ������, �� ������ �� � ��������� � ��� ������ �� �������� � ������.\r\n������� �� ������� ������ ������� ������� � ������� ������ ������. ��������� � �� ������, �������� ������, ������ �������������� � ������ � ������� ������� ������. ������ ������, �� �� ������ ��� ������ � �� ��� �� �������� ������� ������� �������������� �������.\r\n������� ��, ����������� �� ����� ���������� ��� ������������ �� ������� �� �������, �� ��������� ������� ����� ������� �� �� ������ � ����������. � ������� �� ������� ���� �� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode52Chois3()
		{
			int currEpizodeId = 52;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� ������ ������������� �� ������� ������� �� �������� ����������� � �� �� ������ ������ � ���. ������� � ������ �� ��������� ��������� �� ����� �������, ����� ������� ������ ��. ���� ������� ��������� ���� ��������� ����� ������, �� ������ �� � ��������� � ��� ������ �� �������� � ������.\r\n������� �� ������� ������ ������� ������� � ������� ������ ������. ��������� � �� ������, �������� ������, ������ �������������� � ������ � ������� ������� ������. ������ ������, �� �� ������ ��� ������ � �� ��� �� �������� ������� ������� �������������� �������.\r\n������� ��, ����������� �� ����� ���������� ��� ������������ �� ������� �� �������, �� ��������� ������� ����� ������� �� �� ������ � ����������. � ������� �� ������� ���� �� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode53Chois1()
		{
			int currEpizodeId = 53;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 20;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode54Chois1()
		{
			int currEpizodeId = 54;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode55Chois1()
		{
			int currEpizodeId = 55;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 1;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ������ ������� ����������! � ��������� ���������. � ������ �� �������� �����!\r\n���� �� ������� ������� ����� ����� ���������� �� ����� ��������. � ������� �� ���������� ��������� ����� �� ��������������, ������� � ���������������� �� �����������, ���� �� ������ � ������, �������������� � ���� �� ��������� �������.\r\n� ��������� ������� ������������ ��������� � ������� ����������. � ����������� ������ �� �����. �������� ���������.\r\n� �������� �� � ������ �� ���������� ��. ���������� �������!\r\n� �������� ������� ������������ ���������. ������� � �����������.\r\n� ��������� ���! ���������, � ����� �������. �������� ������. ���� ���� �������� �������!\r\n� ��������� ������ �� �������� ��?\r\n� ���� ����� �� ���� �� ��������. ��������� �����������.\r\n� ����������� ������� ������������ ���������. ����������� ���������.\r\n� �������� ������� ������! ���������� ������! ����!\r\n����������� ������ ������ �� ������� ���� ������ ��. ������� �� �������� �������� � ��� �����, �� ��������� ����� �������.\r\n� ����� � ��������, ���������! � �������� ���� ����������� �������� ������������, ���� ������� �� �������� �������.\r\n� ���� �� �������������� ��������� � �������� ����������. � �������� ��������. �����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode55Chois2()
		{
			int currEpizodeId = 55;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 1;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���� ������� ��������� �� �� �� ������ � ���� ������� ���������� �������� ��, ������ ���������:\r\n� ��� ��� ��������! ������ � ���! � � ����� ���� ������� �� ������ ��: � ������� ��������, �� ������ ������! � ������� �� �������� �� �������� ��-����� �����, � �� ������ ��.\r\n� �� �� �������! �� �� �����! � � ������ ��������� ���� �� �������. � �������� ��������, �� ��� ������ �� ������ ����������� ���� �� ���������. ���� �������� � ����� ���������� ������ �� �������� ��� ���. ����� �� ������������ �� ��� ������ ��������� �������� �� �� ������ ������� ������, �� �� �������� � ���� �������� � ����, ����� �� ������� ����.\r\n� �� ��� �� ����� � ���� ������� �� ����� ��. � �� ��� �������! ��� ��� � � ���� �������� � ���� ��������, ����� �� ������ �� �� �������� ������.\r\n������ ���� ���� ��������� ����� �� ������� ������� � �� ���� ���������� �������.\r\n� ��� ���? � ���� ���� ��-���������� ������� ��. � ��� ����� ������ � ������� ���. ���� �����?\r\n� ����� � ��������? � �����, ���� �� ������� �� �������� ����� ��.\r\n� ���� � ������ � ������� ������� ��������� �������. � ���� �������? ����� ����? ��? ��� �� ���� ���� ������! � ������ ������ ���.\r\n� �� �� ������ ������ ���� � ��������� �� ���� ��������. � ������ �� ����� �� ���� ����� � ���� ���� ���.\r\n� �� ���� ��� �����! � ����� ��� ���������. � ����?\r\n� �� �� �� �������! � ���� �������� �� �� ������� � ��. � ��� �� ������, ��� �� ����� ������ �� � ������ �� �������� ������������ ����.\r\n� �� ����� �� ����� � ������� ���� ������ ��������� �������� �����. � ��� ���� ��� � ���� ���������� ���������� � ������� ��� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode56PsevdoChois1()
		{
			int currEpizodeId = 56;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[6] = 20;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� �� ���������� �� ��������� � ������������ �� ������������ � ���������, �� �������� ������ �� ������ � ����� ���� �������� �� ����� ���������� ������ �� �� �������� ������������ �� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode56PsevdoChois2()
		{
			int currEpizodeId = 56;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[6] = 19;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� �� ������ �� ��������! � �������� �� �����������. � ����� ��� �� ������! �� �� ������� �������� � �� ����������!\r\n� ��� � ������ �� �������� ������� ������� ������ �� ������� ��� ���� �������, ������ � ���� � ��� �������. �� ����� ��������� � ����������� �� ���� ������ ����������, �� �� ������ �� �� ��������� ��� � ����������. ������� ������ �� ������������ �� ��������, ������� ������ �� �������� � ��������� ���������. �� ����� ��������� �� ��������� ��������� �� ��������� ����� ������������ ������������ ������� � �������, ����� � ����� ��� � ����������� � ����� ����, ���. ����� ������, ���� ������ ������ �� � ���� ����� ���� �� ������� ��.\r\n������ �� � ����� ��������ѓ �� �������, ������� ��� �� ������ �� �������� � ��������� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode57Chois1()
		{
			int currEpizodeId = 57;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ����������� ���� ������� � ���� � ����� �� ����� ���� �� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode58Chois1()
		{
			int currEpizodeId = 58;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ �� �� �������� � ����� ���������, � �� �� ������� ��������� �� �������� �� ���������� ������. ������������ ������ �� �� ��������, ��������� � �������� ��-�����, �� �� �������� ������ �� �� ��������.\r\n����� �� ��������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode58Chois2()
		{
			int currEpizodeId = 58;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ��� �� ������ �� ������� ������ ��������� � �� ������ ����� �� �������� ��������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode59Chois1()
		{
			int currEpizodeId = 59;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode60Chois1()
		{
			int currEpizodeId = 60;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������� ����������, ��������� � �������� ������. ���� �� ����� �� ������� ���������������� � �� �� �������� ��� �������� �� �������� ������������, ������ ������ ������ ������ �� ���������.\r\n� �������� ��������� �� � ��������� ��������� ���������� �� ��������. � ����� ������������ ��.\r\n� ���, ���������� �� �����! � ������ �������. � ������ ����������!\r\n�����: ������������� ������ ������!\r\n�����: �������� �� ������ �� ���� �� ������� �� ����������! ��� ����� �����, ����� �� �� ������, ���� �� �� ������, �� �� ����� �� �� ����!\r\n�����: ������� ���� � ����������������. �� �� ������� ������� ����� ������!\r\n���� �.\r\n� �� ���� ���������. ����� ����������� �����, � ����� �� �������.\r\n���� ���� ��� ���� ������ � ������: ������� �� ������������� �� ��������; ������� �� ����������, ���� �������� � �������; ����������� ������� �� �������� � ��������. ����� �� ����������� �� ��������� �������� ������������ � ������ ��������� ��������� ����� �� �������� ���������, ��������� ���������, ����� �� �����, ����� �� ��������� �������� ���� �� ������� ��.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode60Chois2()
		{
			int currEpizodeId = 60;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������� ���������� ������, ��������� � ��������, ������ ������������� �� ��������� �� �������, �� ���������� �� �������� � ����� �� �������.\r\n� ��������! ��������� ��������! � ����� �� �������� ��� � ����������� �� ��������������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode61Chois1()
		{
			int currEpizodeId = 61;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ��������� ���������� � ������ �� ������ ���� ������� ���������. � ���� ���� ��� �������. ����� �� ���������� ���������. ����� �� ����� ��������� ��� �������.\r\n����� ������, ��������� ��� ������ �������, �� �������� ��� ��������. ������� ��� ��� � ��������� � ���������� �� ���������. ����� ��� �� ������� �������� �� ���������� �� �������, ������ ���� ����� ������ ����� ����� ���� �� �� ������ ����� � ��������� �� ����������� ���� �������.\r\n� ������ � ����� � ����� � ����� ������ �� �������� ��������. � �������� � �����������\r\n�� ���������� ���� �� ��������� ������ ����� ������ �����, ����� �� ������� � ��������� ���� ������ ��� ����� �����. ������ �������� � ������� ����������� �� ������� � ����������� ���� � ���������� �� �������� ������ �� ��������.\r\n�������� �� ��������� � ����� �� ����� �� �� ������� ���� �� � ����� �� � �������. �������� �� ����� � ���� �� ������ �� ����� �� ������ ����, ������� �� ������ ��������� �� ������ ��.\r\n�� ������� ������ �� �������, ������� �� ���� ����� ��������� � ������������. ��������� � ������� �� �������� �� ����� ���������� � ����������� ����������. ������ �������� �� ������; ���������� ��, ����� �������� ���� �� ��������� � ���� ���������� ��� � ��������� � ������ � �����. ��������� �� ��������� �� ����������� �� ������ ����, � ��������� ����� ��� �������� ���� ���� ������������� ����� ������.\r\n��� ������� ����� �� ��������� ���� ���������� ������, �� ���������� ���������. ������ ��� ��������� �� ������� � �� ������ �� �� ������������ ��� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode62PsevdoChois1()
		{
			int currEpizodeId = 62;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 14;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����� ����, ���������, �� ��� ���������� ������� � ������� ����� ���������. � �������� �� �� �������� ������� ������, �� ���� �� ������ ��� �� ���������. �, ���� �, �������� ���!\r\n��������, ������� � ��� �� ��������� ������, �� �������� � ������ ��. ������� ��, �� ������ � ������� ���������� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode62PsevdoChois2()
		{
			int currEpizodeId = 62;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 15;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���� ������� ��? � ���������, ��������, � ����� �����������. � ������ �� �� ������� ������� �� ������������� ������. �� ����, �� ����. ����������� ������� � 20, � ���� ���� �������� ��������. ��� ������ ���������, �� �� ������� ��?\r\n������ ����� �� ������ �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode62PsevdoChois3_1()
		{
			int currEpizodeId = 62;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 16;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode62PsevdoChois3_2()
		{
			int currEpizodeId = 62;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 20;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode62PsevdoChois3_3()
		{
			int currEpizodeId = 62;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 21;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode63Chois1()
		{
			int currEpizodeId = 63;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������� ��� �� ����� ����� � ������������ �� ������������� ������ �������. ���������� ����������� ���� �� ������ �� �� �������� ��� ��-������� � �������. ������ ������� �� �� ��������� ������� ���� ����� ��� ��� ���, ������� ��, ��� ������� �� �������� ����������� �����, � �� ���� �� �������� �� �������� ����� �� �����������, ������ ������� ���������, �������� ����� � ����� ������� �������.\r\n� �������, ������ �������� ������� �������� ������� ����������� �� �� ���� �� ��������� �� ����� �����, ��� ����� �������� �� ��������� �� ��������� �� ������ ����� ������� �������, �������� ��� ���� �� ���������� ������. ������� ��, ������� ���������� ����� �� ���� �� �������� ���� �� ����� ��������ѓ � �������� ������ �� ������� ��������. ���� ������� � �������� �� ������� �� �������� �������.\r\n� ��������! ��������� ��! � ��������� �����. � �������� �� ������� �� � �� ��������� �� ����� ������! � � ������� ��� �� �������� ��� ������� ������ �� ������� � ������������ ������ �����.\r\n���� �� ������� ���� ������ ����� ��� ����� ��������. �������� � ������� �����, ������ �� ����� ��������, �� �� �� �������, �� ������ �� ������. ��� ��� ����������� �������� ����� �� ���������� ��-����� � ��-����� �� ��� � ���������. ���� �� ��� ����� �� ��� �� ������� ������, ������� ������������ ������ � ��������� ������� �� ���� ������. ������������ � ����� � ������ ����� ������� ����� � ��������, �� �� ������� �� ��������. �� ����, � � �� ������ ��������, ���������� ����� � ������� �� ������, ������ �� �� �����, ���� ������ �� ������� � ���� � ������� ��. � ������� ��� ����������, �� �� �� �������� ��-����� � ���� ����� �� �������.\r\n����� �� ��������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode63Chois2()
		{
			int currEpizodeId = 63;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode64Chois1()
		{
			int currEpizodeId = 64;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� �������� ������ ��� �� ������������. ��������� � ������� �������� �� ����� �������� �� ����������� ������ ����. ��������� �������� � ��������� ������������ �� ������ ����� � ���� ������ �� �� ������� ���� ��������, ��������� ������ ����. �������� ����� �������� ���� ������, �������� �� ����� �����. ����� ������� � �������, ����� �� �������� �� ���������� � ����� ���������� ��������. ������ � ������ � ����� ��������� � ��������� ������� ����� �����. ��� ��������� ���� ��� ������, ���� ����� �� ������ ������ �����. ���������� ���� ������� �������� ����, �������� �� ����������� ������ �� ������ ����.\r\n� ��� �� ��������! � ������ �� �����. ������ �� ��������� ������������ �� ���� �� ���������, ��, ������� ��, ����� �� � �������.\r\n� �����, �� � ��-������� �� ���������� �� ����� � ������� �� �������� ��������� � �������� ������� �� ������ �� ���� � ������� �� �������������� ��������, ���������� � ���� �� ����� �� ������� ����������.\r\n������� ������ �� �� �������� � ���� �� �������� �� ������� ��, ������� ������������� ���������. ������� �� ������� � ��������� ������� ������ � ���� �������� �� ������. ���������� �� �� ���������� ���������� ����� �� ��������������� �������� � ��� �� ��������� ���� �� ��������.\r\n� ��������� ������� ���� ����������! � �������� ������. � ��� ���� ��� �������� ��� � �������, ���� �������� ��� �������� ������� ������ ����� ������.\r\n� �����, ������ �� ������������! �������, ��������� ������ �� ������ �������!\r\n����� ����� ������������ ������� ���� ���������� ������. ����� �� �������� � ���������� �� �� ��������� ������, ���� �� ������ ������� ����� ���� � �� ������� ��� ������� �����.\r\n� ��� � �����������? � ����� �����������, ����� �� ������� ������, ��������� ��� ����������, � ������� �� �������� �� ������ �� ������� �����.\r\n� ����. ��������� ������� � �����. ���������� � �� ����� ���������� ��������� �����. �������� ���� � ����� � ���� �� �������, �������� ����������� � ����� �������� � ��� �������, ��� ������ ����� ���������.\r\n� ��������� � ���������� ������ �� ��������. � �������� �������� �� ������� ������ �������. ����� ���������� �� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode65Chois1()
		{
			int currEpizodeId = 65;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode65Chois2()
		{
			int currEpizodeId = 65;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �� �� ������, ��� � ��������� �����. � �������� �� ������� � ����� ����������.\r\n� �����, �����, ���� �� ������� � ��������� �� ���������. � ��� ��� ������ �� �������� ��� ���� ����. ����� �� ��������� � ������ ��� LT12.324/q.\r\n���������� ��������� � �� ������� �� ������� ������:\r\n��������� ���� ��� ������ �������� � ��������������.\r\n��� ���� ���� ������� �� �� ��������, ���������� �������:\r\n������: �� �� ��������� � ��������� ��������, ������ ��������.\r\n��������������: ������� �������.\r\n�������: ����� ��� ������� 65 ��/�, ����� �����������.\r\n�������� ��������� ������:\r\n������ �� ������� ���� ������, ����� ������ �� ���-���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode66Chois1()
		{
			int currEpizodeId = 66;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 1;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3] - 1;
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������� ��� �� ����� ����� � ������������ �� ������������� ������ �������. ���������� ����������� ���� �� ������ �� �� �������� ��� ��-������� � �������. ������ ������� �� �� ��������� ������� ���� ����� ��� ��� ���, ������� ��, ��� ������� �� �������� ����������� �����, � �� ���� �� �������� �� �������� ����� �� �����������, ������ ������� ���������, �������� ����� � ����� ������� �������.\r\n� �������, ������ �������� ������� �������� ������� ����������� �� �� ���� �� ��������� �� ����� �����, ��� ����� �������� �� ��������� �� ��������� �� ������ ����� ������� �������, �������� ��� ���� �� ���������� ������. ������� ��, ������� ���������� ����� �� ���� �� �������� ���� �� ����� ��������ѓ � �������� ������ �� ������� ��������. ���� ������� � �������� �� ������� �� �������� �������.\r\n� ��������! ��������� ��! � ��������� �����. � �������� �� ������� �� � �� ��������� �� ����� ������! � � ������� ��� �� �������� ��� ������� ������ �� ������� � ������������ ������ �����.\r\n���� �� ������� ���� ������ ����� ��� ����� ��������. �������� � ������� �����, ������ �� ����� ��������, �� �� �� �������, �� ������ �� ������. ��� ��� ����������� �������� ����� �� ���������� ��-����� � ��-����� �� ��� � ���������. ���� �� ��� ����� �� ��� �� ������� ������, ������� ������������ ������ � ��������� ������� �� ���� ������. ������������ � ����� � ������ ����� ������� ����� � ��������, �� �� ������� �� ��������. �� ����, � � �� ������ ��������, ���������� ����� � ������� �� ������, ������ �� �� �����, ���� ������ �� ������� � ���� � ������� ��. � ������� ��� ����������, �� �� �� �������� ��-����� � ���� ����� �� �������.\r\n����� �� ��������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode67Chois1()
		{
			int currEpizodeId = 67;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode68Chois1()
		{
			int currEpizodeId = 68;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������������� ������ ���� ����������, �������� �� ����� ����������� ���� ������� �� ���� ������� ���������� ������� �� �� ��������� � ��������� ������������� ��. �������� ��� �� ������ �� �������� � ����� ����������� �� ������������ ����� ��������� ��������� �������. ������ �� �� ������ � �����, � �����, ��������� ��������� �����. ������� �� �� �����, � ����� ������ ������� � �������� � ���� ������. ���������, ������ ������ �� ��� ��-������� �� ���� ���� �� �������� �������� � ��-����� ����. ���-������� ��������� ����� ������� ��, ������������ � ��� ����� �������� ����� ��� � ��� ������ ��������� ���, ����������� ����, �� ����� �� ������ ����� �� ������ ������, ��� �� �� �������. ������ �� � �����, �������� �����. ����� � ����� �����������, ������ �� ����� �������� � ��� ���� �����, ��������� �� � ����. ����� �� ������, ����� � ����� ��������. ������ �������� �������� �� �������, ��������� ��������� ����, �� ����� �� ������, ������� ������������ �� ��������� �� ����, ������ � ����� � ��������� �������.\r\n��, ������� ��, �� ����� �� � ����, ����� �������� ���������� ��; ����������� � ����� � � ����� ��-������� ��������. ���-����� �� ������� �� �������� ��. �� ���� ������ �������� �� ���������� ���������� ��������, �� ������ � ��������� ��� �������� �� ���������� �� ������ �� ����� ��������������� ���������. ������ ������ �� ���� � ������, � �������� � ��� ����� ������������� �������. �������� ���� �� �������� � ����������� �����, �� � ������������ ����������� �� �������������� ������ �� ��������� ��� ������ ���, ������ ������� ������� ���� � ��� �������� ������ ������� ���� � ��������� � ������ ������ ������ �������.\r\n���-������������ ����� �, �� ������� ������ �����, �������� � ������ ����������, �� ������ ���� �������� ������� �� ������� �� ���������. ������� ������ ��� �� ������ �� �� ������� �������� ������� ����. �����, �� ��-����� ��������� ������������� � ��� ������� �� ������� ������� �� �������� � ������� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode68Chois2()
		{
			int currEpizodeId = 68;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode69Chois1()
		{
			int currEpizodeId = 69;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode70Chois1()
		{
			int currEpizodeId = 70;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� �����.\r\n��� �� ��� � ����������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode70Chois2()
		{
			int currEpizodeId = 70;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �����.\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode71Chois1()
		{
			int currEpizodeId = 71;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �� �� ������ ��-�����! � ������ � ���� ������, ������ ���������. � �� ����� ������! � �������� ���� �� �����������.\r\n������ ������� ���� ���������� �� ��������� ���� �������. ���������� �� ������������ �����, ������������� �� ������� � ������ � �� ������������� ����� �� ������ ����� ���������, � ����� ������� �������� �� ����������� ������ ���� � �����. ����� ���� ���� ������, �������� �������� ��������� ���� ��-������ �� ���������� ������� ������� ����� � ������� ������ � ������� ��� �� ������� � ����� ���� �����. ���� �� ������� ������� ������ �� ������� � ������� ��������� �� ������ ��� �� �����.\r\n� ���� �������! ����� ��! � ����� �� ��������� �� �� �� ������� ����������. � �� ����� ���� �� �� ��������.\r\n��� �� ������ �� �� �������, �� � ��������� ������ �� ����� � �� ������ � ��� ���� ����� � �������.\r\n� �� ������! ���� �� �� ��������! � ������ ���������� �� ������ �� �� �������. � �������� ������� ����! �����!\r\n� ���������, ��������! ���, ����� ��-������! � ���� �������� ����� � ������� ������ ������ �� ������� �������� ����������.\r\n������������ �������� �� ��������� ������� �������� ���� ��� ��������� ������. �� ��������� �� ������� ����� ������� ������������ ��������� ���� � ��� �� ������ �������� �� ���������� � ��� ����, ������� � ������������� �� ������ ����� ��������������� �� ����������. � ��� � ������������ �������� �� �������� �������. ���� �������� � ���� ����� ��, ������������ ������������ � � ������� ����� ���������� ������������ ����. ����������� ������ � � ��������� ����� ��������� ��������� ������� ������� ������������ �������� ����.\r\n�� �������� ��������� ������� � �������. ������, ���������� � ���������, �� �������� � ���� ��� ������ �� ���������, ������ � ����� �������� ������� ����� ������ �� ������� � ������ ����� ��� � ����� ��������� ���������� ��� � ��������� �� ������� ��.\r\n� ����, ������� �� � ������� ���������� �� ��������� �� �� ���������� �����������. � ��������� �� � ������.\r\n� ����, ������� �� �� ������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode71Chois2()
		{
			int currEpizodeId = 71;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ��! �������! � ��������� ����� � ���� ������������ ��� ������� ������ ��������, �� ����������, ��������� �� ���������� ���������.\r\n� � ���� ����� �� ������������� ������ �������������� �� ��������� ������ ����. ������������ �� � ������� �� ������, �� � ������� � ������ ��������� ������� ������������� �� ���� �� �� ������. ������������ ��������, �� � ������ ����, � ���������� �� �������, �� � ���� ������� �������. ������ �� ����� �����������, �� ������� �� ��� �������. ��� ��������������� ��� �� ���������� ������� ����� ������, ����� �� ������ ��������� ������� ����� � ����� � ������ ���� �� ������� ��.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode72Chois1()
		{
			int currEpizodeId = 72;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ��, ����� �� � �����������, ��������� �� ������ �� ���� � ������ ��. �������� �� �� ������� ����� ������������, ���������� ��������� ������� ����� � ����� ����������� �� ����������, �� ���������� ���� ���������. ����������� � ���� �������� ���� � ���� ����� ������� � ������ � ������� � �����, �� ������� ����� �������� ����������� ����� �� ��� ����. � �������� ��������� � ����������� ���� �������� ������ �� �������� �������� ���������� �� �������.\r\n��������� �� �������, ����� ��������� �� ���, � ������ �� ������� � ����������� ����� �� ������������ ��������� � ����� ����� ���������� � ������ ����, � ���� ���� � ����� ��� ��-������� ��������� � �������� �� ������. ���� ������� ��������� ������� � �������� � ��������� ������. ��������� �� ������� �� ��������� � �� ���������� � ������� �������, ������� �� ������ ���������� ���� �� �����. ��������� ����� �� ������ �� ������� �� �������, ����� �������� �� �������, ���� ���� ������������ �������� ��������� �� �� ����������� � �� �� �� ���������� � �������� �� ����������� �������������, ���������������� � ������ ��-����� ���������.\r\n������ �� ���� ����� ���� � ���������� ����� � ����������� ������������, ����� ������ ������� ���� � ���������. ������� �� ������ �������� ��������� � ������ �������� ����� � �����������, ������������� �� ������� ������ ����, � ���������� � ����� �������� ���������� ��������������� � �������� ������.\r\n����� ������� ������ �� ��������� ��������� ��������� � ����������� � ���� �������������� � ���������� ��������������� ��������, �������� ��� �� ������ ������, ����� ����������� �� ������� ���� ����.\r\n��������� � ����� � �����, �� ���� ��������� ��� �������� ��, ���� �� ��������, ������������ �� ��������� ������� �� ������� � ��������� ����� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode73Chois1()
		{
			int currEpizodeId = 73;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode74Chois1()
		{
			int currEpizodeId = 74;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������, ����� ���� ��� �� ������ ����� ������ ���, ����� ���������� ��������� � ��������� �� ������ �� ������� �����. ��������� �� ���-�������� �� �����, ��� �������� ��������, �� ������� � ��������� �� �������� ������� ��������� � ������� ������. ��� ����� ���� ��� ���������� �� �������� � �������� ��������� ���� �� ���������� ������ � ���� ����������� ��������� ���� ������ �������:\r\n� ��������� ����� ������� �� ������! ������� � ��������� �������! ������ ����� ����� �� �� ������� ��� ������ �� �������! ���������� ���� �� ������� � ��������� ��! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� �� ��������! � ����� ������. � ��� �� �� ������� � ����? � �������� ���������� � ����� ��������� �������� �����.\r\n� ��������� ����� ������� �� ������! ������� � ��������� �������! ������ ����� ����� �� �� ������� ��� ������ �� �������! ���������� ���� �� ������� � ��������� ��! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������! � ���������� �� ����� ��������� �������.\r\n� ���������, ���� �� �� ������� � ������ � �������� ������������. � ����������� �� ���� �� �� ������ ��� ��������� �� �������.\r\n� ��� �� �� ��������? � ��������� �������. � ���� ������, �� � ����� �� �������� ������, ����� ����.\r\n� �����, �� ���� � �������� ����� �� ���������� ����. ����� �� ������, ���� ������������� ���������� �� �� ��������. ���� �� �� �� ���������������.\r\n� ����� ���� �� ��� ������ �� �� ������, � � ������ �� ������� � �� �� ���������� ��. � �� ����� �� �� �� ������� �����?\r\n� ���� ��������, ��������� � �������� ������� ����������. � ��� � ����������� �� �������� ����������, � �� �� �� ������ � ������.\r\n� �� ���� ������� ����� � ������ �� ��������� ������ �����. � ������� ���� ������ ��� � ��� ������� ���� �� ������.\r\n��� ����������� �� �������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode75Chois1()
		{
			int currEpizodeId = 75;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode76Chois1()
		{
			int currEpizodeId = 76;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �����.\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode76Chois2()
		{
			int currEpizodeId = 76;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� �����.\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

	}
}